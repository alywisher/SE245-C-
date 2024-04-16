using System;

//create a progtam that includes point structure with integer X and Y coordinates, implement a method called GetRandomPoint that returns a pint with a specified range, call the method and display the random point

namespace practice
{

    struct Point //where this bitch go
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    class Program 
    {
        static Point GetRandomPoint()
        {
            Random rnd = new Random();
            int X = rnd.Next(-100, 100);
            int Y = rnd.Next(-100, 100);

            return new Point(X, Y);
        }
        static void Main (string[] args) 
        {
            Point point = GetRandomPoint();

            //display returned point
            Console.Write($"Return Point: X={point.X}, Y={point.Y}");
        }
    }

}