namespace Palindrome
{
    partial class F_Main
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
            this.TB_Text = new System.Windows.Forms.TextBox();
            this.BT_Check = new System.Windows.Forms.Button();
            this.LB_Check = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Text
            // 
            this.TB_Text.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Text.Location = new System.Drawing.Point(12, 12);
            this.TB_Text.Name = "TB_Text";
            this.TB_Text.Size = new System.Drawing.Size(250, 23);
            this.TB_Text.TabIndex = 0;
            // 
            // BT_Check
            // 
            this.BT_Check.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Check.Location = new System.Drawing.Point(12, 43);
            this.BT_Check.Name = "BT_Check";
            this.BT_Check.Size = new System.Drawing.Size(250, 50);
            this.BT_Check.TabIndex = 1;
            this.BT_Check.Text = "Check";
            this.BT_Check.UseVisualStyleBackColor = true;
            this.BT_Check.Click += new System.EventHandler(this.BT_Check_Click);
            // 
            // LB_Check
            // 
            this.LB_Check.AutoSize = true;
            this.LB_Check.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Check.Location = new System.Drawing.Point(115, 110);
            this.LB_Check.Name = "LB_Check";
            this.LB_Check.Size = new System.Drawing.Size(0, 29);
            this.LB_Check.TabIndex = 2;
            this.LB_Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 161);
            this.Controls.Add(this.LB_Check);
            this.Controls.Add(this.BT_Check);
            this.Controls.Add(this.TB_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Palindrome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Text;
        private System.Windows.Forms.Button BT_Check;
        private System.Windows.Forms.Label LB_Check;
    }
}

