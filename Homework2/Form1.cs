using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
    public partial class Form1 : Form
    {
        private PictureBox[] pic = new PictureBox[40];
        private int totalcol = 10;
        private int col;
        private int row;
        private int[] status;

        public Form1()
        {
            InitializeComponent();
            InitializeSeats(pic);
        }

        private void InitializeSeats(PictureBox[] pic)
        {
            CreateSeats();
            SetSeatImage();
        }

        private void CreateSeats()
        {
            for (int i = 0; i < 40; i++)
            {
                row = i / totalcol;
                col = i % totalcol;

                pic[i] = new PictureBox();
                pic[i].Size = new Size(87, 125);
                this.Controls.Add(pic[i]);

                pic[i].Location = new Point(87 * col, 125 * (row));
            }
        }

        private void SetSeatImage()
        {
            Random random = new Random();
            status = new int[40];
            for (int i = 0; i < 40; i++)
            {
                status[i] = random.Next(0, 2);
                pic[i].Image = GetSeatImage(status[i]);
            }
        }

        private Image GetSeatImage(int status)
        {
            if (status == 0)
            {
                return global::Homework2.Properties.Resources.seat_unavail;
            }
            else if (status == 1)
            {
                return global::Homework2.Properties.Resources.seat_avail;
            }
            else
            {
                return global::Homework2.Properties.Resources.seat_select;
            }
        }

        private void ChooseSeat()
        {
            for (int seatNum = 0; seatNum < status.Length; seatNum++)
            {
                if (seatNum % totalcol >= 0 && seatNum % totalcol <= 7)
                {
                    if (status[seatNum] == 1 & status[seatNum + 1] == 1 & status[seatNum + 2] == 1)
                    {
                        status[seatNum] = 2;
                        status[seatNum + 1] = 2;
                        status[seatNum + 2] = 2;
                        pic[seatNum].Image = GetSeatImage(2);
                        pic[seatNum + 1].Image = GetSeatImage(2);
                        pic[seatNum + 2].Image = GetSeatImage(2);
                        break;
                    }
                }
            }
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            ChooseSeat();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            SetSeatImage();
        }
    }
}