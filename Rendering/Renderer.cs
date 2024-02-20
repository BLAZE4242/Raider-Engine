using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Raider_Engine.Rendering
{
    class Renderer
    {
        static float squareX = 0;
        static Dictionary<Rectangle, Brush> renderQueue = new Dictionary<Rectangle, Brush>();

        public static void Init(Vector2Int windowRes)
        {
            Window.RunWindow(windowRes);
        }

        public static void RefreshFrame(object sender, PaintEventArgs e)
        {
            foreach (KeyValuePair<Rectangle, Brush> render in renderQueue)
            {
                e.Graphics.FillRectangle(render.Value, render.Key);

            }
        }

        public static void RenderPixel(Vector2Int pixelPos)
        {
            renderQueue.Add(new Rectangle(pixelPos.x, pixelPos.y, 4, 4), Brushes.Black);
        }

        // temp
        static int i = 0;
        public static void Update()
        {
            i++;

            RenderPixel(new Vector2Int(i, 50));
            //if (i % 2 == 0)
            //{
            //    renderQueue = new Dictionary<Rectangle, Brush>();
            //    renderQueue.Add(new Rectangle(50, 50, 50, 50), Brushes.Black);
            //}
            //else
            //{
            //    renderQueue = new Dictionary<Rectangle, Brush>();
            //    renderQueue.Add(new Rectangle(50, 50, 50, 50), Brushes.Green);
            //}
        }
    }
}
