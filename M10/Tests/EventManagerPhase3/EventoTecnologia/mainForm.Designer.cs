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
            BT_AddParticipant = new Button();
            BT_RemoveParticipant = new Button();
            DGV_Participants = new DataGridView();
            BT_Exit = new Button();
            GB_Evento = new GroupBox();
            CB_EditEvent = new CheckBox();
            TB_Name = new TextBox();
            DTP_Date = new DateTimePicker();
            DUD_MaxParticipants = new DomainUpDown();
            LB_03 = new Label();
            LB_02 = new Label();
            LB_01 = new Label();
            GB_Participants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Participants).BeginInit();
            GB_Evento.SuspendLayout();
            SuspendLayout();
            // 
            // GB_Participants
            // 
            GB_Participants.Controls.Add(BT_AddParticipant);
            GB_Participants.Controls.Add(BT_RemoveParticipant);
            GB_Participants.Controls.Add(DGV_Participants);
            GB_Participants.Location = new Point(22, 133);
            GB_Participants.Name = "GB_Participants";
            GB_Participants.Size = new Size(610, 249);
            GB_Participants.TabIndex = 1;
            GB_Participants.TabStop = false;
            GB_Participants.Text = "Participants";
            // 
            // BT_AddParticipant
            // 
            BT_AddParticipant.Location = new Point(499, 139);
            BT_AddParticipant.Name = "BT_AddParticipant";
            BT_AddParticipant.Size = new Size(90, 43);
            BT_AddParticipant.TabIndex = 4;
            BT_AddParticipant.Text = "Add Participant";
            BT_AddParticipant.UseVisualStyleBackColor = true;
            BT_AddParticipant.Click += BT_AddParticipant_Click;
            // 
            // BT_RemoveParticipant
            // 
            BT_RemoveParticipant.Location = new Point(499, 188);
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
            // BT_Exit
            // 
            BT_Exit.Location = new Point(522, 403);
            BT_Exit.Name = "BT_Exit";
            BT_Exit.Size = new Size(89, 23);
            BT_Exit.TabIndex = 2;
            BT_Exit.Text = "Exit";
            BT_Exit.UseVisualStyleBackColor = true;
            BT_Exit.Click += BT_Exit_Click;
            // 
            // GB_Evento
            // 
            GB_Evento.Controls.Add(CB_EditEvent);
            GB_Evento.Controls.Add(TB_Name);
            GB_Evento.Controls.Add(DTP_Date);
            GB_Evento.Controls.Add(DUD_MaxParticipants);
            GB_Evento.Controls.Add(LB_03);
            GB_Evento.Controls.Add(LB_02);
            GB_Evento.Controls.Add(LB_01);
            GB_Evento.Location = new Point(22, 21);
            GB_Evento.Margin = new Padding(2, 1, 2, 1);
            GB_Evento.Name = "GB_Evento";
            GB_Evento.Padding = new Padding(2, 1, 2, 1);
            GB_Evento.Size = new Size(610, 94);
            GB_Evento.TabIndex = 10;
            GB_Evento.TabStop = false;
            GB_Evento.Text = "Event";
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
            // 
            // TB_Name
            // 
            TB_Name.Location = new Point(71, 22);
            TB_Name.Margin = new Padding(2, 1, 2, 1);
            TB_Name.Name = "TB_Name";
            TB_Name.Size = new Size(417, 23);
            TB_Name.TabIndex = 15;
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
            // 
            // DUD_MaxParticipants
            // 
            DUD_MaxParticipants.Location = new Point(430, 51);
            DUD_MaxParticipants.Margin = new Padding(2, 1, 2, 1);
            DUD_MaxParticipants.Name = "DUD_MaxParticipants";
            DUD_MaxParticipants.Size = new Size(55, 23);
            DUD_MaxParticipants.TabIndex = 13;
            // 
            // LB_03
            // 
            LB_03.AutoSize = true;
            LB_03.Location = new Point(247, 55);
            LB_03.Margin = new Padding(2, 0, 2, 0);
            LB_03.Name = "LB_03";
            LB_03.Size = new Size(94, 15);
            LB_03.TabIndex = 12;
            LB_03.Text = "Max Participants";
            // 
            // LB_02
            // 
            LB_02.AutoSize = true;
            LB_02.Location = new Point(18, 56);
            LB_02.Margin = new Padding(2, 0, 2, 0);
            LB_02.Name = "LB_02";
            LB_02.Size = new Size(31, 15);
            LB_02.TabIndex = 11;
            LB_02.Text = "Date";
            // 
            // LB_01
            // 
            LB_01.AutoSize = true;
            LB_01.Location = new Point(9, 25);
            LB_01.Margin = new Padding(2, 0, 2, 0);
            LB_01.Name = "LB_01";
            LB_01.Size = new Size(39, 15);
            LB_01.TabIndex = 10;
            LB_01.Text = "Name";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 443);
            Controls.Add(GB_Evento);
            Controls.Add(BT_Exit);
            Controls.Add(GB_Participants);
            Name = "mainForm";
            Text = "Gestão de Inscrições para Evento de Tecnologia";
            Load += mainForm_Load;
            GB_Participants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Participants).EndInit();
            GB_Evento.ResumeLayout(false);
            GB_Evento.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox GB_Evento;
        private CheckBox CB_EditEvent;
        private TextBox TB_Name;
        private DateTimePicker DTP_Date;
        private DomainUpDown DUD_MaxParticipants;
        private Label LB_03;
        private Label LB_02;
        private Label LB_01;
    }
}
