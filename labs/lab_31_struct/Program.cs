using System;

namespace lab_31_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            var P01 = new Point(10, 10);
            var P02 = new Point(20, 20);
        }
    }

    class X { }

    struct Point
    {
        public int X;
        public int Y;
        // CONSTRUCTOR
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }




}
