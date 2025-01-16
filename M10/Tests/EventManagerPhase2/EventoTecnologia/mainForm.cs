namespace EventoTecnologia
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        
        private void mainForm_Load(object sender, EventArgs e)
        {
            // Add participants
            
            Event currentEvent = new Event("TestEvent", DateTime.Now, 20);
            
            Participant participant1 = new Participant("John Doe", 20, "john.doe@mail.com");
            Participant participant2 = new Participant("Jane Doe", 20, "jane.doe@mail.com");
            
            currentEvent.addParticipant(participant1);
            currentEvent.addParticipant(participant2);
            
            // Event Name Setup

            TB_EventName.Text = currentEvent.Name;
            
            // Event Date Setup
            
            DTP_EventDate.Value = currentEvent.Date;
            
            // Event MaxCapacity setup

            NUD_MaxParticipants.Value = currentEvent.MaxCapacity;
            
            // Data Grid View Setup

            DGV_Participants.DataSource = currentEvent.participants;
            DGV_Participants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Participants.MultiSelect = false;
            DGV_Participants.RowHeadersVisible = false;
            
            DGV_Participants.Columns["Name"].HeaderText = "Nome";
            DGV_Participants.Columns["Name"].Width = 250;
            
            DGV_Participants.Columns["Age"].HeaderText = "Idade";
            DGV_Participants.Columns["Age"].Width = 200;
            
            DGV_Participants.Columns["Email"].HeaderText = "Email";
            DGV_Participants.Columns["Email"].Width = 250;
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
