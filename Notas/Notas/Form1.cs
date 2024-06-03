using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LB_RESULT.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Convet to intagers and Calculate
            int P1, P2, P3;
            float N1, N2, N3;

            try
            {
                P1 = int.Parse(TB_P1.Text);
                P2 = int.Parse(TB_P2.Text);
                P3 = int.Parse(TB_P3.Text);

                N1 = float.Parse(TB_N1.Text);
                N2 = float.Parse(TB_N2.Text);
                N3 = float.Parse(TB_N3.Text);

                // Calculate
                float D1 = (P1 * N1) / 100;
                float D2 = (P2 * N2) / 100;
                float D3 = (P3 * N3) / 100;

                LB_RESULT.Text = (D1 + D2 + D3).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
