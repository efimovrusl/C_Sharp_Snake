using System;
using System.Threading;

namespace UglySnake
{
    static class Frame
    {
        public static void update()
        {
            Console.SetCursorPosition(9, 5);
            Console.WriteLine(DateTime.Now.Ticks);
        }
    }
}