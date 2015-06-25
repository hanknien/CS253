using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Form1 : Form
    {
        private player player1;
        private player player2;

        public Form1()
        {
            InitializeComponent();
            player1 = new player();
            player1.name = "Player1";
            player2 = new player();
            player2.name = "Player2";
        }

        private void judgeWhoWinButton_Click(object sender, EventArgs e)
        {
            player1.finger = int.Parse(player1TextBox.Text);
            player2.finger = int.Parse(player2TextBox.Text);

            player1.JudgeWhoWin(player2.finger);
        }
    }
}