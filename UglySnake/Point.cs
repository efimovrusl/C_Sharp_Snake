using System;

namespace UglySnake
{
    public class Point
    {
        private int x { get; set; }
        private int y { get; set; }
        private char ch { get; set; }

        public static implicit operator Point((int, int, char) value) =>
            new Point {x = value.Item1, y = value.Item2, ch = value.Item3};

        public void Draw()
        {
            DrawPoint(ch);
        }

        public void Clear()
        {
            DrawPoint(' ');
        }

        private void DrawPoint(char _ch)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(_ch);
        }

        public static bool operator ==(Point a, Point b)
        {
            return a.x == b.x && a.y == b.y;
        }

        public static bool operator !=(Point a, Point b)
        {
            return !(a == b);
        }
    }
}