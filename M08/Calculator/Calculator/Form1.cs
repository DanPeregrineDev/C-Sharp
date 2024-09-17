using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int earlierNum = 0;         // Stores the result with earlier number
        string operation = "";      // Stores the operation to make
        bool clean = false;         // Stores if it is necessary to clean TB_DISPLAY

        public Form1()
        {
            InitializeComponent();
        }

        private void BT_Num_Click(object sender, EventArgs e)
        {
            if (clean == true)
            {
                TB_Display.Clear();
            }

            clean = false;

            Button button = (Button)sender;
            TB_Display.Text += button.Text;
        }

        private void BT_ClearEntry_Click(object sender, EventArgs e)
        {
            TB_Display.Clear();

            operation = "";
            earlierNum = 0;
        }

        private void BT_Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            clean = true;

            //Check if there is a earlier operation
            if (operation == "")
            {
                // Doesn't exist
                earlierNum = int.Parse(TB_Display.Text);
                operation = button.Text;
            }
            else
            {
                int current = int.Parse(TB_Display.Text);
                int result = 0;

                switch (operation)
                {
                    case "+":
                        result = earlierNum + current;
                        break;

                    case "-":
                        result = earlierNum - current;
                        break;

                    case "x":
                        result = earlierNum * current;
                        break;

                    case "÷": 
                        result = earlierNum / current;
                        break; 
                }

                TB_Display.Text = result.ToString();

                if (button.Text == "=")
                {
                    earlierNum = 0;
                    operation = "";
                }
                else
                {
                    earlierNum = result;
                    operation = button.Text;
                }
            }
        }
    }
}
