namespace Media
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_MEDIAN = new System.Windows.Forms.Label();
            this.TB_N1 = new System.Windows.Forms.TextBox();
            this.TB_N2 = new System.Windows.Forms.TextBox();
            this.TB_N3 = new System.Windows.Forms.TextBox();
            this.BT_CALCULATE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "N1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "N2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "N3";
            // 
            // LB_MEDIAN
            // 
            this.LB_MEDIAN.AutoSize = true;
            this.LB_MEDIAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MEDIAN.Location = new System.Drawing.Point(81, 243);
            this.LB_MEDIAN.Name = "LB_MEDIAN";
            this.LB_MEDIAN.Size = new System.Drawing.Size(70, 26);
            this.LB_MEDIAN.TabIndex = 3;
            this.LB_MEDIAN.Text = "label4";
            // 
            // TB_N1
            // 
            this.TB_N1.Location = new System.Drawing.Point(100, 33);
            this.TB_N1.Name = "TB_N1";
            this.TB_N1.Size = new System.Drawing.Size(100, 20);
            this.TB_N1.TabIndex = 4;
            // 
            // TB_N2
            // 
            this.TB_N2.Location = new System.Drawing.Point(100, 81);
            this.TB_N2.Name = "TB_N2";
            this.TB_N2.Size = new System.Drawing.Size(100, 20);
            this.TB_N2.TabIndex = 5;
            // 
            // TB_N3
            // 
            this.TB_N3.Location = new System.Drawing.Point(100, 129);
            this.TB_N3.Name = "TB_N3";
            this.TB_N3.Size = new System.Drawing.Size(100, 20);
            this.TB_N3.TabIndex = 6;
            // 
            // BT_CALCULATE
            // 
            this.BT_CALCULATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CALCULATE.Location = new System.Drawing.Point(28, 174);
            this.BT_CALCULATE.Name = "BT_CALCULATE";
            this.BT_CALCULATE.Size = new System.Drawing.Size(172, 37);
            this.BT_CALCULATE.TabIndex = 7;
            this.BT_CALCULATE.Text = "Media";
            this.BT_CALCULATE.UseVisualStyleBackColor = true;
            this.BT_CALCULATE.Click += new System.EventHandler(this.BT_CALCULATE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 293);
            this.Controls.Add(this.BT_CALCULATE);
            this.Controls.Add(this.TB_N3);
            this.Controls.Add(this.TB_N2);
            this.Controls.Add(this.TB_N1);
            this.Controls.Add(this.LB_MEDIAN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Media";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_MEDIAN;
        private System.Windows.Forms.TextBox TB_N1;
        private System.Windows.Forms.TextBox TB_N2;
        private System.Windows.Forms.TextBox TB_N3;
        private System.Windows.Forms.Button BT_CALCULATE;
    }
}

