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
        static Dictionary<Point[], Pen> lineDrawQueue = new Dictionary<Point[], Pen>();
        static Dictionary<Rectangle, Brush> pixelDrawQueue = new Dictionary<Rectangle, Brush>();

        public static void Init(Vector2Int windowRes)
        {
            Window.RunWindow(windowRes);
        }

        public static void RefreshFrame(object sender, PaintEventArgs e)
        {
            foreach (KeyValuePair<Point[], Pen> draw in lineDrawQueue)
            {
                e.Graphics.DrawLine(draw.Value, draw.Key[0], draw.Key[1]);
            }

            foreach (KeyValuePair<Rectangle, Brush> draw in pixelDrawQueue)
            {
                e.Graphics.FillRectangle(draw.Value, draw.Key);
            }
        }

        public static void DrawLine(Vector2Int pixelPos1, Vector2Int pixelPos2)
        {
            lineDrawQueue.Add(
                new Point[]
                {
                    new Point(pixelPos1.x, pixelPos1.y),
                    new Point(pixelPos2.x, pixelPos2.y)
                },
                Pens.Black
            );
        }

        public static void DrawPixel(Vector2Int pixelPos)
        {
            Rectangle rect = new Rectangle(pixelPos.x, pixelPos.y, 4, 4);

            if (pixelDrawQueue.ContainsKey(rect))
            {
                return;
            }

            pixelDrawQueue.Add(
                new Rectangle(pixelPos.x, pixelPos.y, 1, 1),
                Brushes.Black
            );;
        }

        public static void RenderWorld(World world)
        {
            List<Vector2Int> verticesDrawn = new List<Vector2Int>();

            foreach (Vector3 vertex in world.vertices)
            {
                float x = (Settings.focalLength * vertex.x) / (Settings.focalLength + vertex.z);
                float y = (Settings.focalLength * vertex.y) / (Settings.focalLength + vertex.z);
                Vector2Int newVertex = new Vector2Int(x, y);

                DrawPixel(newVertex);
                verticesDrawn.Add(newVertex);
            }

            foreach (Vector2Int edge in world.edgeConnections)
            {
                DrawLine(new Vector2Int(verticesDrawn[edge.x-1].x, verticesDrawn[edge.x-1].y), new Vector2Int(verticesDrawn[edge.y-1].x, verticesDrawn[edge.y-1].y));
            }
        }
    }
}
