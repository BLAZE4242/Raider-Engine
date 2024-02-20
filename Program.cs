using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Raider_Engine
{
    class Program
    {
        /// <summary>
        /// Entry point for the entire engine
        /// </summary>
        public static void Main()
        {
            Rendering.Renderer.Init(new Vector2Int(300, 300));
            Console.WriteLine("Haha");
            Console.ReadLine();

        }
    }
}
