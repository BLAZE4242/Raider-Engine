using System;
using Raider_Engine.Rendering;

namespace Raider_Engine
{
    class Program
    {
        World cube = new World(
            new Vector3[]
            {
                new Vector3(-1, 1, -3),
                new Vector3(1, 1, -3),
                new Vector3(-1, 1, -6),
                new Vector3(1, 1, -6),

                new Vector3(-1, -1, -3),
                new Vector3(1, -1, -3),
                new Vector3(-1, -1, -6),
                new Vector3(1, -1, -6),
            }

        );

        /// <summary>
        /// Entry point for the entire engine
        /// </summary>
        public static void Main()
        {
            Rendering.Renderer.Init(new Vector2Int(320, 320));
            Console.WriteLine("Haha");
            Console.ReadLine();
        }

        public static void Start()
        {
            //Square
            //Renderer.DrawLine(new Vector2Int(20, 280), new Vector2Int(280, 280));
            //Renderer.DrawLine(new Vector2Int(20, 280), new Vector2Int(20, 20));
            //Renderer.DrawLine(new Vector2Int(20, 20), new Vector2Int(280, 20));
            //Renderer.DrawLine(new Vector2Int(280, 20), new Vector2Int(280, 280));

            //Renderer.DrawPixel(new Vector2Int(20, 280));
            //Renderer.DrawPixel(new Vector2Int(280, 280));
            //Renderer.DrawPixel(new Vector2Int(20, 20));
            //Renderer.DrawPixel(new Vector2Int(280, 20));


        }


        // temp
        static int i = 0;
        public static void Update()
        {
            i++;
        }
    }
}
