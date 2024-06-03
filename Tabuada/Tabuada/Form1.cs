using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Calculate
        private void BT_Calcular_Click(object sender, EventArgs e)
        {
            CleanListBox();

            int number = int.Parse(TB_N.Text);

            for (int i = 1; i <= 10; i++)
            {
                string line = i + " X " + number + " = " + i * number;

                ListBox_Tabuada.Items.Add(line);
            }
        }

        // Clean
        private void BT_Limpar_Click(object sender, EventArgs e)
        {
            CleanListBox();
        }

        // Function to clean listbox
        private void CleanListBox()
        {
            ListBox_Tabuada.Items.Clear();
        }

        private void TB_N_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true; // cancel event if not a number
            }
        }
    }
}
