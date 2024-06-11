using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_Radio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_CLEAN_Click(object sender, EventArgs e)
        {
            TB_NAME.Text = "";

            RB_ACTIVE.Checked = true;

            CB_CLIENT.Checked = false;
            CB_MANAGER.Checked = false;
            CB_ADMINISTRATOR.Checked = false;

            LB_MESSAGE.Text = "";
        }

        private void BT_VALIDATE_Click(object sender, EventArgs e)
        {
            // Validations

            if (TB_NAME.Text == "")
            {
                MessageBox.Show("Campo do nome por preencher!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (RB_ACTIVE.Checked == false && RB_BLOCKED.Checked == false)
            {
                MessageBox.Show("Estado do utilizador por preencher!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CB_CLIENT.Checked == false && CB_MANAGER.Checked == false && CB_ADMINISTRATOR.Checked == false)
            {
                MessageBox.Show("Perfil do utilizador por preencher!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // End of validations

            string ageStatus = NUD_AGE.Value > 66 ? "reformado" : "maior de idade";

            string accountStatus = RB_BLOCKED.Checked == true ? "bloqueada" : "ativa";

            string profile = "";

            if (CB_CLIENT.Checked == true)
            {
                profile = profile + CB_CLIENT.Text + " ";
            }

            if (CB_MANAGER.Checked == true)
            {
                profile = profile + CB_MANAGER.Text + " ";
            }

            if (CB_ADMINISTRATOR.Checked == true)
            {
                profile = profile + CB_ADMINISTRATOR.Text;
            }

            LB_MESSAGE.Text = $"Olá {TB_NAME.Text} és {ageStatus}.\nA tua conta está {accountStatus}\nE és um {profile}";
        }
    }
}
