﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Halo_CE_Mouse_Tool
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void EnableBtnTimer_Tick(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("haloce").Length > 0)
            {
                ActivateBtn.Enabled = true;
                StatusLabel.Text = "Halo CE Process Detected.";
                StatusLabel.ForeColor = Color.Green;
            }
            else
            {
                ActivateBtn.Enabled = false;
                StatusLabel.Text = "Waiting for Halo CE Process...";
                StatusLabel.ForeColor = Color.Red;
            }
        }


        private void ActivateBtn_Click(object sender, EventArgs e)
        {
            float mousesens = float.Parse(Sens.Text) * 0.25f;
            MessageBox.Show(HaloMemWriter.WriteHaloMemory(mousesens).ToString());
        }


        private void PatchBtn_Click(object sender, EventArgs e)
        {

        }

        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Put Github Link here later
        }

        private void RedditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Process.Start("https://www.reddit.com/r/halospv3/comments/5dk9ta/finallyhalo_ce_mouse_fix_tool_v10_also_open_source/");
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            //Check for Updates
        }
    }
}