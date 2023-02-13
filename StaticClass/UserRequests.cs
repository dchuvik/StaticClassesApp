using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    internal class UserRequests
    {
        public static string GetName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");

            return name;
        }

        public static double GetFirstDouble()
        {
            Console.Write("Please enter your first number: ");
            string firstNumText = Console.ReadLine();
            bool isDouble = double.TryParse(firstNumText, out double num1);

            while (!isDouble)
            {
                Console.Write($"That was an invalid input, try again: ");
                firstNumText = Console.ReadLine();
                isDouble = double.TryParse(firstNumText, out num1);
            }

            return num1;
        }

        public static double GetSecondDouble()
        {
            Console.Write("Please enter your second number: ");
            string secondNumText = Console.ReadLine();
            bool isDouble = double.TryParse(secondNumText, out double num2);

            while (!isDouble)
            {
                Console.Write($"That was an invalid input, try again: ");
                secondNumText = Console.ReadLine();
                isDouble = double.TryParse(secondNumText, out num2);
            }

            return num2;
        }
    }
}
