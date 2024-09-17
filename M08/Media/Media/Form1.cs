using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set result text to empty
            LB_MEDIAN.Text = "";
        }

        private void BT_CALCULATE_Click(object sender, EventArgs e)
        {
            // Convert data to string
            int value1 = int.Parse(TB_N1.Text);
            int value2 = int.Parse(TB_N2.Text);
            int value3 = int.Parse(TB_N3.Text);

            // Calculate median
            float total = (value1 + value2 + value3) / 3;

            // Set result text to the result
            LB_MEDIAN.Text = total.ToString();

            // Display message if negative or positive
            if (total >= 0)
            {
                MessageBox.Show("A média é positiva", "Média");
            }

            else
            {
                MessageBox.Show("A média é negativa", "Média");
            }
        }
    }
}
