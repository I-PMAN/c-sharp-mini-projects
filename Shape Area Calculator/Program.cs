using System;

namespace ShapeArea
{
    class Program
    {
        static void Main(string[] args)
        {   
            double area = 0;
            Console.WriteLine("Enter a shape and find it's area.");
            Console.WriteLine("Enter 'c' for circle, 'r' for recrangle, 's' for square, 't' for triangle or e to exit");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "c":
                    Console.WriteLine("Enter the radius.");
                    int radius = Convert.ToInt32(Console.ReadLine());
                    area = radius * 3.14;
                    break;
                case "r":
                    Console.WriteLine("Enter the length.");
                    int length = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the breadth.");
                    int breadth = Convert.ToInt32(Console.ReadLine());
                    area = length * breadth;
                    break;
                case "s":
                    Console.WriteLine("Enter the side of square.");
                    int side = Convert.ToInt32(Console.ReadLine());
                    area = Math.Pow(side, 2);
                    break;
                case "t":
                    Console.WriteLine("Enter the base.");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the height");
                    int height = Convert.ToInt32(Console.ReadLine());
                    area = 0.5 * b * height;
                    break;
                case "e":
                    Console.WriteLine("Exiting.");
                    return;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    return;

            }
            Console.WriteLine("The area is " + area);
        }
    }
}