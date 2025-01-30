namespace EventManager
{
    partial class createEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BT_CreateEvent = new Button();
            BT_Cancel = new Button();
            GB_Evento = new GroupBox();
            NUD_MaxParticipants = new NumericUpDown();
            DTP_Date = new DateTimePicker();
            LB_02 = new Label();
            TB_Name = new TextBox();
            LB_03 = new Label();
            LB_01 = new Label();
            GB_Evento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_MaxParticipants).BeginInit();
            SuspendLayout();
            // 
            // BT_CreateEvent
            // 
            BT_CreateEvent.Location = new Point(400, 170);
            BT_CreateEvent.Name = "BT_CreateEvent";
            BT_CreateEvent.Size = new Size(100, 25);
            BT_CreateEvent.TabIndex = 17;
            BT_CreateEvent.Text = "Create";
            BT_CreateEvent.UseVisualStyleBackColor = true;
            BT_CreateEvent.Click += BT_CreateEvent_Click;
            // 
            // BT_Cancel
            // 
            BT_Cancel.Location = new Point(21, 170);
            BT_Cancel.Name = "BT_Cancel";
            BT_Cancel.Size = new Size(100, 25);
            BT_Cancel.TabIndex = 16;
            BT_Cancel.Text = "Cancel";
            BT_Cancel.UseVisualStyleBackColor = true;
            BT_Cancel.Click += BT_Cancel_Click;
            // 
            // GB_Evento
            // 
            GB_Evento.Controls.Add(NUD_MaxParticipants);
            GB_Evento.Controls.Add(DTP_Date);
            GB_Evento.Controls.Add(LB_02);
            GB_Evento.Controls.Add(TB_Name);
            GB_Evento.Controls.Add(LB_03);
            GB_Evento.Controls.Add(LB_01);
            GB_Evento.Location = new Point(12, 15);
            GB_Evento.Margin = new Padding(2, 1, 2, 1);
            GB_Evento.Name = "GB_Evento";
            GB_Evento.Padding = new Padding(2, 1, 2, 1);
            GB_Evento.Size = new Size(500, 135);
            GB_Evento.TabIndex = 15;
            GB_Evento.TabStop = false;
            // 
            // NUD_MaxParticipants
            // 
            NUD_MaxParticipants.Location = new Point(122, 97);
            NUD_MaxParticipants.Name = "NUD_MaxParticipants";
            NUD_MaxParticipants.Size = new Size(188, 23);
            NUD_MaxParticipants.TabIndex = 19;
            // 
            // DTP_Date
            // 
            DTP_Date.Location = new Point(71, 58);
            DTP_Date.Name = "DTP_Date";
            DTP_Date.Size = new Size(239, 23);
            DTP_Date.TabIndex = 18;
            // 
            // LB_02
            // 
            LB_02.AutoSize = true;
            LB_02.Location = new Point(8, 62);
            LB_02.Margin = new Padding(2, 0, 2, 0);
            LB_02.Name = "LB_02";
            LB_02.Size = new Size(31, 15);
            LB_02.TabIndex = 17;
            LB_02.Text = "Date";
            // 
            // TB_Name
            // 
            TB_Name.Location = new Point(71, 22);
            TB_Name.Margin = new Padding(2, 1, 2, 1);
            TB_Name.Name = "TB_Name";
            TB_Name.Size = new Size(417, 23);
            TB_Name.TabIndex = 15;
            // 
            // LB_03
            // 
            LB_03.AutoSize = true;
            LB_03.Location = new Point(8, 99);
            LB_03.Margin = new Padding(2, 0, 2, 0);
            LB_03.Name = "LB_03";
            LB_03.Size = new Size(94, 15);
            LB_03.TabIndex = 11;
            LB_03.Text = "Max Participants";
            // 
            // LB_01
            // 
            LB_01.AutoSize = true;
            LB_01.Location = new Point(8, 25);
            LB_01.Margin = new Padding(2, 0, 2, 0);
            LB_01.Name = "LB_01";
            LB_01.Size = new Size(39, 15);
            LB_01.TabIndex = 10;
            LB_01.Text = "Name";
            // 
            // createEvent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 211);
            Controls.Add(BT_CreateEvent);
            Controls.Add(BT_Cancel);
            Controls.Add(GB_Evento);
            MaximizeBox = false;
            Name = "createEvent";
            ShowIcon = false;
            Text = "Create Event";
            GB_Evento.ResumeLayout(false);
            GB_Evento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_MaxParticipants).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BT_CreateEvent;
        private Button BT_Cancel;
        private GroupBox GB_Evento;
        private Label LB_02;
        private TextBox TB_Name;
        private Label LB_03;
        private Label LB_01;
        private NumericUpDown NUD_MaxParticipants;
        private DateTimePicker DTP_Date;
    }
}