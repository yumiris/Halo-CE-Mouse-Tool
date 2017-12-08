﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;

/*
    -Keybind Class-
    Detect if a key is pushed down, and if keybinds are enabled or not.
    Needs to be expanded to be more useful.
*/
namespace Halo_CE_Mouse_Tool
{
    public static class KeybindHandler
    {

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);


        public static bool IsKeyPushedDown(System.Windows.Forms.Keys vKey)
        {
            return 0 != (GetAsyncKeyState(vKey) & 0x8000);
        }

        public static bool KeybindsEnabled { get; set; }

    }
}
