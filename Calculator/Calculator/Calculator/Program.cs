using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public static double Operations(double num1, double num2, string op)
        {
            double result = double.NaN;

            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "d":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                case "m":
                    result = num1 * num2;
                    break;

                default:
                    break;
            }

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //runs your console application
            bool endApplication = false;
            Console.WriteLine(value: "Console Calculator Application in C#!");
            Console.WriteLine(value: "-------------------\n");

            string numInput1 = string.Empty;
            string numInput2 = string.Empty;
            string op = string.Empty;
            double result = 0;

            while (!endApplication)
            {
                Console.WriteLine(value: "Type a number here, then press Enter: ");
                numInput1 = Console.ReadLine();

                double number1 = 0;
                while (!double.TryParse(numInput1, out number1))
                {
                    Console.WriteLine(value: "This is not a valid number. Please enter an integer value and press Enter: ");
                    numInput1 = Console.ReadLine();
                }

                Console.WriteLine(value: "Type your second number, then press Enter:  ");
                numInput2 = Console.ReadLine();

                double number2 = 0;
                while (!double.TryParse(numInput2, out number2))
                {
                    Console.WriteLine(value: "This is not a valid number. Please enter an integer value and press Enter: ");
                    numInput2 = Console.ReadLine();
                }

                Console.WriteLine(value: "Choose an operation from this list: ");
                Console.WriteLine(value: "\ta - Add");
                Console.WriteLine(value: "\ts - Subtract");
                Console.WriteLine(value: "\td - Divide");
                Console.WriteLine(value: "\tm - Multiply");

                op = Console.ReadLine();
                try
                {
                    result = Calculator.Operations(num1: number1, num2: number2, op);
                    if (double.IsNaN(result))
                    {
                        Console.Write(value: "This operation will result in a mathematical error.\n");
                    }
                    else
                    {
                        Console.WriteLine(value: $"Your result: {result}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(value: $"Oh no! An unexpected exception occured! {e}");
                }

                Console.WriteLine(value: "-----------------------");


                Console.WriteLine(value: "Press 'x' to close the application or any key to continue.");
                if (Console.ReadLine() == "x")
                {
                    endApplication = true;
                }

                Console.WriteLine(value: "\n");

                

            }
            return;
        }
    }
}
