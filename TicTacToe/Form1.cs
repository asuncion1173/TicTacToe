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
            if (true)
            {
                x.Text = "X";
            }
            else
            {
                x.Text = "O";
            }
        }
    }
}
