using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    internal class MathOperators
    {
        public static void AddNums(double num1, double num2)
        {
            double sum = num1 + num2;
            Console.WriteLine(sum);
            Console.WriteLine();
        }

        public static void SubtractNums(double num1, double num2)
        {
            double sum = num1 - num2;
            Console.WriteLine(sum);
            Console.WriteLine();
        }

        public static void MultiplyNums(double num1, double num2)
        {
            double product = num1 * num2;
            Console.WriteLine(product);
            Console.WriteLine();
        }

        public static void DivideNums(double num1, double num2)
        {
            double result = num1 / num2;
            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}
