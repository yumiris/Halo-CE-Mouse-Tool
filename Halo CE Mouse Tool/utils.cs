﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal; //For checking if user is running as admin
using System.Diagnostics;
using System.Media;
using System.IO;

namespace Halo_CE_Mouse_Tool {
    public static class utils {
        public static void WriteHaloMemory() {
            byte[] mouseaccelnop = { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
            int return_value;
            int curr_addr = 0;
            byte[] curr_val = { };
            for (int i = 0; i != 4; i++) {
                if (i == 0) {
                    curr_val = BitConverter.GetBytes(Mainform.settings.SensX);
                    curr_addr = 0x2ABB50;
                }
                if (i == 1) {
                    curr_val = BitConverter.GetBytes(Mainform.settings.SensY);
                    curr_addr = 0x2ABB54;
                }
                if (i == 2 && Mainform.settings.PatchAcceleration == 1) {
                    curr_val = mouseaccelnop;
                    curr_addr = 0x8F836;
                }
                if (i == 3 && Mainform.settings.PatchAcceleration == 1) {
                    curr_val = mouseaccelnop;
                    curr_addr = 0x8F830;
                }
                return_value = MemoryHandler.WriteToProcessMemory("haloce", curr_val, curr_addr);
                if (return_value != 0) {
                    sounds.sound_error();
                    if (return_value == 1) {
                        MessageBox.Show("Access Denied. Are you running the tool as Admin?");
                    } else {
                        MessageBox.Show("One or more values failed to write. Error code " + return_value);
                    }
                }
            }
            sounds.sound_success();
            MessageBox.Show("Successfully wrote values to memory.");
        }

        public static void HandleXML() {
            int loadxml = XMLHandler.LoadSettingsFromXML(Mainform.settings);
            if (loadxml == 1) {
                sounds.sound_success();
                MessageBox.Show("Successfully found & Read XML.");
            } else if (loadxml == 2 || loadxml == 3) {
                sounds.sound_error();
                MessageBox.Show("An XML file was found, but an error occurred whilst reading it. It is possible one or more settings were not set. They have been set to default.");
            } else {
                sounds.sound_notice();
                MessageBox.Show("Didn't find an XML file. Will now generate one with default values...");
                XMLHandler.GenerateXML();
                XMLHandler.LoadSettingsFromXML(Mainform.settings);
            }
        }

        public static bool IsAdministrator() {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                      .IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static void parse_sensitivity(TextBox origin, char sens) {
            float conv_float;
            if (origin.Text != "") {
                if (!float.TryParse(origin.Text, out conv_float)) {
                    origin.Text = "0";
                    MessageBox.Show("Invalid input. Only numbers allowed.");
                } else {
                    if (sens == 'x') {
                        Mainform.settings.SensX = conv_float;
                    } else {
                        Mainform.settings.SensY = conv_float;
                    }
                }
            }
        }

        public static void check_if_blank(TextBox origin) {
            if (origin.Text == "") {
                origin.Focus();
                MessageBox.Show("Error: You can't leave this field blank.");
            }
        }

        public static void CheckForUpdates() {
            int res = UpdateHandler.CheckForUpdates();
            if (res == 2) {
                sounds.sound_error();
                MessageBox.Show("An error occurred while checking for updates(Timeout?)");
            } else {
                sounds.sound_notice();
                if (res == 0) {
                    MessageBox.Show("No updates were found.");
                } else {
                    DialogResult d = MessageBox.Show("An Update is Available. Would you like to visit the downloads page?", "Update Found", MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes) {
                        Process.Start("https://github.com/AWilliams17/Halo-CE-Mouse-Tool/releases");
                    }
                }
            }
        }

        public static class sounds {
            private static Stream success_file = Properties.Resources.SND_Success;
            private static Stream notice_file = Properties.Resources.SND_Notice;
            private static Stream error_file = Properties.Resources.SND_Error;
            private static SoundPlayer success = new System.Media.SoundPlayer(success_file);
            private static SoundPlayer notice = new System.Media.SoundPlayer(notice_file);
            private static SoundPlayer error = new System.Media.SoundPlayer(error_file);

            public static void sound_success() {
                if (Mainform.settings.SoundsEnabled == 1) {
                    success.Play();
                }
            }

            public static void sound_error() {
                if (Mainform.settings.SoundsEnabled == 1) {
                    error.Play();
                }
            }

            public static void sound_notice() {
                if (Mainform.settings.SoundsEnabled == 1) {
                    notice.Play();
                }
            }
        }

        public static void keybind_handle() {
            if (KeybindHandler.KeybindsEnabled && Mainform.settings.HotkeyEnabled == 1) {
                if (KeybindHandler.IsKeyPushedDown((Keys)Enum.Parse(typeof(Keys), Mainform.settings.Hotkey))) {
                    WriteHaloMemory();
                }
            }
        }
    }
}