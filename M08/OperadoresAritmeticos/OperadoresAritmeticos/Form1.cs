using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperadoresAritmeticos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CB_Operadores.SelectedIndex = 0;
        }

        private void BT_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                string option = CB_Operadores.Text;
                int n1 = int.Parse(TB_N1.Text);
                int n2 = int.Parse(TB_N2.Text);

                int result = 0;

                switch (option)
                {
                    case "+":
                        result = n1 + n2;
                        break;

                    case "-":
                        result = n1 - n2;
                        break;

                    case "*":
                        result = n1 * n2;
                        break;

                    case "/":
                        result = n1 / n2;
                        break;

                    default:
                        MessageBox.Show("Nenhum operador selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                TB_Result.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurreu um erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Response = MessageBox.Show("Tem a certeza que quer fechar o programa?", "Tem a certeza", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Response == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
