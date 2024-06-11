using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_ADD_Click(object sender, EventArgs e)
        {
            decimal total = decimal.Parse(LB_TOTAL.Text);

            string productName = TB_ITEM_NAME.Text;
            decimal productPrice = NUD_PRICE.Value;
            decimal productQuantity = NUD_QUANTITY.Value;

            if (productName == "")
            {
                MessageBox.Show("Nome do produto por preencher!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GroceryList.Items.Add(productName + " | " + productPrice + "€" + " | " + productQuantity);

            total += productPrice;
            LB_TOTAL.Text = total.ToString();

            // Reset to default
            TB_ITEM_NAME.Text = "";
            NUD_PRICE.Value = 0;
            NUD_QUANTITY.Value = 1;
        }

        private void BT_REMOVE_Click(object sender, EventArgs e)
        {
            GroceryList.Items.Clear();

            LB_TOTAL.Text = 0.ToString();
        }
    }
}
