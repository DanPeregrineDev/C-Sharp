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
            Participant newParticipant = new Participant(TB_Name.Text, (int)NUD_Age.Value, TB_Email.Text);
            Data.CurrentEvent.AddParticipant(newParticipant);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
