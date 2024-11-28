namespace CompanyManager
{
    partial class EmployeeForm
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
            CB_Role = new System.Windows.Forms.ComboBox();
            LB_01 = new System.Windows.Forms.Label();
            LB_02 = new System.Windows.Forms.Label();
            TB_Name = new System.Windows.Forms.TextBox();
            LB_03 = new System.Windows.Forms.Label();
            TB_Email = new System.Windows.Forms.TextBox();
            LB_04 = new System.Windows.Forms.Label();
            TB_Phone = new System.Windows.Forms.TextBox();
            LB_05 = new System.Windows.Forms.Label();
            TB_ID = new System.Windows.Forms.TextBox();
            CB_Edit = new System.Windows.Forms.CheckBox();
            GB_Address = new System.Windows.Forms.GroupBox();
            TB_City = new System.Windows.Forms.TextBox();
            LB_09 = new System.Windows.Forms.Label();
            LB_08 = new System.Windows.Forms.Label();
            TB_PostalCode = new System.Windows.Forms.TextBox();
            TB_Door = new System.Windows.Forms.TextBox();
            LB_07 = new System.Windows.Forms.Label();
            TB_Street = new System.Windows.Forms.TextBox();
            LB_06 = new System.Windows.Forms.Label();
            DTP_Birthdate = new System.Windows.Forms.DateTimePicker();
            LB_10 = new System.Windows.Forms.Label();
            P_Programmer = new System.Windows.Forms.Panel();
            TB_Project = new System.Windows.Forms.TextBox();
            LB_11 = new System.Windows.Forms.Label();
            BT_Cancel = new System.Windows.Forms.Button();
            BT_Ok = new System.Windows.Forms.Button();
            GB_Address.SuspendLayout();
            P_Programmer.SuspendLayout();
            SuspendLayout();
            // 
            // CB_Role
            // 
            CB_Role.FormattingEnabled = true;
            CB_Role.Location = new System.Drawing.Point(100, 49);
            CB_Role.Name = "CB_Role";
            CB_Role.Size = new System.Drawing.Size(200, 23);
            CB_Role.TabIndex = 0;
            // 
            // LB_01
            // 
            LB_01.AutoSize = true;
            LB_01.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            LB_01.Location = new System.Drawing.Point(34, 47);
            LB_01.Name = "LB_01";
            LB_01.Size = new System.Drawing.Size(41, 21);
            LB_01.TabIndex = 1;
            LB_01.Text = "Role";
            // 
            // LB_02
            // 
            LB_02.AutoSize = true;
            LB_02.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            LB_02.Location = new System.Drawing.Point(25, 98);
            LB_02.Name = "LB_02";
            LB_02.Size = new System.Drawing.Size(52, 21);
            LB_02.TabIndex = 2;
            LB_02.Text = "Name";
            // 
            // TB_Name
            // 
            TB_Name.Location = new System.Drawing.Point(100, 100);
            TB_Name.Name = "TB_Name";
            TB_Name.Size = new System.Drawing.Size(200, 23);
            TB_Name.TabIndex = 3;
            // 
            // LB_03
            // 
            LB_03.AutoSize = true;
            LB_03.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            LB_03.Location = new System.Drawing.Point(29, 154);
            LB_03.Name = "LB_03";
            LB_03.Size = new System.Drawing.Size(48, 21);
            LB_03.TabIndex = 4;
            LB_03.Text = "Email";
            // 
            // TB_Email
            // 
            TB_Email.Location = new System.Drawing.Point(100, 152);
            TB_Email.Name = "TB_Email";
            TB_Email.Size = new System.Drawing.Size(200, 23);
            TB_Email.TabIndex = 5;
            // 
            // LB_04
            // 
            LB_04.AutoSize = true;
            LB_04.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            LB_04.Location = new System.Drawing.Point(26, 208);
            LB_04.Name = "LB_04";
            LB_04.Size = new System.Drawing.Size(54, 21);
            LB_04.TabIndex = 6;
            LB_04.Text = "Phone";
            // 
            // TB_Phone
            // 
            TB_Phone.Location = new System.Drawing.Point(100, 206);
            TB_Phone.Name = "TB_Phone";
            TB_Phone.Size = new System.Drawing.Size(200, 23);
            TB_Phone.TabIndex = 7;
            // 
            // LB_05
            // 
            LB_05.AutoSize = true;
            LB_05.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            LB_05.Location = new System.Drawing.Point(54, 261);
            LB_05.Name = "LB_05";
            LB_05.Size = new System.Drawing.Size(25, 21);
            LB_05.TabIndex = 8;
            LB_05.Text = "ID";
            // 
            // TB_ID
            // 
            TB_ID.Location = new System.Drawing.Point(100, 259);
            TB_ID.Name = "TB_ID";
            TB_ID.Size = new System.Drawing.Size(200, 23);
            TB_ID.TabIndex = 9;
            // 
            // CB_Edit
            // 
            CB_Edit.AutoSize = true;
            CB_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            CB_Edit.Location = new System.Drawing.Point(28, 313);
            CB_Edit.Name = "CB_Edit";
            CB_Edit.Size = new System.Drawing.Size(55, 25);
            CB_Edit.TabIndex = 11;
            CB_Edit.Text = "Edit";
            CB_Edit.UseVisualStyleBackColor = true;
            // 
            // GB_Address
            // 
            GB_Address.Controls.Add(TB_City);
            GB_Address.Controls.Add(LB_09);
            GB_Address.Controls.Add(LB_08);
            GB_Address.Controls.Add(TB_PostalCode);
            GB_Address.Controls.Add(TB_Door);
            GB_Address.Controls.Add(LB_07);
            GB_Address.Controls.Add(TB_Street);
            GB_Address.Controls.Add(LB_06);
            GB_Address.Location = new System.Drawing.Point(26, 361);
            GB_Address.Name = "GB_Address";
            GB_Address.Size = new System.Drawing.Size(274, 148);
            GB_Address.TabIndex = 12;
            GB_Address.TabStop = false;
            GB_Address.Text = "Address";
            // 
            // TB_City
            // 
            TB_City.Location = new System.Drawing.Point(119, 112);
            TB_City.Name = "TB_City";
            TB_City.Size = new System.Drawing.Size(147, 23);
            TB_City.TabIndex = 18;
            // 
            // LB_09
            // 
            LB_09.AutoSize = true;
            LB_09.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            LB_09.Location = new System.Drawing.Point(10, 110);
            LB_09.Name = "LB_09";
            LB_09.Size = new System.Drawing.Size(84, 21);
            LB_09.TabIndex = 17;
            LB_09.Text = "Localidade";
            // 
            // LB_08
            // 
            LB_08.AutoSize = true;
            LB_08.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            LB_08.Location = new System.Drawing.Point(8, 76);
            LB_08.Name = "LB_08";
            LB_08.Size = new System.Drawing.Size(105, 21);
            LB_08.TabIndex = 16;
            LB_08.Text = "Codigo Postal";
            // 
            // TB_PostalCode
            // 
            TB_PostalCode.Location = new System.Drawing.Point(119, 76);
            TB_PostalCode.Name = "TB_PostalCode";
            TB_PostalCode.Size = new System.Drawing.Size(147, 23);
            TB_PostalCode.TabIndex = 15;
            // 
            // TB_Door
            // 
            TB_Door.Location = new System.Drawing.Point(66, 45);
            TB_Door.Name = "TB_Door";
            TB_Door.Size = new System.Drawing.Size(200, 23);
            TB_Door.TabIndex = 13;
            // 
            // LB_07
            // 
            LB_07.AutoSize = true;
            LB_07.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            LB_07.Location = new System.Drawing.Point(8, 45);
            LB_07.Name = "LB_07";
            LB_07.Size = new System.Drawing.Size(46, 21);
            LB_07.TabIndex = 14;
            LB_07.Text = "Porta";
            // 
            // TB_Street
            // 
            TB_Street.Location = new System.Drawing.Point(66, 17);
            TB_Street.Name = "TB_Street";
            TB_Street.Size = new System.Drawing.Size(200, 23);
            TB_Street.TabIndex = 13;
            // 
            // LB_06
            // 
            LB_06.AutoSize = true;
            LB_06.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            LB_06.Location = new System.Drawing.Point(8, 15);
            LB_06.Name = "LB_06";
            LB_06.Size = new System.Drawing.Size(37, 21);
            LB_06.TabIndex = 13;
            LB_06.Text = "Rua";
            // 
            // DTP_Birthdate
            // 
            DTP_Birthdate.Location = new System.Drawing.Point(179, 525);
            DTP_Birthdate.Name = "DTP_Birthdate";
            DTP_Birthdate.Size = new System.Drawing.Size(121, 23);
            DTP_Birthdate.TabIndex = 13;
            // 
            // LB_10
            // 
            LB_10.AutoSize = true;
            LB_10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            LB_10.Location = new System.Drawing.Point(26, 526);
            LB_10.Name = "LB_10";
            LB_10.Size = new System.Drawing.Size(147, 21);
            LB_10.TabIndex = 19;
            LB_10.Text = "Data de nascimento";
            // 
            // P_Programmer
            // 
            P_Programmer.Controls.Add(TB_Project);
            P_Programmer.Controls.Add(LB_11);
            P_Programmer.Location = new System.Drawing.Point(335, 47);
            P_Programmer.Name = "P_Programmer";
            P_Programmer.Size = new System.Drawing.Size(347, 100);
            P_Programmer.TabIndex = 20;
            // 
            // TB_Project
            // 
            TB_Project.Location = new System.Drawing.Point(89, 40);
            TB_Project.Name = "TB_Project";
            TB_Project.Size = new System.Drawing.Size(233, 23);
            TB_Project.TabIndex = 19;
            // 
            // LB_11
            // 
            LB_11.AutoSize = true;
            LB_11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            LB_11.Location = new System.Drawing.Point(25, 40);
            LB_11.Name = "LB_11";
            LB_11.Size = new System.Drawing.Size(58, 21);
            LB_11.TabIndex = 19;
            LB_11.Text = "Project";
            // 
            // BT_Cancel
            // 
            BT_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            BT_Cancel.Location = new System.Drawing.Point(335, 510);
            BT_Cancel.Name = "BT_Cancel";
            BT_Cancel.Size = new System.Drawing.Size(175, 40);
            BT_Cancel.TabIndex = 22;
            BT_Cancel.Text = "Cancel";
            BT_Cancel.UseVisualStyleBackColor = true;
            // 
            // BT_Ok
            // 
            BT_Ok.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            BT_Ok.Location = new System.Drawing.Point(516, 510);
            BT_Ok.Name = "BT_Ok";
            BT_Ok.Size = new System.Drawing.Size(175, 41);
            BT_Ok.TabIndex = 23;
            BT_Ok.Text = "Ok";
            BT_Ok.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(709, 586);
            Controls.Add(BT_Ok);
            Controls.Add(BT_Cancel);
            Controls.Add(P_Programmer);
            Controls.Add(LB_10);
            Controls.Add(DTP_Birthdate);
            Controls.Add(GB_Address);
            Controls.Add(CB_Edit);
            Controls.Add(TB_ID);
            Controls.Add(LB_05);
            Controls.Add(TB_Phone);
            Controls.Add(LB_04);
            Controls.Add(TB_Email);
            Controls.Add(LB_03);
            Controls.Add(TB_Name);
            Controls.Add(LB_02);
            Controls.Add(LB_01);
            Controls.Add(CB_Role);
            Text = "EmployeeForm";
            GB_Address.ResumeLayout(false);
            GB_Address.PerformLayout();
            P_Programmer.ResumeLayout(false);
            P_Programmer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CB_Role;
        private Label LB_01;
        private Label LB_02;
        private TextBox TB_Name;
        private Label LB_03;
        private TextBox TB_Email;
        private Label LB_04;
        private TextBox TB_Phone;
        private Label LB_05;
        private TextBox TB_ID;
        private CheckBox CB_Edit;
        private GroupBox GB_Address;
        private TextBox TB_Street;
        private Label LB_06;
        private Label LB_07;
        private Label LB_08;
        private TextBox TB_PostalCode;
        private TextBox TB_Door;
        private TextBox TB_City;
        private Label LB_09;
        private DateTimePicker DTP_Birthdate;
        private Label LB_10;
        private Panel P_Programmer;
        private TextBox TB_Project;
        private Label LB_11;
        private Button BT_Cancel;
        private Button BT_Ok;
    }
}