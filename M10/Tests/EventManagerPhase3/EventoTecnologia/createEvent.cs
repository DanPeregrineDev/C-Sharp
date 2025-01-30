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
    public partial class createEvent : Form
    {
        public Event newEvent { get; private set; }

        public createEvent()
        {
            InitializeComponent();
        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_CreateEvent_Click(object sender, EventArgs e)
        {
            if (TB_Name.Text.Length == 0)
            {
                MessageBox.Show("Event name invalid", Data.appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (NUD_MaxParticipants.Value == 0)
            {
                MessageBox.Show("Event capacity must be at least 1 person", Data.appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                 newEvent = new Event(TB_Name.Text, DTP_Date.Value, (int)NUD_MaxParticipants.Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
