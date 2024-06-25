namespace CalculateAge
{
    partial class Form1
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
            this.DT_Birthday = new System.Windows.Forms.DateTimePicker();
            this.BT_Calculate = new System.Windows.Forms.Button();
            this.LB_01 = new System.Windows.Forms.Label();
            this.LB_Age = new System.Windows.Forms.Label();
            this.LB_LeapYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DT_Birthday
            // 
            this.DT_Birthday.Location = new System.Drawing.Point(92, 11);
            this.DT_Birthday.Name = "DT_Birthday";
            this.DT_Birthday.Size = new System.Drawing.Size(200, 20);
            this.DT_Birthday.TabIndex = 0;
            // 
            // BT_Calculate
            // 
            this.BT_Calculate.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Calculate.Location = new System.Drawing.Point(16, 50);
            this.BT_Calculate.Name = "BT_Calculate";
            this.BT_Calculate.Size = new System.Drawing.Size(277, 50);
            this.BT_Calculate.TabIndex = 1;
            this.BT_Calculate.Text = "Calculate Age";
            this.BT_Calculate.UseVisualStyleBackColor = true;
            this.BT_Calculate.Click += new System.EventHandler(this.BT_Calculate_Click);
            // 
            // LB_01
            // 
            this.LB_01.AutoSize = true;
            this.LB_01.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_01.Location = new System.Drawing.Point(12, 9);
            this.LB_01.Name = "LB_01";
            this.LB_01.Size = new System.Drawing.Size(75, 22);
            this.LB_01.TabIndex = 2;
            this.LB_01.Text = "Birthday:";
            // 
            // LB_Age
            // 
            this.LB_Age.AutoSize = true;
            this.LB_Age.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Age.Location = new System.Drawing.Point(12, 125);
            this.LB_Age.Name = "LB_Age";
            this.LB_Age.Size = new System.Drawing.Size(0, 22);
            this.LB_Age.TabIndex = 3;
            // 
            // LB_LeapYear
            // 
            this.LB_LeapYear.AutoSize = true;
            this.LB_LeapYear.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LeapYear.Location = new System.Drawing.Point(12, 180);
            this.LB_LeapYear.Name = "LB_LeapYear";
            this.LB_LeapYear.Size = new System.Drawing.Size(0, 22);
            this.LB_LeapYear.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 211);
            this.Controls.Add(this.LB_LeapYear);
            this.Controls.Add(this.LB_Age);
            this.Controls.Add(this.LB_01);
            this.Controls.Add(this.BT_Calculate);
            this.Controls.Add(this.DT_Birthday);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DT_Birthday;
        private System.Windows.Forms.Button BT_Calculate;
        private System.Windows.Forms.Label LB_01;
        private System.Windows.Forms.Label LB_Age;
        private System.Windows.Forms.Label LB_LeapYear;
    }
}

