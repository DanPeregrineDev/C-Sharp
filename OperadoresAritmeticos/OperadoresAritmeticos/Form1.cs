﻿using System;
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
        }

        private void BT_Calculate_Click(object sender, EventArgs e)
        {
            string option = CB_Operadores.Text;
            int n1 = int.Parse(TB_N1.Text);
            int n2 = int.Parse(TB_N2.Text);

            int result = 0;
            
            switch(option)
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
    }
}
