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
            components = new System.ComponentModel.Container();
            CB_Role = new ComboBox();
            LB_01 = new Label();
            LB_02 = new Label();
            TB_Name = new TextBox();
            LB_03 = new Label();
            TB_Email = new TextBox();
            LB_04 = new Label();
            TB_Phone = new TextBox();
            LB_05 = new Label();
            TB_ID = new TextBox();
            CB_Edit = new CheckBox();
            GB_Address = new GroupBox();
            TB_Locality = new TextBox();
            LB_09 = new Label();
            LB_08 = new Label();
            TB_PostalCode = new TextBox();
            TB_Door = new TextBox();
            LB_07 = new Label();
            TB_Street = new TextBox();
            LB_06 = new Label();
            DTP_Birthdate = new DateTimePicker();
            LB_10 = new Label();
            P_Programmer = new Panel();
            TB_ProjectProgrammer = new TextBox();
            LB_11 = new Label();
            BT_Cancel = new Button();
            BT_Ok = new Button();
            P_Analyst = new Panel();
            TB_ProjectAnalyst = new TextBox();
            LB_12 = new Label();
            EP_VerifyName = new ErrorProvider(components);
            EP_VerifyEmail = new ErrorProvider(components);
            EP_VerifyPhone = new ErrorProvider(components);
            EP_VerifyPostalCode = new ErrorProvider(components);
            GB_Address.SuspendLayout();
            P_Programmer.SuspendLayout();
            P_Analyst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EP_VerifyName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EP_VerifyEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EP_VerifyPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EP_VerifyPostalCode).BeginInit();
            SuspendLayout();
            // 
            // CB_Role
            // 
            CB_Role.FormattingEnabled = true;
            CB_Role.Location = new Point(100, 49);
            CB_Role.Name = "CB_Role";
            CB_Role.Size = new Size(200, 23);
            CB_Role.TabIndex = 0;
            CB_Role.SelectedIndexChanged += CB_Role_SelectedIndexChanged;
            // 
            // LB_01
            // 
            LB_01.AutoSize = true;
            LB_01.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_01.Location = new Point(34, 47);
            LB_01.Name = "LB_01";
            LB_01.Size = new Size(41, 21);
            LB_01.TabIndex = 1;
            LB_01.Text = "Role";
            // 
            // LB_02
            // 
            LB_02.AutoSize = true;
            LB_02.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_02.Location = new Point(25, 98);
            LB_02.Name = "LB_02";
            LB_02.Size = new Size(52, 21);
            LB_02.TabIndex = 2;
            LB_02.Text = "Name";
            // 
            // TB_Name
            // 
            TB_Name.Location = new Point(100, 100);
            TB_Name.Name = "TB_Name";
            TB_Name.Size = new Size(200, 23);
            TB_Name.TabIndex = 3;
            TB_Name.Validating += TB_Name_Validating;
            // 
            // LB_03
            // 
            LB_03.AutoSize = true;
            LB_03.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_03.Location = new Point(29, 154);
            LB_03.Name = "LB_03";
            LB_03.Size = new Size(48, 21);
            LB_03.TabIndex = 4;
            LB_03.Text = "Email";
            // 
            // TB_Email
            // 
            TB_Email.Location = new Point(100, 152);
            TB_Email.Name = "TB_Email";
            TB_Email.Size = new Size(200, 23);
            TB_Email.TabIndex = 5;
            TB_Email.Validating += TB_Email_Validating;
            // 
            // LB_04
            // 
            LB_04.AutoSize = true;
            LB_04.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_04.Location = new Point(26, 208);
            LB_04.Name = "LB_04";
            LB_04.Size = new Size(54, 21);
            LB_04.TabIndex = 6;
            LB_04.Text = "Phone";
            // 
            // TB_Phone
            // 
            TB_Phone.Location = new Point(100, 206);
            TB_Phone.Name = "TB_Phone";
            TB_Phone.Size = new Size(200, 23);
            TB_Phone.TabIndex = 7;
            TB_Phone.Validating += TB_Phone_Validating;
            // 
            // LB_05
            // 
            LB_05.AutoSize = true;
            LB_05.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_05.Location = new Point(54, 261);
            LB_05.Name = "LB_05";
            LB_05.Size = new Size(25, 21);
            LB_05.TabIndex = 8;
            LB_05.Text = "ID";
            // 
            // TB_ID
            // 
            TB_ID.Location = new Point(100, 259);
            TB_ID.Name = "TB_ID";
            TB_ID.Size = new Size(200, 23);
            TB_ID.TabIndex = 9;
            // 
            // CB_Edit
            // 
            CB_Edit.AutoSize = true;
            CB_Edit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CB_Edit.Location = new Point(28, 313);
            CB_Edit.Name = "CB_Edit";
            CB_Edit.Size = new Size(55, 25);
            CB_Edit.TabIndex = 11;
            CB_Edit.Text = "Edit";
            CB_Edit.UseVisualStyleBackColor = true;
            CB_Edit.CheckedChanged += CB_Edit_CheckedChanged;
            // 
            // GB_Address
            // 
            GB_Address.Controls.Add(TB_Locality);
            GB_Address.Controls.Add(LB_09);
            GB_Address.Controls.Add(LB_08);
            GB_Address.Controls.Add(TB_PostalCode);
            GB_Address.Controls.Add(TB_Door);
            GB_Address.Controls.Add(LB_07);
            GB_Address.Controls.Add(TB_Street);
            GB_Address.Controls.Add(LB_06);
            GB_Address.Location = new Point(26, 361);
            GB_Address.Name = "GB_Address";
            GB_Address.Size = new Size(274, 148);
            GB_Address.TabIndex = 12;
            GB_Address.TabStop = false;
            GB_Address.Text = "Address";
            // 
            // TB_Locality
            // 
            TB_Locality.Location = new Point(119, 112);
            TB_Locality.Name = "TB_Locality";
            TB_Locality.Size = new Size(147, 23);
            TB_Locality.TabIndex = 18;
            // 
            // LB_09
            // 
            LB_09.AutoSize = true;
            LB_09.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_09.Location = new Point(10, 110);
            LB_09.Name = "LB_09";
            LB_09.Size = new Size(84, 21);
            LB_09.TabIndex = 17;
            LB_09.Text = "Localidade";
            // 
            // LB_08
            // 
            LB_08.AutoSize = true;
            LB_08.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_08.Location = new Point(8, 76);
            LB_08.Name = "LB_08";
            LB_08.Size = new Size(105, 21);
            LB_08.TabIndex = 16;
            LB_08.Text = "Codigo Postal";
            // 
            // TB_PostalCode
            // 
            TB_PostalCode.Location = new Point(119, 76);
            TB_PostalCode.Name = "TB_PostalCode";
            TB_PostalCode.Size = new Size(147, 23);
            TB_PostalCode.TabIndex = 15;
            TB_PostalCode.Validating += TB_PostalCode_Validating;
            // 
            // TB_Door
            // 
            TB_Door.Location = new Point(66, 45);
            TB_Door.Name = "TB_Door";
            TB_Door.Size = new Size(200, 23);
            TB_Door.TabIndex = 13;
            // 
            // LB_07
            // 
            LB_07.AutoSize = true;
            LB_07.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_07.Location = new Point(8, 45);
            LB_07.Name = "LB_07";
            LB_07.Size = new Size(46, 21);
            LB_07.TabIndex = 14;
            LB_07.Text = "Porta";
            // 
            // TB_Street
            // 
            TB_Street.Location = new Point(66, 17);
            TB_Street.Name = "TB_Street";
            TB_Street.Size = new Size(200, 23);
            TB_Street.TabIndex = 13;
            // 
            // LB_06
            // 
            LB_06.AutoSize = true;
            LB_06.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_06.Location = new Point(8, 15);
            LB_06.Name = "LB_06";
            LB_06.Size = new Size(37, 21);
            LB_06.TabIndex = 13;
            LB_06.Text = "Rua";
            // 
            // DTP_Birthdate
            // 
            DTP_Birthdate.Location = new Point(179, 525);
            DTP_Birthdate.Name = "DTP_Birthdate";
            DTP_Birthdate.Size = new Size(121, 23);
            DTP_Birthdate.TabIndex = 13;
            // 
            // LB_10
            // 
            LB_10.AutoSize = true;
            LB_10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_10.Location = new Point(26, 526);
            LB_10.Name = "LB_10";
            LB_10.Size = new Size(147, 21);
            LB_10.TabIndex = 19;
            LB_10.Text = "Data de nascimento";
            // 
            // P_Programmer
            // 
            P_Programmer.Controls.Add(TB_ProjectProgrammer);
            P_Programmer.Controls.Add(LB_11);
            P_Programmer.Location = new Point(335, 47);
            P_Programmer.Name = "P_Programmer";
            P_Programmer.Size = new Size(347, 100);
            P_Programmer.TabIndex = 20;
            // 
            // TB_ProjectProgrammer
            // 
            TB_ProjectProgrammer.Location = new Point(89, 40);
            TB_ProjectProgrammer.Name = "TB_ProjectProgrammer";
            TB_ProjectProgrammer.Size = new Size(233, 23);
            TB_ProjectProgrammer.TabIndex = 19;
            // 
            // LB_11
            // 
            LB_11.AutoSize = true;
            LB_11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_11.Location = new Point(25, 40);
            LB_11.Name = "LB_11";
            LB_11.Size = new Size(58, 21);
            LB_11.TabIndex = 19;
            LB_11.Text = "Project";
            // 
            // BT_Cancel
            // 
            BT_Cancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BT_Cancel.Location = new Point(335, 510);
            BT_Cancel.Name = "BT_Cancel";
            BT_Cancel.Size = new Size(175, 40);
            BT_Cancel.TabIndex = 22;
            BT_Cancel.Text = "Cancel";
            BT_Cancel.UseVisualStyleBackColor = true;
            // 
            // BT_Ok
            // 
            BT_Ok.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BT_Ok.Location = new Point(516, 510);
            BT_Ok.Name = "BT_Ok";
            BT_Ok.Size = new Size(175, 41);
            BT_Ok.TabIndex = 23;
            BT_Ok.Text = "Ok";
            BT_Ok.UseVisualStyleBackColor = true;
            BT_Ok.Click += BT_Ok_Click;
            // 
            // P_Analyst
            // 
            P_Analyst.Controls.Add(TB_ProjectAnalyst);
            P_Analyst.Controls.Add(LB_12);
            P_Analyst.Location = new Point(335, 182);
            P_Analyst.Name = "P_Analyst";
            P_Analyst.Size = new Size(347, 100);
            P_Analyst.TabIndex = 21;
            // 
            // TB_ProjectAnalyst
            // 
            TB_ProjectAnalyst.Location = new Point(89, 40);
            TB_ProjectAnalyst.Name = "TB_ProjectAnalyst";
            TB_ProjectAnalyst.Size = new Size(233, 23);
            TB_ProjectAnalyst.TabIndex = 19;
            // 
            // LB_12
            // 
            LB_12.AutoSize = true;
            LB_12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_12.Location = new Point(7, 38);
            LB_12.Name = "LB_12";
            LB_12.Size = new Size(76, 21);
            LB_12.TabIndex = 19;
            LB_12.Text = "Speciality";
            // 
            // EP_VerifyName
            // 
            EP_VerifyName.ContainerControl = this;
            // 
            // EP_VerifyEmail
            // 
            EP_VerifyEmail.ContainerControl = this;
            // 
            // EP_VerifyPhone
            // 
            EP_VerifyPhone.ContainerControl = this;
            // 
            // EP_VerifyPostalCode
            // 
            EP_VerifyPostalCode.ContainerControl = this;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 586);
            Controls.Add(P_Analyst);
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
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            FormClosed += EmployeeForm_FormClosed;
            Load += EmployeeForm_Load;
            GB_Address.ResumeLayout(false);
            GB_Address.PerformLayout();
            P_Programmer.ResumeLayout(false);
            P_Programmer.PerformLayout();
            P_Analyst.ResumeLayout(false);
            P_Analyst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EP_VerifyName).EndInit();
            ((System.ComponentModel.ISupportInitialize)EP_VerifyEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)EP_VerifyPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)EP_VerifyPostalCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel P_Analyst;
        private System.Windows.Forms.TextBox TB_ProjectAnalyst;
        private System.Windows.Forms.Label LB_12;

        #endregion

        private System.Windows.Forms.ComboBox CB_Role;
        private Label LB_01;
        private Label LB_02;
        private TextBox TB_Name;
        private Label LB_03;
        private TextBox TB_Email;
        private Label LB_04;
        private TextBox TB_Phone;
        private Label LB_05;
        private TextBox TB_ID;
        private System.Windows.Forms.CheckBox CB_Edit;
        private GroupBox GB_Address;
        private TextBox TB_Street;
        private Label LB_06;
        private Label LB_07;
        private Label LB_08;
        private TextBox TB_PostalCode;
        private TextBox TB_Door;
        private TextBox TB_Locality;
        private Label LB_09;
        private DateTimePicker DTP_Birthdate;
        private Label LB_10;
        private System.Windows.Forms.Panel P_Programmer;
        private TextBox TB_ProjectProgrammer;
        private Label LB_11;
        private Button BT_Cancel;
        private System.Windows.Forms.Button BT_Ok;
        private ErrorProvider EP_VerifyName;
        private ErrorProvider EP_VerifyEmail;
        private ErrorProvider EP_VerifyPhone;
        private ErrorProvider EP_VerifyPostalCode;
    }
}