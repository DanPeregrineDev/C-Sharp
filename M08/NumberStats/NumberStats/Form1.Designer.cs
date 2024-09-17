namespace NumberStats
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
            this.components = new System.ComponentModel.Container();
            this.LB_01 = new System.Windows.Forms.Label();
            this.TB_UserInput = new System.Windows.Forms.TextBox();
            this.LB_02 = new System.Windows.Forms.Label();
            this.LB_03 = new System.Windows.Forms.Label();
            this.LB_04 = new System.Windows.Forms.Label();
            this.LB_Median = new System.Windows.Forms.Label();
            this.LB_Biggest = new System.Windows.Forms.Label();
            this.LB_Smallest = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LB_TIME = new System.Windows.Forms.Label();
            this.Every1Sec = new System.Windows.Forms.Timer(this.components);
            this.BT_Check = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_01
            // 
            this.LB_01.AutoSize = true;
            this.LB_01.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_01.Location = new System.Drawing.Point(12, 12);
            this.LB_01.Name = "LB_01";
            this.LB_01.Size = new System.Drawing.Size(105, 29);
            this.LB_01.TabIndex = 0;
            this.LB_01.Text = "Numbers:";
            // 
            // TB_UserInput
            // 
            this.TB_UserInput.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_UserInput.Location = new System.Drawing.Point(113, 15);
            this.TB_UserInput.Name = "TB_UserInput";
            this.TB_UserInput.Size = new System.Drawing.Size(150, 29);
            this.TB_UserInput.TabIndex = 1;
            // 
            // LB_02
            // 
            this.LB_02.AutoSize = true;
            this.LB_02.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_02.Location = new System.Drawing.Point(12, 168);
            this.LB_02.Name = "LB_02";
            this.LB_02.Size = new System.Drawing.Size(87, 29);
            this.LB_02.TabIndex = 3;
            this.LB_02.Text = "Median:";
            // 
            // LB_03
            // 
            this.LB_03.AutoSize = true;
            this.LB_03.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_03.Location = new System.Drawing.Point(12, 197);
            this.LB_03.Name = "LB_03";
            this.LB_03.Size = new System.Drawing.Size(89, 29);
            this.LB_03.TabIndex = 4;
            this.LB_03.Text = "Biggest:";
            // 
            // LB_04
            // 
            this.LB_04.AutoSize = true;
            this.LB_04.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_04.Location = new System.Drawing.Point(12, 226);
            this.LB_04.Name = "LB_04";
            this.LB_04.Size = new System.Drawing.Size(100, 29);
            this.LB_04.TabIndex = 5;
            this.LB_04.Text = "Smallest:";
            // 
            // LB_Median
            // 
            this.LB_Median.AutoSize = true;
            this.LB_Median.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Median.Location = new System.Drawing.Point(237, 168);
            this.LB_Median.Name = "LB_Median";
            this.LB_Median.Size = new System.Drawing.Size(26, 29);
            this.LB_Median.TabIndex = 6;
            this.LB_Median.Text = "0";
            // 
            // LB_Biggest
            // 
            this.LB_Biggest.AutoSize = true;
            this.LB_Biggest.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Biggest.Location = new System.Drawing.Point(237, 197);
            this.LB_Biggest.Name = "LB_Biggest";
            this.LB_Biggest.Size = new System.Drawing.Size(26, 29);
            this.LB_Biggest.TabIndex = 7;
            this.LB_Biggest.Text = "0";
            // 
            // LB_Smallest
            // 
            this.LB_Smallest.AutoSize = true;
            this.LB_Smallest.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Smallest.Location = new System.Drawing.Point(237, 226);
            this.LB_Smallest.Name = "LB_Smallest";
            this.LB_Smallest.Size = new System.Drawing.Size(26, 29);
            this.LB_Smallest.TabIndex = 8;
            this.LB_Smallest.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LB_TIME
            // 
            this.LB_TIME.AutoSize = true;
            this.LB_TIME.Location = new System.Drawing.Point(17, 50);
            this.LB_TIME.Name = "LB_TIME";
            this.LB_TIME.Size = new System.Drawing.Size(50, 15);
            this.LB_TIME.TabIndex = 9;
            this.LB_TIME.Text = "LB_TIME";
            // 
            // Every1Sec
            // 
            this.Every1Sec.Enabled = true;
            this.Every1Sec.Interval = 1000;
            this.Every1Sec.Tick += new System.EventHandler(this.Every1Sec_Tick_1);
            // 
            // BT_Check
            // 
            this.BT_Check.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Check.Image = global::NumberStats.Properties.Resources._001_play_arrow1;
            this.BT_Check.Location = new System.Drawing.Point(113, 50);
            this.BT_Check.Name = "BT_Check";
            this.BT_Check.Size = new System.Drawing.Size(150, 115);
            this.BT_Check.TabIndex = 2;
            this.BT_Check.UseVisualStyleBackColor = true;
            this.BT_Check.Click += new System.EventHandler(this.BT_Check_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NumberStats.Properties.Resources._017_good_mood_emoticon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 66);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 271);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LB_TIME);
            this.Controls.Add(this.BT_Check);
            this.Controls.Add(this.LB_Smallest);
            this.Controls.Add(this.LB_Biggest);
            this.Controls.Add(this.LB_Median);
            this.Controls.Add(this.LB_04);
            this.Controls.Add(this.LB_03);
            this.Controls.Add(this.LB_02);
            this.Controls.Add(this.TB_UserInput);
            this.Controls.Add(this.LB_01);
            this.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Number Stats";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_01;
        private System.Windows.Forms.TextBox TB_UserInput;
        private System.Windows.Forms.Label LB_02;
        private System.Windows.Forms.Label LB_03;
        private System.Windows.Forms.Label LB_04;
        private System.Windows.Forms.Label LB_Median;
        private System.Windows.Forms.Label LB_Biggest;
        private System.Windows.Forms.Label LB_Smallest;
        private System.Windows.Forms.Button BT_Check;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LB_TIME;
        private System.Windows.Forms.Timer Every1Sec;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

