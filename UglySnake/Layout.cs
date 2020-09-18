using System;

namespace UglySnake
{
    public class Layout
    {
        private int leftBorder { get; set; }
        private int rightBorder { get; set; }
        private int upperBorder { get; set; }
        private int lowerBorder { get; set; }

        public Layout(int leftB, int rightB, int upperB, int lowerB)
        {
            leftBorder = leftB;
            rightBorder = rightB;
            upperBorder = upperB;
            lowerBorder = lowerB;
        }

        public int getLeftB()
        {
            return leftBorder;
        }

        public int getRightB()
        {
            return rightBorder;
        }

        public int getUpperB()
        {
            return upperBorder;
        }

        public int getLowerB()
        {
            return lowerBorder;
        }

        public int getWidth()
        {
            return Math.Abs(rightBorder - leftBorder - 1);
        }

        public int getHeight()
        {
            return Math.Abs(lowerBorder - upperBorder - 1);
        }
    }
}