using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        int turnCounts = 0;
        bool turn = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClick(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            if (turn)
            {
                x.Text = "X";
            }
            else
            {
                x.Text = "O";
            }

            x.Click -= this.btnClick;
            turn = !turn;
        }
    }
}
