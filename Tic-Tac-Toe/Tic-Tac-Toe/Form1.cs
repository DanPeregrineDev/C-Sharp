using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool CurrentPlayer = true;
        int[,] board = new int[3, 3];
        int CountClicks = 0;

        public Form1()
        {
            InitializeComponent();

            for(int line=0; line < 3; line++)
            {
                for (int column = 0; column < 3; column++)
                {
                    board[line, column] = 0;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            
            if (CurrentPlayer)
            {
                if (pictureBox.Image == null)
                {
                    pictureBox.Image = PB_USER1.Image;
                    CurrentPlayer = !CurrentPlayer;
                }
            }
            else
            {
                if (pictureBox.Image == null)
                {
                    pictureBox.Image = PB_USER2.Image;
                    CurrentPlayer = !CurrentPlayer;
                }
            }

            string[] position = pictureBox.Tag.ToString().Split(';');
            int line = int.Parse(position[0]);
            int column = int.Parse(position[1]);

            board[line, column] = CurrentPlayer ? 1 : 2;
            CountClicks++;

            int player = verifyWin();
            if (player != 0 || CountClicks == 9)
            {
                if (player == 0)
                {
                    MessageBox.Show("Draw!");
                }
                else
                {
                    MessageBox.Show($"Player {player} has won!");
                }

                ResetGame();
            }
        }

        private void ResetGame()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;

            CurrentPlayer = true;
            CountClicks = 0;

            for (int line = 0; line < 3; line++)
            {
                for (int column = 0; column < 3; column++)
                {
                    board[line, column] = 0;
                }
            }
        }

        private int verifyWin()
        {
            for (int line = 0; line < 3; line++)
            {
                if (board[line, 0] != 0 && board[line, 0] == board[line, 1] && board[line, 1] == board[line, 2])
                {
                    return board[line, 0];
                }
            }

            for (int column = 0; column < 3; column++)
            {
                if (board[0, column] != 0 && board[0, column] == board[1, column] && board[1, column] == board[2, column])
                {
                    return board[column, 0];
                }
            }

            if (board[0, 0] != 0 && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return board[0, 0];
            }

            if (board[0, 2] != 0 && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return board[0, 2];
            }

            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
