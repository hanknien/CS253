using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150605_homework1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PrintQuestion();
            PrintResult();
        }

        public static void PrintQuestion()
        {
            Console.WriteLine("請使用者輸入4個整數:");
        }

        public static string GetUserInput()
        {
            return Console.ReadLine();
        }

        public static void SumUserInput(string a, string b)
        {
            int sum = int.Parse(a) + int.Parse(b);
            string result = sum.ToString();
            Console.WriteLine("{0}", result);
        }

        public static void PrintResult()
        {
            string a = GetUserInput();
            string b = GetUserInput();
            string c = GetUserInput();
            string d = GetUserInput();
            Console.WriteLine("前兩個與後兩個相加和分別為:");
            SumUserInput(a, b);
            SumUserInput(c, d);
        }
    }
}