namespace ErrorProvider
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            TB_Username = new TextBox();
            label1 = new Label();
            TB_Password = new TextBox();
            BT_SignIn = new Button();
            LB_02 = new Label();
            LB_03 = new Label();
            EP_Username = new System.Windows.Forms.ErrorProvider(components);
            EP_Password = new System.Windows.Forms.ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)EP_Username).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EP_Password).BeginInit();
            SuspendLayout();
            // 
            // TB_Username
            // 
            TB_Username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Username.Location = new Point(50, 200);
            TB_Username.Name = "TB_Username";
            TB_Username.Size = new Size(225, 29);
            TB_Username.TabIndex = 0;
            TB_Username.Validating += TB_Username_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nunito", 35.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 50);
            label1.Name = "label1";
            label1.Size = new Size(183, 66);
            label1.TabIndex = 1;
            label1.Text = "Sign-In";
            // 
            // TB_Password
            // 
            TB_Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Password.Location = new Point(50, 275);
            TB_Password.Name = "TB_Password";
            TB_Password.Size = new Size(225, 29);
            TB_Password.TabIndex = 2;
            TB_Password.UseSystemPasswordChar = true;
            TB_Password.Validating += TB_Password_Validating;
            // 
            // BT_SignIn
            // 
            BT_SignIn.Font = new Font("Nunito", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BT_SignIn.Location = new Point(50, 350);
            BT_SignIn.Name = "BT_SignIn";
            BT_SignIn.Size = new Size(225, 50);
            BT_SignIn.TabIndex = 3;
            BT_SignIn.Text = "Sign-In";
            BT_SignIn.UseVisualStyleBackColor = true;
            // 
            // LB_02
            // 
            LB_02.AutoSize = true;
            LB_02.Location = new Point(50, 182);
            LB_02.Name = "LB_02";
            LB_02.Size = new Size(60, 15);
            LB_02.TabIndex = 4;
            LB_02.Text = "Username";
            // 
            // LB_03
            // 
            LB_03.AutoSize = true;
            LB_03.Location = new Point(50, 257);
            LB_03.Name = "LB_03";
            LB_03.Size = new Size(57, 15);
            LB_03.TabIndex = 5;
            LB_03.Text = "Password";
            // 
            // EP_Username
            // 
            EP_Username.ContainerControl = this;
            // 
            // EP_Password
            // 
            EP_Password.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 461);
            Controls.Add(LB_03);
            Controls.Add(LB_02);
            Controls.Add(BT_SignIn);
            Controls.Add(TB_Password);
            Controls.Add(label1);
            Controls.Add(TB_Username);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "Sign-In";
            ((System.ComponentModel.ISupportInitialize)EP_Username).EndInit();
            ((System.ComponentModel.ISupportInitialize)EP_Password).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_Username;
        private Label label1;
        private TextBox TB_Password;
        private Button BT_SignIn;
        private Label LB_02;
        private Label LB_03;
        private System.Windows.Forms.ErrorProvider EP_Username;
        private System.Windows.Forms.ErrorProvider EP_Password;
    }
}
