using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150605_homework2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = GetUserName();
            GuessGender(name);
        }

        public static string GetUserName()
        {
            Console.Write("請使用者輸入姓名:");
            return Console.ReadLine();
        }

        public static void GuessGender(string name)
        {
            Random random = new Random();

            int gender = random.Next(1, 3);

            string guess = (gender == 1 ? "男生" : "女生");
            Console.Write("{0}，您是{1}嗎?請填(y/n)", name, guess);
            string ans = Console.ReadLine();
            Console.WriteLine(IsYes(ans) ? "我猜對了" : "抱歉，我猜錯了");
        }

        public static bool IsYes(string ans)
        {
            return ans == "yes" || ans == "Yes" || ans == "y" || ans == "Y";
        }
    }
}