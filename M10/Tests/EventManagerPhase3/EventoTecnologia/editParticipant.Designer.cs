namespace EventManager
{
    partial class editParticipant
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
            BT_Save = new Button();
            BT_Cancel = new Button();
            GB_Participant = new GroupBox();
            NUD_Age = new NumericUpDown();
            TB_Email = new TextBox();
            LB_02 = new Label();
            TB_Name = new TextBox();
            LB_03 = new Label();
            LB_01 = new Label();
            GB_Participant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_Age).BeginInit();
            SuspendLayout();
            // 
            // BT_Save
            // 
            BT_Save.Location = new Point(400, 170);
            BT_Save.Name = "BT_Save";
            BT_Save.Size = new Size(100, 25);
            BT_Save.TabIndex = 17;
            BT_Save.Text = "Save";
            BT_Save.UseVisualStyleBackColor = true;
            BT_Save.Click += BT_Save_Click;
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
            // GB_Participant
            // 
            GB_Participant.Controls.Add(NUD_Age);
            GB_Participant.Controls.Add(TB_Email);
            GB_Participant.Controls.Add(LB_02);
            GB_Participant.Controls.Add(TB_Name);
            GB_Participant.Controls.Add(LB_03);
            GB_Participant.Controls.Add(LB_01);
            GB_Participant.Location = new Point(12, 15);
            GB_Participant.Margin = new Padding(2, 1, 2, 1);
            GB_Participant.Name = "GB_Participant";
            GB_Participant.Padding = new Padding(2, 1, 2, 1);
            GB_Participant.Size = new Size(500, 135);
            GB_Participant.TabIndex = 15;
            GB_Participant.TabStop = false;
            // 
            // NUD_Age
            // 
            NUD_Age.Location = new Point(71, 99);
            NUD_Age.Name = "NUD_Age";
            NUD_Age.Size = new Size(50, 23);
            NUD_Age.TabIndex = 19;
            // 
            // TB_Email
            // 
            TB_Email.Location = new Point(71, 59);
            TB_Email.Margin = new Padding(2, 1, 2, 1);
            TB_Email.Name = "TB_Email";
            TB_Email.Size = new Size(417, 23);
            TB_Email.TabIndex = 18;
            // 
            // LB_02
            // 
            LB_02.AutoSize = true;
            LB_02.Location = new Point(8, 57);
            LB_02.Margin = new Padding(2, 0, 2, 0);
            LB_02.Name = "LB_02";
            LB_02.Size = new Size(36, 15);
            LB_02.TabIndex = 17;
            LB_02.Text = "Email";
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
            LB_03.Size = new Size(28, 15);
            LB_03.TabIndex = 11;
            LB_03.Text = "Age";
            // 
            // LB_01
            // 
            LB_01.AutoSize = true;
            LB_01.Location = new Point(8, 23);
            LB_01.Margin = new Padding(2, 0, 2, 0);
            LB_01.Name = "LB_01";
            LB_01.Size = new Size(39, 15);
            LB_01.TabIndex = 10;
            LB_01.Text = "Name";
            // 
            // editParticipant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 211);
            Controls.Add(BT_Save);
            Controls.Add(BT_Cancel);
            Controls.Add(GB_Participant);
            MaximizeBox = false;
            Name = "editParticipant";
            ShowIcon = false;
            Text = "Edit Participant";
            Load += editParticipant_Load;
            GB_Participant.ResumeLayout(false);
            GB_Participant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_Age).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BT_Save;
        private Button BT_Cancel;
        private GroupBox GB_Participant;
        private NumericUpDown NUD_Age;
        private TextBox TB_Email;
        private Label LB_02;
        private TextBox TB_Name;
        private Label LB_03;
        private Label LB_01;
    }
}