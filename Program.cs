using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            double result;
            string operation;
            while (true)
            {
                Console.WriteLine("Hello, welcome to the calculator program.");
                Console.WriteLine("Please enter the first number");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the operation you want to perform?");
                Console.WriteLine("Enter a for addition, s for subtraction, m for multiplication, d for division, e for exiting the program");
                operation = Console.ReadLine();
                switch (operation)
                {
                    case "a":
                        Console.WriteLine("The result is:" + (num1 + num2));
                        break;
                    case "s":
                        Console.WriteLine("The result is:" + (num1 - num2));
                        break;
                    case "m":
                        Console.WriteLine("The result is:" + (num1 * num2));
                        break;
                    case "d":
                        try {
                            result = num1 / num2;
                            Console.WriteLine("The result is:" + (result));
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine($"{e.Message}");
                            return;
                        }
                        break;
                    case "e":
                        Console.WriteLine("Thank you for using the calculator program.");
                        return;
                    default:
                        Console.WriteLine("Invalid operation. Please try again.");
                        break;
                }
            }
        }
    }
}