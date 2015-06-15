using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150612_homework1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = GetUserInput();
            CalculateFactorial(x);
        }

        public static int GetUserInput()
        {
            Console.Write("請輸入任一正整數值:");
            return int.Parse(Console.ReadLine());
        }

        public static void CalculateFactorial(int x)
        {
            int factorial = 1;
            int i = 1;
            while (i <= x)
            {
                factorial *= i++;
            }

            Console.WriteLine("{0}!的值為{1}", x, factorial);
        }
    }
}