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

            //FOR X COMBINATIONS

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

            if (btnTopMid.Text == "X")
            {
                if (btnMidMid.Text == "X" && btnBotMid.Text == "X")
                {
                    isWinner = true;
                }
            }
            if (btnTopRight.Text == "X")
            {
                if (btnMidMid.Text == "X" && btnBotLeft.Text == "X")
                {
                    isWinner = true;
                }
                else if (btnMidRight.Text == "X" && btnBotRight.Text == "X")
                {
                    isWinner = true;
                }
            }
            if (btnMidLeft.Text == "X")
            {
                if (btnMidMid.Text == "X" && btnMidRight.Text == "X")
                {
                    isWinner = true;
                }
            }
            if (btnBotLeft.Text == "X")
            {
                if (btnBotMid.Text == "X" && btnBotRight.Text == "X")
                {
                    isWinner = true;
                }
            }

            // FOR O COMBINATIONS

            if (btnTopLeft.Text == "O")
            {
                if (btnTopMid.Text == "O" && btnTopRight.Text == "O")
                {
                    isWinner = true;
                }
                else if (btnMidMid.Text == "O" && btnBotRight.Text == "O")
                {
                    isWinner = true;
                }
                else if (btnMidLeft.Text == "O" && btnBotLeft.Text == "O")
                {
                    isWinner = true;
                }
            }
            if (btnTopMid.Text == "O")
            {
                if (btnMidMid.Text == "O" && btnBotMid.Text == "O")
                {
                    isWinner = true;
                }
            }
            if (btnTopRight.Text == "O")
            {
                if (btnMidMid.Text == "O" && btnBotLeft.Text == "O")
                {
                    isWinner = true;
                }
                else if (btnMidRight.Text == "O" && btnBotRight.Text == "O")
                {
                    isWinner = true;
                }
            }
            if (btnMidLeft.Text == "O")
            {
                if (btnMidMid.Text == "O" && btnMidRight.Text == "O")
                {
                    isWinner = true;
                }
            }
            if (btnBotLeft.Text == "O")
            {
                if (btnBotMid.Text == "O" && btnBotRight.Text == "O")
                {
                    isWinner = true;
                }
            }

            turnCounts += 1;
            if (turnCounts == 9)
            {
                MessageBox.Show("Draw");
                Form1 newForm = new Form1();
                newForm.Show();
                this.Dispose(false);
            }

            if (isWinner)
            {
                if (turn)
                {
                    MessageBox.Show("O wins!");
                    Form1 newForm = new Form1();
                    newForm.Show();
                    this.Dispose(false);
                }
                else
                {
                    MessageBox.Show("X wins!");
                    Form1 newForm = new Form1();
                    newForm.Show();
                    this.Dispose(false);
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
