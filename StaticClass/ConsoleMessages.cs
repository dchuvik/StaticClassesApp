using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    internal class ConsoleMessages
    {
        public static void SayHi()
        {
            Console.WriteLine("Hello! Welcome to the Math Operation App! ");
            Console.WriteLine();
        }

        public static void SayBye(string name)
        {
            Console.WriteLine($"Goodbye {name}! Thanks for using our app!");
            Console.WriteLine();
        }

        public static void AddMessage(double num1, double num2)
        {
            Console.Write($"Here is the sum of {num1} + {num2}: ");
            Console.WriteLine();
        }

        public static void SubtractMessage(double num1, double num2)
        {
            Console.Write($"Here is the sum of {num1} - {num2}: ");
            Console.WriteLine();
        }

        public static void MultiplyMessage(double num1, double num2)
        {
            Console.Write($"Here is the product of {num1} X {num2}: ");
            Console.WriteLine();
        }

        public static void DivideMessage(double num1, double num2)
        {
            Console.Write($"Here is the result of {num1} / {num2}: ");
            Console.WriteLine();
        }
    }
}
