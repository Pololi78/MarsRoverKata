using System;

namespace MarsRoverKataApi
{
    public class Point
    {

        public Point(Int32 x, Int32 y)
        {
            X = x;
            Y = y;
        }

        public Int32 X { get; set; }
        public Int32 Y { get; set; }

    }
}