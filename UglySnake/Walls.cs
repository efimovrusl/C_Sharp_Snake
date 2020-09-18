using System;
using System.Collections.Generic;

namespace UglySnake
{
    public class Walls
    {
        private bool areDrawn;
        private char corner;
        private char vertical;
        private char horizontal;
        private List<Point> walls = new List<Point>();

        private Layout mapWindow;


        public Walls(Layout mapWindow, char corner, char vertical, char horizontal)
        {
            this.corner = corner;
            this.vertical = vertical;
            this.horizontal = horizontal;
            this.mapWindow = mapWindow;
            areDrawn = false;
        }

        public void Draw()
        {
            if (!areDrawn)
            {
                DrawHorizontal(mapWindow.getLeftB() + 1, mapWindow.getUpperB(), mapWindow.getWidth());
                DrawHorizontal(mapWindow.getLeftB() + 1, mapWindow.getLowerB(), mapWindow.getWidth());
                DrawVertical(mapWindow.getLeftB(), mapWindow.getUpperB() + 1, mapWindow.getHeight());
                DrawVertical(mapWindow.getRightB(), mapWindow.getUpperB() + 1, mapWindow.getHeight());
                DrawCorners();
                areDrawn = true;
            }
        }

        public void Clear()
        {
            if (areDrawn)
                foreach (Point point in walls)
                    point.Clear();
            areDrawn = false;
        }

        private void DrawHorizontal(int x, int y, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Point p = (x + i, y, horizontal);
                p.Draw();
                walls.Add(p);
            }
        }

        private void DrawVertical(int x, int y, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Point p = (x, y + i, vertical);
                p.Draw();
                walls.Add(p);
            }
        }

        private void DrawCorners()
        {
            Point leftUpper = (mapWindow.getLeftB(), mapWindow.getUpperB(), corner);
            Point leftLower = (mapWindow.getLeftB(), mapWindow.getLowerB(), corner);
            Point rightUpper = (mapWindow.getRightB(), mapWindow.getUpperB(), corner);
            Point rightLower = (mapWindow.getRightB(), mapWindow.getLowerB(), corner);
            leftUpper.Draw();
            leftLower.Draw();
            rightUpper.Draw();
            rightLower.Draw();
            walls.Add(leftUpper);
            walls.Add(leftLower);
            walls.Add(rightUpper);
            walls.Add(rightLower);
        }
    }
}