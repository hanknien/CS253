using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20150612_homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double CalculateYearPayment(double amount, int year, double rate)
        {
            double sum = 0;
            int i = 0;

            do
            {
                sum += Math.Pow((1 + rate / 100), i);

                i++;
            }
            while (i <= (year - 1));

            return amount * Math.Pow((1 + rate / 100), year) / sum;
        }

        private void CalculatePayment_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(amountInput.Text);
            int year = int.Parse(yearInput.Text);
            double rate = double.Parse(rateInput.Text);

            yearPayment.Text = string.Format("{0}", CalculateYearPayment(amount, year, rate));
        }
    }
}