using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    internal class player
    {
        public string name;
        public int finger;

        public void JudgeWhoWin(int anotherFinger)
        {
            if (finger == anotherFinger)
            {
                MessageBox.Show("雙方平手");
            }
            else if ((finger == 2 && anotherFinger == 1) || (finger == 3 && anotherFinger == 2) || ((finger == 1 && anotherFinger == 3)))
            {
                MessageBox.Show(name + "贏了!");
            }
            else
            {
                MessageBox.Show(name + "輸了!");
            }
        }
    }
}