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
    public partial class addParticipant : Form
    {
        public addParticipant()
        {
            InitializeComponent();
        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_Add_Click(object sender, EventArgs e)
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
                Participant newParticipant = new Participant(TB_Name.Text, (int)NUD_Age.Value, TB_Email.Text);
                Data.currentEvent.AddParticipant(newParticipant);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
