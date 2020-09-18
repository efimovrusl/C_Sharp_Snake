using System;
using System.Threading;

namespace UglySnake
{

    class Game
    {
        private static readonly int width = 80;
        private static readonly int height = 35;

        private static void Main(string[] args)
        {
            /*
             * Console setup
             */
            Console.SetWindowSize(width + 1, height + 2);
            Console.SetBufferSize(width + 1, height + 2);
            Console.CursorVisible = false;
            Layout mapWindow = new Layout(6, 29, 3, 7);
            Walls walls = new Walls(mapWindow, '+', '|', '-');
            walls.Draw();
            while (true)
            {
                Frame.update();
                
                Thread.Sleep(100);
                walls.Clear();
                Thread.Sleep(100);
                walls.Draw();
            }
        }
    }
    
    
}