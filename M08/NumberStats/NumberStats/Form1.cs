using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberStats
{
    public partial class Form1 : Form
    {
        int sum = 0;
        int count = 0;
        int largest = 0;
        int smallest = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void BT_Check_Click(object sender, EventArgs e)
        {
            try
            {
                // MEDIAN
                
                int userInput = int.Parse(TB_UserInput.Text);

                sum += userInput;
                count++;

                float median = (float)sum / count;

                LB_Median.Text = median.ToString();

                // Largest and Smallest

                if (count == 1)
                {
                    largest = smallest = userInput;
                }
                else
                {
                    if (userInput > largest)
                        largest = userInput;
                    if (userInput < smallest)
                        smallest = userInput;
                }

                LB_Biggest.Text = largest.ToString();
                LB_Smallest.Text = smallest.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ocurreu um erro: {err.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            DateTime now = DateTime.Now;
            LB_TIME.Text = now.ToString("HH:mm:ss");
        }

        private void Every1Sec_Tick_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = !pictureBox1.Visible;
        }
    }
}