using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind
{
    public partial class Form1 : Form
    {
        int[] code;
        
        public Form1()
        {
            InitializeComponent();

            code = GenerateCode();

            LB_RANDOM.Text = "****";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open about form
            F_ABOUT formAbout = new F_ABOUT();
            formAbout.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int[] GenerateCode()
        {
            Random randomN = new Random();

            int[] code = new int[4];

            for (int i = 0; i < code.Length; i++)
            {
                code[i] = randomN.Next(0, 10);
            }

            return code;
        }

        private void BT_GUESS_Click(object sender, EventArgs e)
        {
            string userGuess = TB_GUESS.Text;
            string feedback = "";

            for (int i = 0; i < 4; i++)
            {
                feedback += tryGuess(userGuess, 0);
            }

            LB_TRIES.Items.Add(userGuess + " - " + feedback);

            if (feedback == "CCCC")
            {
                DialogResult reply = MessageBox.Show("Congratulations! you guessed the code correctly.\n Do you want to play again?", "Congratulations", MessageBoxButtons.YesNo);

                if (reply == DialogResult.Yes)
                {
                    LB_TRIES.Items.Clear();
                    code = GenerateCode();
                    TB_GUESS.Clear();
                    TB_GUESS.Focus();
                }
            }
        }

        string tryGuess(string userGuess, int position)
        {
            if (code[position].ToString() == userGuess[position].ToString())
            {
                return "C"; // Correct
            }

            for (int i = 0; i < code.Length; i++)
            {
                if (code[i].ToString() == userGuess[position].ToString())
                {
                    return "E"; // Exists
                }
            }

            return "X"; // Does't exist
        }
    }
}
