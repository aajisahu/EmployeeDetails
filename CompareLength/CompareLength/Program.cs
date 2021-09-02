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
            Console.WriteLine("length of line1 is:" + length);
            Console.WriteLine("enter another point co-ordinates for comparison x3 and y3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            double length2 = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            Console.WriteLine("length of line 2 is :" + length2);
            if (length < length2)
            {
                Console.WriteLine("line 1 is less than line 2");
            }
            else if (length > length2)
            {
                Console.WriteLine("line 1 is greater than line 2");
            }
            else
            {
                Console.WriteLine("both lines are equal");
            }
        }
    }
}