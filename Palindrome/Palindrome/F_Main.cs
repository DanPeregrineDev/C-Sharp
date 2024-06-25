using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palindrome
{
    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();

            F_Splash splash = new F_Splash();
            splash.ShowDialog();
        }

        private void BT_Check_Click(object sender, EventArgs e)
        {
            string word = TB_Text.Text;

            for (int i = 0; i< word.Length / 2; i++)
            {
                char firstChar = word[i];
                char secondChar = word[word.Length - 1 - i];

                if ( firstChar != secondChar )
                {
                    LB_Check.Text = "No";
                    return;
                }
            }

            LB_Check.Text = "Yes";
        }
    }
}
