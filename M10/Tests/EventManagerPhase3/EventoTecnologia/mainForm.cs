using System.ComponentModel;
using System.Diagnostics;

namespace EventManager
{
    public partial class mainForm : Form
    {
        public Event currentEvent { get; private set; }

        public mainForm()
        {
            InitializeComponent();
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            CB_Event.DataSource = Data.Events;
            CB_Event.DisplayMember = "Name";
            CB_Event.SelectedItem = Data.currentEvent;

            DGV_Participants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Participants.MultiSelect = false;
            DGV_Participants.RowHeadersVisible = false;
            DGV_Participants.ReadOnly = true;
            DGV_Participants.AllowUserToAddRows = false;
            DGV_Participants.AllowUserToDeleteRows = false;
            DGV_Participants.AllowUserToResizeRows = false;
            DGV_Participants.AllowUserToResizeColumns = false;
            DGV_Participants.AllowUserToOrderColumns = true;

            updateEventDetails();

            DGV_Participants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Participants.Columns["Name"].DefaultCellStyle.BackColor = Color.LightYellow;
            DGV_Participants.Columns["Email"].HeaderText = "E-Mail";

            KeyPreview = true;

            TB_Name.Enabled = false;
            DTP_Date.Enabled = false;
            NUD_MaxParticipants.Enabled = false;

            NUD_MaxParticipants.Minimum = Data.currentEvent.ParticipantsList.Count;
        }

        private void updateEventDetails()
        {
            TB_Name.Text = Data.currentEvent.Name;
            DTP_Date.Value = Data.currentEvent.Date.Date;
            NUD_MaxParticipants.Value = Data.currentEvent.MaxCapacity;

            DGV_Participants.DataSource = new BindingList<Participant>(Data.currentEvent.ParticipantsList);

            LB_CurrentParticipantsCount.Text = $"Number of participants {Data.currentEvent.ParticipantsList.Count}";
        }

        private void BT_AddParticipant_Click(object sender, EventArgs e)
        {
            if (NUD_MaxParticipants.Value > Data.currentEvent.ParticipantsList.Count)
            {
                addParticipant addParticipantForm = new addParticipant();
                var addParticipantDialog = addParticipantForm.ShowDialog();

                if (addParticipantDialog == DialogResult.OK)
                {
                    DGV_Participants.DataSource = new BindingList<Participant>(Data.currentEvent.ParticipantsList);
                }
            }
            else
            {
                MessageBox.Show("Max number of participants reached.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT_RemoveParticipant_Click(object sender, EventArgs e)
        {
            if (DGV_Participants.SelectedRows.Count > 0)
            {
                int selectedIndex = DGV_Participants.SelectedRows[0].Index;

                Data.currentEvent.ParticipantsList.RemoveAt(selectedIndex);
                DGV_Participants.DataSource = new BindingList<Participant>(Data.currentEvent.ParticipantsList);

                NUD_MaxParticipants.Minimum = Data.currentEvent.ParticipantsList.Count;
            }
            else
            {
                MessageBox.Show("No participant selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CB_EditEvent_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_EditEvent.Checked == true)
            {
                TB_Name.Enabled = true;
                DTP_Date.Enabled = true;
                NUD_MaxParticipants.Enabled = true;
            }
            else if (CB_EditEvent.Checked == false)
            {
                TB_Name.Enabled = false;
                DTP_Date.Enabled = false;
                NUD_MaxParticipants.Enabled = false;
            }
        }

        private void TB_Name_TextChanged(object sender, EventArgs e)
        {
            if (CB_Event.SelectedItem is Event selectedEvent && selectedEvent.Name != TB_Name.Text)
            {
                selectedEvent.Name = TB_Name.Text;

                int selectedIndex = CB_Event.SelectedIndex;
                CB_Event.DataSource = null;
                CB_Event.DataSource = Data.Events;
                CB_Event.DisplayMember = "Name";
                CB_Event.SelectedIndex = selectedIndex;
            }
        }

        private void DTP_Date_ValueChanged(object sender, EventArgs e)
        {
            Data.currentEvent.Date = DTP_Date.Value;
        }

        private void NUD_MaxParticipants_ValueChanged(object sender, EventArgs e)
        {
            Data.currentEvent.MaxCapacity = (int)NUD_MaxParticipants.Value;
        }

        private void BT_EditParticipant_Click(object sender, EventArgs e)
        {
            if (DGV_Participants.SelectedRows.Count > 0)
            {
                int selectedIndex = DGV_Participants.SelectedRows[0].Index;
                Participant selectedParticipant = Data.currentEvent.ParticipantsList[selectedIndex];

                editParticipant editParticipantForm = new editParticipant(selectedParticipant);
                var editParticipantDialog = editParticipantForm.ShowDialog();

                if (editParticipantDialog == DialogResult.OK)
                {
                    DGV_Participants.DataSource = new BindingList<Participant>(Data.currentEvent.ParticipantsList);
                }
            }
            else
            {
                MessageBox.Show("No participant selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CB_Event_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Event.SelectedItem is Event selectedEvent)
            {
                Data.currentEvent = selectedEvent;
                currentEvent = selectedEvent;
                updateEventDetails();
            }
        }

        private void BT_CreateEvent_Click(object sender, EventArgs e)
        {
            createEvent createEventForm = new createEvent();

            if (createEventForm.ShowDialog() == DialogResult.OK)
            {
                Data.AddEvent(createEventForm.newEvent);

                CB_Event.DataSource = null;
                CB_Event.DataSource = Data.Events;
                CB_Event.DisplayMember = "Name";
                CB_Event.SelectedItem = createEventForm.newEvent;
            }
        }

        private void BT_DeleteEvent_Click(object sender, EventArgs e)
        {
            if (Data.Events.Count <= 1)
            {
                MessageBox.Show("Cannot delete the last event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CB_Event.SelectedItem is Event selectedEvent)
            {
                Data.RemoveEvent(selectedEvent);

                CB_Event.DataSource = null;
                CB_Event.DataSource = Data.Events;
                CB_Event.DisplayMember = "Name";

                if (Data.Events.Count > 0)
                    CB_Event.SelectedItem = Data.Events[0];

                updateEventDetails();
            }
        }
    }
}
