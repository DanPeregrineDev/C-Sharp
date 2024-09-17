using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adicionar_nomes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_Adicionar_Click(object sender, EventArgs e)
        {
            string Name = TB_Nome.Text;

            if (Name != "" && CB_Nomes.Items.Contains(Name) == false)
                CB_Nomes.Items.Add(Name);
        }

        private void BT_Remover_Click(object sender, EventArgs e)
        {
            if (CB_Nomes.SelectedIndex != -1)
            {
                DialogResult Response = MessageBox.Show("Tem a certeza que deseja apagar este elemento?", "Tem a certeza", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (Response == DialogResult.Yes)
                {
                    CB_Nomes.Items.RemoveAt(CB_Nomes.SelectedIndex);
                }
            }
        }
    }
}
