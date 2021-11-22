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
        int countX = 0;
        bool turn = true;
        int player1Score = 0;
        int player2Score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void clearBoard()
        {
            btnTopLeft.Enabled = true;
            btnTopMid.Enabled = true;
            btnTopRight.Enabled = true;
            btnMidLeft.Enabled = true;
            btnMidMid.Enabled = true;
            btnMidRight.Enabled = true;
            btnBotLeft.Enabled = true;
            btnBotMid.Enabled = true;
            btnBotRight.Enabled = true;

            btnTopLeft.Text = "";
            btnTopMid.Text = "";
            btnTopRight.Text = "";
            btnMidLeft.Text = "";
            btnMidMid.Text = "";
            btnMidRight.Text = "";
            btnBotLeft.Text = "";
            btnBotMid.Text = "";
            btnBotRight.Text = "";

            btnTopLeft.BackColor = System.Drawing.Color.Black;
            btnTopMid.BackColor = System.Drawing.Color.Black;
            btnTopRight.BackColor = System.Drawing.Color.Black;
            btnMidLeft.BackColor = System.Drawing.Color.Black;
            btnMidMid.BackColor = System.Drawing.Color.Black;
            btnMidRight.BackColor = System.Drawing.Color.Black;
            btnBotLeft.BackColor = System.Drawing.Color.Black;
            btnBotMid.BackColor = System.Drawing.Color.Black;
            btnBotRight.BackColor = System.Drawing.Color.Black;

            countX = 0;
            turn = true;

            playerScore1.Text = player1Score.ToString();
            playerScore2.Text = player2Score.ToString();
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
                countX += 1;
            }
            else
            {
                x.Text = "O";
            }

            x.Enabled = false;
            turn = !turn;
            x.BackColor = System.Drawing.Color.White;
            x.ForeColor = System.Drawing.Color.Black;


            getWinner();

            
        }

        private void getWinner()
        {

            // For Horizontal combination

            if ((btnTopLeft.Text == btnTopMid.Text) && (btnTopMid.Text == btnTopRight.Text) && (!btnTopLeft.Enabled))
            {
             
                if (btnTopLeft.Text == "X")
                {
                    MessageBox.Show("X wins!");
                    player1Score ++;
                }
                else
                {
                    MessageBox.Show("O wins!");
                    player2Score ++;
                }
                clearBoard();
            }
            else if ((btnMidLeft.Text == btnMidMid.Text) && (btnMidMid.Text == btnMidRight.Text) && (!btnMidLeft.Enabled))
            {
                if (btnMidLeft.Text == "X")
                {
                    MessageBox.Show("X wins!");
                    player1Score++;
                }
                else
                {
                    MessageBox.Show("O wins!");
                    player2Score++;
                }
                clearBoard();
            }
            else if ((btnBotLeft.Text == btnBotMid.Text) && (btnBotMid.Text == btnBotRight.Text) && (!btnBotLeft.Enabled))
            {
                if (btnBotLeft.Text == "X")
                {
                    MessageBox.Show("X wins!");
                    player1Score++;
                }
                else
                {
                    MessageBox.Show("O wins!");
                    player2Score++;
                }
                clearBoard();
            }

            // Vertical

            if ((btnTopLeft.Text == btnMidLeft.Text) && (btnMidLeft.Text == btnBotLeft.Text) && (!btnTopLeft.Enabled))
            {

                if (btnTopLeft.Text == "X")
                {
                    MessageBox.Show("X wins!");
                    player1Score++;
                }
                else
                {
                    MessageBox.Show("O wins!");
                    player2Score++;
                }
                clearBoard();
            }
            else if ((btnTopMid.Text == btnMidMid.Text) && (btnMidMid.Text == btnBotMid.Text) && (!btnTopMid.Enabled))
            {
                if (btnTopMid.Text == "X")
                {
                    MessageBox.Show("X wins!");
                    player1Score++;
                }
                else
                {
                    MessageBox.Show("O wins!");
                    player2Score++;
                }
                clearBoard();
            }
            else if ((btnTopRight.Text == btnMidRight.Text) && (btnMidRight.Text == btnBotRight.Text) && (!btnTopRight.Enabled))
            {
                if (btnTopRight.Text == "X")
                {
                    MessageBox.Show("X wins!");
                    player1Score++;
                }
                else
                {
                    MessageBox.Show("O wins!");
                    player2Score++;
                }
                clearBoard();
            }

            // Diagonal

            if ((btnTopLeft.Text == btnMidMid.Text) && (btnMidMid.Text == btnBotRight.Text) && (!btnTopLeft.Enabled))
            {

                if (btnTopLeft.Text == "X")
                {
                    MessageBox.Show("X wins!");
                    player1Score++;
                }
                else
                {
                    MessageBox.Show("O wins!");
                    player2Score++;
                }
                clearBoard();
            }
            else if ((btnTopRight.Text == btnMidMid.Text) && (btnMidMid.Text == btnBotLeft.Text) && (!btnTopRight.Enabled))
            {
                if (btnTopMid.Text == "X")
                {
                    MessageBox.Show("X wins!");
                    player1Score++;
                }
                else
                {
                    MessageBox.Show("O wins!");
                    player2Score++;
                }
                clearBoard();
            }

        }

        
        private void btnReset_Click(object sender, EventArgs e)
        {
            clearBoard();
        }

    }
}
