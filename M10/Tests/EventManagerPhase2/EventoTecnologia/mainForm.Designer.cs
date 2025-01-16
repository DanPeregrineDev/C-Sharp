namespace EventoTecnologia
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GB_Participants = new System.Windows.Forms.GroupBox();
            BT_AddParticipant = new System.Windows.Forms.Button();
            BT_RemoveParticipant = new System.Windows.Forms.Button();
            DGV_Participants = new System.Windows.Forms.DataGridView();
            BT_Exit = new System.Windows.Forms.Button();
            TB_EventName = new System.Windows.Forms.TextBox();
            LB_01 = new System.Windows.Forms.Label();
            LB_02 = new System.Windows.Forms.Label();
            DTP_EventDate = new System.Windows.Forms.DateTimePicker();
            NUD_MaxParticipants = new System.Windows.Forms.NumericUpDown();
            LB_03 = new System.Windows.Forms.Label();
            CB_EditEvent = new System.Windows.Forms.CheckBox();
            GB_Participants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Participants).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_MaxParticipants).BeginInit();
            SuspendLayout();
            // 
            // GB_Participants
            // 
            GB_Participants.Controls.Add(BT_AddParticipant);
            GB_Participants.Controls.Add(BT_RemoveParticipant);
            GB_Participants.Controls.Add(DGV_Participants);
            GB_Participants.Location = new System.Drawing.Point(12, 120);
            GB_Participants.Name = "GB_Participants";
            GB_Participants.Size = new System.Drawing.Size(860, 300);
            GB_Participants.TabIndex = 0;
            GB_Participants.TabStop = false;
            GB_Participants.Text = "Participantes";
            // 
            // BT_AddParticipant
            // 
            BT_AddParticipant.Location = new System.Drawing.Point(712, 188);
            BT_AddParticipant.Name = "BT_AddParticipant";
            BT_AddParticipant.Size = new System.Drawing.Size(142, 50);
            BT_AddParticipant.TabIndex = 2;
            BT_AddParticipant.Text = "Inscrever Participante";
            BT_AddParticipant.UseVisualStyleBackColor = true;
            // 
            // BT_RemoveParticipant
            // 
            BT_RemoveParticipant.Location = new System.Drawing.Point(712, 244);
            BT_RemoveParticipant.Name = "BT_RemoveParticipant";
            BT_RemoveParticipant.Size = new System.Drawing.Size(142, 50);
            BT_RemoveParticipant.TabIndex = 1;
            BT_RemoveParticipant.Text = "Remover Inscrição";
            BT_RemoveParticipant.UseVisualStyleBackColor = true;
            // 
            // DGV_Participants
            // 
            DGV_Participants.AllowUserToAddRows = false;
            DGV_Participants.AllowUserToDeleteRows = false;
            DGV_Participants.AllowUserToResizeColumns = false;
            DGV_Participants.AllowUserToResizeRows = false;
            DGV_Participants.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            DGV_Participants.Location = new System.Drawing.Point(6, 22);
            DGV_Participants.Name = "DGV_Participants";
            DGV_Participants.ReadOnly = true;
            DGV_Participants.ScrollBars = System.Windows.Forms.ScrollBars.None;
            DGV_Participants.Size = new System.Drawing.Size(700, 272);
            DGV_Participants.TabIndex = 0;
            // 
            // BT_Exit
            // 
            BT_Exit.Location = new System.Drawing.Point(724, 436);
            BT_Exit.Name = "BT_Exit";
            BT_Exit.Size = new System.Drawing.Size(142, 25);
            BT_Exit.TabIndex = 3;
            BT_Exit.Text = "Sair";
            BT_Exit.UseVisualStyleBackColor = true;
            BT_Exit.Click += BT_Exit_Click;
            // 
            // TB_EventName
            // 
            TB_EventName.Location = new System.Drawing.Point(74, 22);
            TB_EventName.Name = "TB_EventName";
            TB_EventName.Size = new System.Drawing.Size(644, 23);
            TB_EventName.TabIndex = 4;
            // 
            // LB_01
            // 
            LB_01.Location = new System.Drawing.Point(18, 25);
            LB_01.Name = "LB_01";
            LB_01.Size = new System.Drawing.Size(50, 23);
            LB_01.TabIndex = 5;
            LB_01.Text = "Nome";
            // 
            // LB_02
            // 
            LB_02.Location = new System.Drawing.Point(18, 75);
            LB_02.Name = "LB_02";
            LB_02.Size = new System.Drawing.Size(50, 23);
            LB_02.TabIndex = 6;
            LB_02.Text = "Data";
            // 
            // DTP_EventDate
            // 
            DTP_EventDate.Location = new System.Drawing.Point(74, 69);
            DTP_EventDate.Name = "DTP_EventDate";
            DTP_EventDate.Size = new System.Drawing.Size(200, 23);
            DTP_EventDate.TabIndex = 7;
            // 
            // NUD_MaxParticipants
            // 
            NUD_MaxParticipants.Location = new System.Drawing.Point(618, 69);
            NUD_MaxParticipants.Name = "NUD_MaxParticipants";
            NUD_MaxParticipants.Size = new System.Drawing.Size(100, 23);
            NUD_MaxParticipants.TabIndex = 9;
            // 
            // LB_03
            // 
            LB_03.Location = new System.Drawing.Point(447, 72);
            LB_03.Name = "LB_03";
            LB_03.Size = new System.Drawing.Size(165, 23);
            LB_03.TabIndex = 10;
            LB_03.Text = "N.º Máximo de participantes";
            // 
            // CB_EditEvent
            // 
            CB_EditEvent.Location = new System.Drawing.Point(724, 22);
            CB_EditEvent.Name = "CB_EditEvent";
            CB_EditEvent.Size = new System.Drawing.Size(142, 24);
            CB_EditEvent.TabIndex = 11;
            CB_EditEvent.Text = "Editar Evento";
            CB_EditEvent.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(884, 473);
            Controls.Add(CB_EditEvent);
            Controls.Add(LB_03);
            Controls.Add(NUD_MaxParticipants);
            Controls.Add(DTP_EventDate);
            Controls.Add(LB_02);
            Controls.Add(LB_01);
            Controls.Add(TB_EventName);
            Controls.Add(BT_Exit);
            Controls.Add(GB_Participants);
            Text = "Gestão de Inscrições para Eventos de Tecnologia";
            Load += mainForm_Load;
            GB_Participants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Participants).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_MaxParticipants).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.CheckBox CB_EditEvent;

        private System.Windows.Forms.Label LB_03;

        private System.Windows.Forms.NumericUpDown NUD_MaxParticipants;

        private System.Windows.Forms.DateTimePicker DTP_EventDate;

        private System.Windows.Forms.Label LB_02;

        private System.Windows.Forms.Label LB_01;

        private System.Windows.Forms.TextBox TB_EventName;

        private System.Windows.Forms.Button BT_Exit;

        private System.Windows.Forms.Button BT_RemoveParticipant;
        private System.Windows.Forms.Button BT_AddParticipant;

        private System.Windows.Forms.DataGridView DGV_Participants;

        private System.Windows.Forms.GroupBox GB_Participants;

        #endregion
    }
}
