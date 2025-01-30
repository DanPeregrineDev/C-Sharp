using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManager
{
    public partial class editParticipant : Form
    {
        private Participant participant;

        public editParticipant(Participant participant)
        {
            InitializeComponent();
            this.participant = participant;
        }

        private void editParticipant_Load(object sender, EventArgs e)
        {
            TB_Name.Text = participant.Name;
            TB_Email.Text = participant.Email;
            NUD_Age.Value = participant.Age;
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            if (TB_Name.Text.Length == 0)
            {
                MessageBox.Show("Invalid Name", Data.appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TB_Email.Text.Length == 0)
            {
                MessageBox.Show("Invalid Email", Data.appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (NUD_Age.Value < 16)
            {
                MessageBox.Show("Invalid age, cannot be under 16", Data.appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                participant.Name = TB_Name.Text;
                participant.Email = TB_Email.Text;
                participant.Age = (int)NUD_Age.Value;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
