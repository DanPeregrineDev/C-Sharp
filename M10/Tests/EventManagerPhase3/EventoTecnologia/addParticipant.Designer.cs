namespace EventManager
{
    partial class addParticipant
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
            GB_Evento = new GroupBox();
            TB_Email = new TextBox();
            LB_02 = new Label();
            TB_Name = new TextBox();
            LB_03 = new Label();
            LB_01 = new Label();
            BT_Cancel = new Button();
            BT_Add = new Button();
            NUD_Age = new NumericUpDown();
            GB_Evento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_Age).BeginInit();
            SuspendLayout();
            // 
            // GB_Evento
            // 
            GB_Evento.Controls.Add(NUD_Age);
            GB_Evento.Controls.Add(TB_Email);
            GB_Evento.Controls.Add(LB_02);
            GB_Evento.Controls.Add(TB_Name);
            GB_Evento.Controls.Add(LB_03);
            GB_Evento.Controls.Add(LB_01);
            GB_Evento.Location = new Point(11, 10);
            GB_Evento.Margin = new Padding(2, 1, 2, 1);
            GB_Evento.Name = "GB_Evento";
            GB_Evento.Padding = new Padding(2, 1, 2, 1);
            GB_Evento.Size = new Size(500, 135);
            GB_Evento.TabIndex = 11;
            GB_Evento.TabStop = false;
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
            LB_02.Location = new Point(9, 59);
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
            LB_03.Location = new Point(9, 101);
            LB_03.Margin = new Padding(2, 0, 2, 0);
            LB_03.Name = "LB_03";
            LB_03.Size = new Size(28, 15);
            LB_03.TabIndex = 11;
            LB_03.Text = "Age";
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
            // BT_Cancel
            // 
            BT_Cancel.Location = new Point(20, 165);
            BT_Cancel.Name = "BT_Cancel";
            BT_Cancel.Size = new Size(100, 25);
            BT_Cancel.TabIndex = 13;
            BT_Cancel.Text = "Cancel";
            BT_Cancel.UseVisualStyleBackColor = true;
            BT_Cancel.Click += BT_Cancel_Click;
            // 
            // BT_Add
            // 
            BT_Add.Location = new Point(399, 165);
            BT_Add.Name = "BT_Add";
            BT_Add.Size = new Size(100, 25);
            BT_Add.TabIndex = 14;
            BT_Add.Text = "Add";
            BT_Add.UseVisualStyleBackColor = true;
            BT_Add.Click += BT_Add_Click;
            // 
            // NUD_Age
            // 
            NUD_Age.Location = new Point(71, 99);
            NUD_Age.Name = "NUD_Age";
            NUD_Age.Size = new Size(50, 23);
            NUD_Age.TabIndex = 19;
            // 
            // addParticipant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 211);
            Controls.Add(BT_Add);
            Controls.Add(BT_Cancel);
            Controls.Add(GB_Evento);
            MaximizeBox = false;
            Name = "addParticipant";
            ShowIcon = false;
            Text = "Add a participant";
            GB_Evento.ResumeLayout(false);
            GB_Evento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_Age).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GB_Evento;
        private CheckBox CB_EditEvent;
        private TextBox TB_Name;
        private DateTimePicker DTP_Date;
        private DomainUpDown DUD_MaxParticipants;
        private Label LB_03;
        private Label LB_01;
        private Label LB_02;
        private Button BT_Cancel;
        private Button BT_Add;
        private TextBox TB_Email;
        private NumericUpDown NUD_Age;
    }
}