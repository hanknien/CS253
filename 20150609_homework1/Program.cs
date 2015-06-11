using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150609_homework1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string month = GetUserInput();
            ConvertSeason(month);
        }

        public static string GetUserInput()
        {
            Console.Write("請使用者輸入月份:");

            return Console.ReadLine();
        }

        public static void ConvertSeason(string month)
        {
            switch (month)
            {
                case "3":
                case "4":
                case "5":
                    Console.WriteLine("{0}月屬於春季!", month);
                    break;

                case "6":
                case "7":
                case "8":
                    Console.WriteLine("{0}月屬於夏季!", month);
                    break;

                case "9":
                case "10":
                case "11":
                    Console.WriteLine("{0}月屬於秋季!", month);
                    break;

                case "12":
                case "1":
                case "2":
                    Console.WriteLine("{0}月屬於冬季!", month);
                    break;
            }
        }
    }
}