using System.ComponentModel;
using System.Diagnostics;

namespace EventManager
{
    public partial class mainForm : Form
    {
        public Event EventTech { get; private set; }

        public mainForm()
        {
            InitializeComponent();
            EventTech = Data.CurrentEvent;
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            DGV_Participants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Participants.MultiSelect = false;
            DGV_Participants.RowHeadersVisible = false;
            DGV_Participants.ReadOnly = true;
            DGV_Participants.AllowUserToAddRows = false;
            DGV_Participants.AllowUserToDeleteRows = false;
            DGV_Participants.AllowUserToResizeRows = false;
            DGV_Participants.AllowUserToResizeColumns = false;
            DGV_Participants.AllowUserToOrderColumns = true;

            ShowDataForm();

            DGV_Participants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Participants.Columns["Name"].DefaultCellStyle.BackColor = Color.LightYellow;
            DGV_Participants.Columns["Email"].HeaderText = "E-Mail";

            KeyPreview = true;
        }

        private void ShowDataForm()
        {
            TB_Name.Text = EventTech.Name;
            DTP_Date.Value = EventTech.Date.Date;
            DUD_MaxParticipants.Text = EventTech.MaxCapacity.ToString();

            DGV_Participants.DataSource = new BindingList<Participant>(EventTech.ParticipantsList);
        }

        private void BT_AddParticipant_Click(object sender, EventArgs e)
        {
            addParticipant addParticipantForm = new addParticipant();
            var addParticipantDialog = addParticipantForm.ShowDialog();

            if (addParticipantDialog == DialogResult.OK)
            {
                DGV_Participants.DataSource = new BindingList<Participant>(EventTech.ParticipantsList);
            }
        }

        private void BT_RemoveParticipant_Click(object sender, EventArgs e)
        {
            if (DGV_Participants.SelectedRows.Count > 0)
            {
                int selectedIndex = DGV_Participants.SelectedRows[0].Index;

                EventTech.ParticipantsList.RemoveAt(selectedIndex);
                DGV_Participants.DataSource = new BindingList<Participant>(EventTech.ParticipantsList);
            }
            else
            {
                MessageBox.Show("Error", "No participant selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
