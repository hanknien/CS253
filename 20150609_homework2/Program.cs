using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150609_homework2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = GetUserInput();
            int sum = SumOddNum(x);
            PrintAns(x, sum);
        }

        public static int GetUserInput()
        {
            Console.Write("請輸入x的值:");
            int x;
            return x = int.Parse(Console.ReadLine());
        }

        public static int SumOddNum(int x)
        {
            int sum = 0;
            for (int i = 1; i <= x; i += 2)
                sum += i;
            return sum;
        }

        public static void PrintAns(int x, int sum)
        {
            Console.WriteLine("1~{0}所有奇數和為{1}", x, sum);
        }
    }
}