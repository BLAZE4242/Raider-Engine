﻿using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Raider_Engine.Rendering
{
    class Window : Form
    {
        public static Window _window;
        public static int frameCount = 0;

        public Window(Vector2Int windowRes)
        {
            Text = $"{Settings.WindowTitle} V{Settings.Version}";
            Size = new Size(windowRes.x, windowRes.y);

            Paint += Renderer.RefreshFrame;

            Program.Start();

            // Update
            Timer timer = new Timer();
            timer.Interval = 1000 / Settings.TargetFrameRate;
            timer.Tick += RefreshFrame;
            timer.Start();
        }

        private void RefreshFrame(object sender, EventArgs e)
        {
            frameCount++;
            Program.Update();
            Invalidate();
        }

        public static void RunWindow(Vector2Int windowRes)
        {
            Application.EnableVisualStyles();
            _window = new Window(windowRes);
            Application.Run(_window);
        }
    }
}
