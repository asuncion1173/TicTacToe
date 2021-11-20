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

            getWinner();
        }


        private void getWinner()
        {
            bool isWinner = false;

            if (btnTopLeft.Text == "X")
            {
                if (btnTopMid.Text == "X" && btnTopRight.Text == "X")
                {
                    isWinner = true;
                }
                else if (btnMidMid.Text == "X" && btnBotRight.Text == "X")
                {
                    isWinner = true;
                }
                else if (btnMidLeft.Text == "X" && btnBotLeft.Text == "X")
                {
                    isWinner = true;
                }
            }

            //if ((btntopleft.text == btntopmid.text) && (btntopmid.text == btntopright.text) && (!btntopleft.enabled))
            //{
            //    iswinner = true;
            //}
            //else if ((btnmidleft.text == btnmidmid.text) && (btnmidmid.text == btnmidright.text) && (!btnmidleft.enabled))
            //{
            //    iswinner = true;
            //}
            //else if ((btnbotleft.text == btnbotmid.text) && (btnbotmid.text == btnbotright.text) && (!btnbotleft.enabled))
            //{
            //    iswinner = true;
            //}


            if (isWinner)
            {
                if (turn)
                {
                    MessageBox.Show("O wins!");
                }
                else
                {
                    MessageBox.Show("X wins!");
                }
               
            }
        }

        
        private void btnReset_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Dispose(false);
        }
    }
}
