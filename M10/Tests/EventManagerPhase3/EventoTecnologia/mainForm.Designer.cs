namespace EventManager
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GB_Participants = new GroupBox();
            BT_EditParticipant = new Button();
            BT_Exit = new Button();
            LB_CurrentParticipantsCount = new Label();
            BT_AddParticipant = new Button();
            BT_RemoveParticipant = new Button();
            DGV_Participants = new DataGridView();
            GB_Event = new GroupBox();
            NUD_MaxParticipants = new NumericUpDown();
            CB_EditEvent = new CheckBox();
            TB_Name = new TextBox();
            DTP_Date = new DateTimePicker();
            LB_04 = new Label();
            LB_03 = new Label();
            LB_02 = new Label();
            LB_01 = new Label();
            CB_Event = new ComboBox();
            BT_CreateEvent = new Button();
            BT_DeleteEvent = new Button();
            GB_Participants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Participants).BeginInit();
            GB_Event.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_MaxParticipants).BeginInit();
            SuspendLayout();
            // 
            // GB_Participants
            // 
            GB_Participants.Controls.Add(BT_EditParticipant);
            GB_Participants.Controls.Add(BT_Exit);
            GB_Participants.Controls.Add(LB_CurrentParticipantsCount);
            GB_Participants.Controls.Add(BT_AddParticipant);
            GB_Participants.Controls.Add(BT_RemoveParticipant);
            GB_Participants.Controls.Add(DGV_Participants);
            GB_Participants.Location = new Point(20, 174);
            GB_Participants.Name = "GB_Participants";
            GB_Participants.Size = new Size(610, 249);
            GB_Participants.TabIndex = 1;
            GB_Participants.TabStop = false;
            GB_Participants.Text = "Participants";
            // 
            // BT_EditParticipant
            // 
            BT_EditParticipant.Location = new Point(500, 78);
            BT_EditParticipant.Name = "BT_EditParticipant";
            BT_EditParticipant.Size = new Size(90, 43);
            BT_EditParticipant.TabIndex = 19;
            BT_EditParticipant.Text = "Edit Participant";
            BT_EditParticipant.UseVisualStyleBackColor = true;
            BT_EditParticipant.Click += BT_EditParticipant_Click;
            // 
            // BT_Exit
            // 
            BT_Exit.Location = new Point(501, 208);
            BT_Exit.Name = "BT_Exit";
            BT_Exit.Size = new Size(89, 23);
            BT_Exit.TabIndex = 2;
            BT_Exit.Text = "Exit";
            BT_Exit.UseVisualStyleBackColor = true;
            BT_Exit.Click += BT_Exit_Click;
            // 
            // LB_CurrentParticipantsCount
            // 
            LB_CurrentParticipantsCount.AutoSize = true;
            LB_CurrentParticipantsCount.Location = new Point(322, 11);
            LB_CurrentParticipantsCount.Margin = new Padding(2, 0, 2, 0);
            LB_CurrentParticipantsCount.Name = "LB_CurrentParticipantsCount";
            LB_CurrentParticipantsCount.Size = new Size(59, 15);
            LB_CurrentParticipantsCount.TabIndex = 18;
            LB_CurrentParticipantsCount.Text = "Loading...";
            LB_CurrentParticipantsCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BT_AddParticipant
            // 
            BT_AddParticipant.Location = new Point(500, 29);
            BT_AddParticipant.Name = "BT_AddParticipant";
            BT_AddParticipant.Size = new Size(90, 43);
            BT_AddParticipant.TabIndex = 4;
            BT_AddParticipant.Text = "Add Participant";
            BT_AddParticipant.UseVisualStyleBackColor = true;
            BT_AddParticipant.Click += BT_AddParticipant_Click;
            // 
            // BT_RemoveParticipant
            // 
            BT_RemoveParticipant.Location = new Point(500, 127);
            BT_RemoveParticipant.Name = "BT_RemoveParticipant";
            BT_RemoveParticipant.Size = new Size(90, 43);
            BT_RemoveParticipant.TabIndex = 3;
            BT_RemoveParticipant.Text = "Remove Participant";
            BT_RemoveParticipant.UseVisualStyleBackColor = true;
            BT_RemoveParticipant.Click += BT_RemoveParticipant_Click;
            // 
            // DGV_Participants
            // 
            DGV_Participants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Participants.Location = new Point(22, 29);
            DGV_Participants.Name = "DGV_Participants";
            DGV_Participants.RowHeadersWidth = 82;
            DGV_Participants.Size = new Size(459, 202);
            DGV_Participants.TabIndex = 1;
            // 
            // GB_Event
            // 
            GB_Event.Controls.Add(NUD_MaxParticipants);
            GB_Event.Controls.Add(CB_EditEvent);
            GB_Event.Controls.Add(TB_Name);
            GB_Event.Controls.Add(DTP_Date);
            GB_Event.Controls.Add(LB_04);
            GB_Event.Controls.Add(LB_03);
            GB_Event.Controls.Add(LB_02);
            GB_Event.Location = new Point(20, 62);
            GB_Event.Margin = new Padding(2, 1, 2, 1);
            GB_Event.Name = "GB_Event";
            GB_Event.Padding = new Padding(2, 1, 2, 1);
            GB_Event.Size = new Size(610, 94);
            GB_Event.TabIndex = 10;
            GB_Event.TabStop = false;
            GB_Event.Text = "Event";
            // 
            // NUD_MaxParticipants
            // 
            NUD_MaxParticipants.Location = new Point(421, 52);
            NUD_MaxParticipants.Name = "NUD_MaxParticipants";
            NUD_MaxParticipants.Size = new Size(60, 23);
            NUD_MaxParticipants.TabIndex = 17;
            NUD_MaxParticipants.ValueChanged += NUD_MaxParticipants_ValueChanged;
            // 
            // CB_EditEvent
            // 
            CB_EditEvent.AutoSize = true;
            CB_EditEvent.Location = new Point(500, 26);
            CB_EditEvent.Name = "CB_EditEvent";
            CB_EditEvent.Size = new Size(78, 19);
            CB_EditEvent.TabIndex = 16;
            CB_EditEvent.Text = "Edit Event";
            CB_EditEvent.UseVisualStyleBackColor = true;
            CB_EditEvent.CheckedChanged += CB_EditEvent_CheckedChanged;
            // 
            // TB_Name
            // 
            TB_Name.Location = new Point(68, 22);
            TB_Name.Margin = new Padding(2, 1, 2, 1);
            TB_Name.Name = "TB_Name";
            TB_Name.Size = new Size(413, 23);
            TB_Name.TabIndex = 15;
            TB_Name.TextChanged += TB_Name_TextChanged;
            // 
            // DTP_Date
            // 
            DTP_Date.Format = DateTimePickerFormat.Short;
            DTP_Date.Location = new Point(68, 52);
            DTP_Date.Margin = new Padding(2, 1, 2, 1);
            DTP_Date.Name = "DTP_Date";
            DTP_Date.Size = new Size(116, 23);
            DTP_Date.TabIndex = 14;
            DTP_Date.Value = new DateTime(2024, 12, 15, 0, 0, 0, 0);
            DTP_Date.ValueChanged += DTP_Date_ValueChanged;
            // 
            // LB_04
            // 
            LB_04.AutoSize = true;
            LB_04.Location = new Point(322, 56);
            LB_04.Margin = new Padding(2, 0, 2, 0);
            LB_04.Name = "LB_04";
            LB_04.Size = new Size(94, 15);
            LB_04.TabIndex = 12;
            LB_04.Text = "Max Participants";
            // 
            // LB_03
            // 
            LB_03.AutoSize = true;
            LB_03.Location = new Point(18, 56);
            LB_03.Margin = new Padding(2, 0, 2, 0);
            LB_03.Name = "LB_03";
            LB_03.Size = new Size(31, 15);
            LB_03.TabIndex = 11;
            LB_03.Text = "Date";
            // 
            // LB_02
            // 
            LB_02.AutoSize = true;
            LB_02.Location = new Point(9, 25);
            LB_02.Margin = new Padding(2, 0, 2, 0);
            LB_02.Name = "LB_02";
            LB_02.Size = new Size(39, 15);
            LB_02.TabIndex = 10;
            LB_02.Text = "Name";
            // 
            // LB_01
            // 
            LB_01.AutoSize = true;
            LB_01.Location = new Point(26, 27);
            LB_01.Margin = new Padding(2, 0, 2, 0);
            LB_01.Name = "LB_01";
            LB_01.Size = new Size(36, 15);
            LB_01.TabIndex = 18;
            LB_01.Text = "Event";
            // 
            // CB_Event
            // 
            CB_Event.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Event.FormattingEnabled = true;
            CB_Event.Location = new Point(88, 25);
            CB_Event.Name = "CB_Event";
            CB_Event.Size = new Size(413, 23);
            CB_Event.TabIndex = 19;
            CB_Event.SelectedIndexChanged += CB_Event_SelectedIndexChanged;
            // 
            // BT_CreateEvent
            // 
            BT_CreateEvent.Location = new Point(521, 25);
            BT_CreateEvent.Name = "BT_CreateEvent";
            BT_CreateEvent.Size = new Size(42, 23);
            BT_CreateEvent.TabIndex = 20;
            BT_CreateEvent.Text = "New";
            BT_CreateEvent.UseVisualStyleBackColor = true;
            BT_CreateEvent.Click += BT_CreateEvent_Click;
            // 
            // BT_DeleteEvent
            // 
            BT_DeleteEvent.Location = new Point(568, 25);
            BT_DeleteEvent.Name = "BT_DeleteEvent";
            BT_DeleteEvent.Size = new Size(42, 23);
            BT_DeleteEvent.TabIndex = 21;
            BT_DeleteEvent.Text = "Del";
            BT_DeleteEvent.UseVisualStyleBackColor = true;
            BT_DeleteEvent.Click += BT_DeleteEvent_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 443);
            Controls.Add(BT_DeleteEvent);
            Controls.Add(BT_CreateEvent);
            Controls.Add(CB_Event);
            Controls.Add(LB_01);
            Controls.Add(GB_Event);
            Controls.Add(GB_Participants);
            MaximizeBox = false;
            Name = "mainForm";
            ShowIcon = false;
            Text = "Event Manager";
            Load += mainForm_Load;
            GB_Participants.ResumeLayout(false);
            GB_Participants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Participants).EndInit();
            GB_Event.ResumeLayout(false);
            GB_Event.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_MaxParticipants).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GB_Participants;
        private DataGridView DGV_Participants;
        private Button BT_Exit;
        private Button btnListParticipantes;
        private Button btnAddParticipante;
        private Button BT_RemoveParticipant;
        private Button btnAddEvento;
        private Button BT_AddParticipant;
        private GroupBox GB_Event;
        private CheckBox CB_EditEvent;
        private TextBox TB_Name;
        private DateTimePicker DTP_Date;
        private Label LB_04;
        private Label LB_03;
        private Label LB_02;
        private NumericUpDown NUD_MaxParticipants;
        private Label LB_CurrentParticipantsCount;
        private Button BT_EditParticipant;
        private Label LB_01;
        private ComboBox CB_Event;
        private Button BT_CreateEvent;
        private Button BT_DeleteEvent;
    }
}
