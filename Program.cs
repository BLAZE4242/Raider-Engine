using System;
using Raider_Engine.Rendering;

namespace Raider_Engine
{
    class Program
    {
        static World cube = new World(
            new Vector3[]
            {
                new Vector3(100, 300, 300),
                new Vector3(300, 300, 300),
                new Vector3(100, 300, 600),
                new Vector3(300, 300, 600),

                new Vector3(100, 100, 300),
                new Vector3(300, 100, 300),
                new Vector3(100, 100, 600),
                new Vector3(300, 100, 600),
            },
            new Vector2Int[]
            {
                new Vector2Int(1, 2),
                new Vector2Int(1, 3),
                new Vector2Int(1, 5),
                new Vector2Int(2, 4),
                new Vector2Int(2, 6),
                new Vector2Int(3, 4),
                new Vector2Int(3, 7),
                new Vector2Int(4, 8),
                new Vector2Int(5, 7),
                new Vector2Int(5, 6),
                new Vector2Int(6, 8),
                new Vector2Int(7, 8),
            }
        );

        /// <summary>
        /// Entry point for the entire engine
        /// </summary>
        public static void Main()
        {
            Renderer.Init(new Vector2Int(320, 320));
        }

        public static void Start()
        {
            ////Square
            //Renderer.DrawLine(new Vector2Int(20, 280), new Vector2Int(280, 280));
            //Renderer.DrawLine(new Vector2Int(20, 280), new Vector2Int(20, 20));
            //Renderer.DrawLine(new Vector2Int(20, 20), new Vector2Int(280, 20));
            //Renderer.DrawLine(new Vector2Int(280, 20), new Vector2Int(280, 280));

            //Renderer.DrawPixel(new Vector2Int(20, 280));
            //Renderer.DrawPixel(new Vector2Int(280, 280));
            //Renderer.DrawPixel(new Vector2Int(20, 20));
            //Renderer.DrawPixel(new Vector2Int(280, 20));

            Renderer.RenderWorld(cube);
        }


        // temp
        static int i = 0;
        public static void Update()
        {
            i++;
        }
    }
}
