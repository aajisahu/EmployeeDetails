using System;

namespace line_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparison computation program ");
            int x1, y1, x2, y2;
            Console.WriteLine("enter the co-ordinates of point x1 and y1");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter co-ordinates for second point x2 and y2");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("length of given line is:" + length);
        }
    }
}