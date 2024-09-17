namespace Calculator
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
            this.BT_Add = new System.Windows.Forms.Button();
            this.BT_Minus = new System.Windows.Forms.Button();
            this.BT_Multiply = new System.Windows.Forms.Button();
            this.TB_Display = new System.Windows.Forms.TextBox();
            this.BT_7 = new System.Windows.Forms.Button();
            this.BT_8 = new System.Windows.Forms.Button();
            this.BT_9 = new System.Windows.Forms.Button();
            this.BT_4 = new System.Windows.Forms.Button();
            this.BT_5 = new System.Windows.Forms.Button();
            this.BT_6 = new System.Windows.Forms.Button();
            this.BT_1 = new System.Windows.Forms.Button();
            this.BT_2 = new System.Windows.Forms.Button();
            this.BT_3 = new System.Windows.Forms.Button();
            this.BT_Decimal = new System.Windows.Forms.Button();
            this.BT_Calculate = new System.Windows.Forms.Button();
            this.BT_0 = new System.Windows.Forms.Button();
            this.BT_ClearEntry = new System.Windows.Forms.Button();
            this.BT_Divide = new System.Windows.Forms.Button();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_Add
            // 
            this.BT_Add.Location = new System.Drawing.Point(12, 50);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(30, 23);
            this.BT_Add.TabIndex = 0;
            this.BT_Add.Text = "+";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.BT_Operator_Click);
            // 
            // BT_Minus
            // 
            this.BT_Minus.Location = new System.Drawing.Point(48, 50);
            this.BT_Minus.Name = "BT_Minus";
            this.BT_Minus.Size = new System.Drawing.Size(30, 23);
            this.BT_Minus.TabIndex = 1;
            this.BT_Minus.Text = "-";
            this.BT_Minus.UseVisualStyleBackColor = true;
            this.BT_Minus.Click += new System.EventHandler(this.BT_Operator_Click);
            // 
            // BT_Multiply
            // 
            this.BT_Multiply.Location = new System.Drawing.Point(84, 50);
            this.BT_Multiply.Name = "BT_Multiply";
            this.BT_Multiply.Size = new System.Drawing.Size(30, 23);
            this.BT_Multiply.TabIndex = 2;
            this.BT_Multiply.Text = "x";
            this.BT_Multiply.UseVisualStyleBackColor = true;
            this.BT_Multiply.Click += new System.EventHandler(this.BT_Operator_Click);
            // 
            // TB_Display
            // 
            this.TB_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Display.Location = new System.Drawing.Point(12, 12);
            this.TB_Display.Name = "TB_Display";
            this.TB_Display.ReadOnly = true;
            this.TB_Display.Size = new System.Drawing.Size(138, 32);
            this.TB_Display.TabIndex = 10;
            this.TB_Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BT_7
            // 
            this.BT_7.Location = new System.Drawing.Point(12, 79);
            this.BT_7.Name = "BT_7";
            this.BT_7.Size = new System.Drawing.Size(30, 23);
            this.BT_7.TabIndex = 11;
            this.BT_7.Text = "7";
            this.BT_7.UseVisualStyleBackColor = true;
            this.BT_7.Click += new System.EventHandler(this.BT_Num_Click);
            // 
            // BT_8
            // 
            this.BT_8.Location = new System.Drawing.Point(48, 79);
            this.BT_8.Name = "BT_8";
            this.BT_8.Size = new System.Drawing.Size(30, 23);
            this.BT_8.TabIndex = 12;
            this.BT_8.Text = "8";
            this.BT_8.UseVisualStyleBackColor = true;
            this.BT_8.Click += new System.EventHandler(this.BT_Num_Click);
            // 
            // BT_9
            // 
            this.BT_9.Location = new System.Drawing.Point(84, 79);
            this.BT_9.Name = "BT_9";
            this.BT_9.Size = new System.Drawing.Size(30, 23);
            this.BT_9.TabIndex = 13;
            this.BT_9.Text = "9";
            this.BT_9.UseVisualStyleBackColor = true;
            this.BT_9.Click += new System.EventHandler(this.BT_Num_Click);
            // 
            // BT_4
            // 
            this.BT_4.Location = new System.Drawing.Point(12, 108);
            this.BT_4.Name = "BT_4";
            this.BT_4.Size = new System.Drawing.Size(30, 23);
            this.BT_4.TabIndex = 14;
            this.BT_4.Text = "4";
            this.BT_4.UseVisualStyleBackColor = true;
            this.BT_4.Click += new System.EventHandler(this.BT_Num_Click);
            // 
            // BT_5
            // 
            this.BT_5.Location = new System.Drawing.Point(48, 108);
            this.BT_5.Name = "BT_5";
            this.BT_5.Size = new System.Drawing.Size(30, 23);
            this.BT_5.TabIndex = 15;
            this.BT_5.Text = "5";
            this.BT_5.UseVisualStyleBackColor = true;
            this.BT_5.Click += new System.EventHandler(this.BT_Num_Click);
            // 
            // BT_6
            // 
            this.BT_6.Location = new System.Drawing.Point(84, 108);
            this.BT_6.Name = "BT_6";
            this.BT_6.Size = new System.Drawing.Size(30, 23);
            this.BT_6.TabIndex = 16;
            this.BT_6.Text = "6";
            this.BT_6.UseVisualStyleBackColor = true;
            this.BT_6.Click += new System.EventHandler(this.BT_Num_Click);
            // 
            // BT_1
            // 
            this.BT_1.Location = new System.Drawing.Point(12, 137);
            this.BT_1.Name = "BT_1";
            this.BT_1.Size = new System.Drawing.Size(30, 23);
            this.BT_1.TabIndex = 17;
            this.BT_1.Text = "1";
            this.BT_1.UseVisualStyleBackColor = true;
            this.BT_1.Click += new System.EventHandler(this.BT_Num_Click);
            // 
            // BT_2
            // 
            this.BT_2.Location = new System.Drawing.Point(48, 137);
            this.BT_2.Name = "BT_2";
            this.BT_2.Size = new System.Drawing.Size(30, 23);
            this.BT_2.TabIndex = 18;
            this.BT_2.Text = "2";
            this.BT_2.UseVisualStyleBackColor = true;
            this.BT_2.Click += new System.EventHandler(this.BT_Num_Click);
            // 
            // BT_3
            // 
            this.BT_3.Location = new System.Drawing.Point(84, 137);
            this.BT_3.Name = "BT_3";
            this.BT_3.Size = new System.Drawing.Size(30, 23);
            this.BT_3.TabIndex = 19;
            this.BT_3.Text = "3";
            this.BT_3.UseVisualStyleBackColor = true;
            this.BT_3.Click += new System.EventHandler(this.BT_Num_Click);
            // 
            // BT_Decimal
            // 
            this.BT_Decimal.Location = new System.Drawing.Point(84, 166);
            this.BT_Decimal.Name = "BT_Decimal";
            this.BT_Decimal.Size = new System.Drawing.Size(30, 23);
            this.BT_Decimal.TabIndex = 20;
            this.BT_Decimal.Text = ".";
            this.BT_Decimal.UseVisualStyleBackColor = true;
            // 
            // BT_Calculate
            // 
            this.BT_Calculate.Location = new System.Drawing.Point(120, 137);
            this.BT_Calculate.Name = "BT_Calculate";
            this.BT_Calculate.Size = new System.Drawing.Size(30, 52);
            this.BT_Calculate.TabIndex = 21;
            this.BT_Calculate.Text = "=";
            this.BT_Calculate.UseVisualStyleBackColor = true;
            this.BT_Calculate.Click += new System.EventHandler(this.BT_Operator_Click);
            // 
            // BT_0
            // 
            this.BT_0.Location = new System.Drawing.Point(12, 166);
            this.BT_0.Name = "BT_0";
            this.BT_0.Size = new System.Drawing.Size(66, 23);
            this.BT_0.TabIndex = 22;
            this.BT_0.Text = "0";
            this.BT_0.UseVisualStyleBackColor = true;
            this.BT_0.Click += new System.EventHandler(this.BT_Num_Click);
            // 
            // BT_ClearEntry
            // 
            this.BT_ClearEntry.Location = new System.Drawing.Point(120, 79);
            this.BT_ClearEntry.Name = "BT_ClearEntry";
            this.BT_ClearEntry.Size = new System.Drawing.Size(30, 23);
            this.BT_ClearEntry.TabIndex = 23;
            this.BT_ClearEntry.Text = "C";
            this.BT_ClearEntry.UseVisualStyleBackColor = true;
            this.BT_ClearEntry.Click += new System.EventHandler(this.BT_ClearEntry_Click);
            // 
            // BT_Divide
            // 
            this.BT_Divide.Location = new System.Drawing.Point(120, 50);
            this.BT_Divide.Name = "BT_Divide";
            this.BT_Divide.Size = new System.Drawing.Size(30, 23);
            this.BT_Divide.TabIndex = 24;
            this.BT_Divide.Text = "÷";
            this.BT_Divide.UseVisualStyleBackColor = true;
            this.BT_Divide.Click += new System.EventHandler(this.BT_Operator_Click);
            // 
            // BT_Delete
            // 
            this.BT_Delete.Location = new System.Drawing.Point(120, 108);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(30, 23);
            this.BT_Delete.TabIndex = 25;
            this.BT_Delete.Text = "<";
            this.BT_Delete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 205);
            this.Controls.Add(this.BT_Delete);
            this.Controls.Add(this.BT_Divide);
            this.Controls.Add(this.BT_ClearEntry);
            this.Controls.Add(this.BT_0);
            this.Controls.Add(this.BT_Calculate);
            this.Controls.Add(this.BT_Decimal);
            this.Controls.Add(this.BT_3);
            this.Controls.Add(this.BT_2);
            this.Controls.Add(this.BT_1);
            this.Controls.Add(this.BT_6);
            this.Controls.Add(this.BT_5);
            this.Controls.Add(this.BT_4);
            this.Controls.Add(this.BT_9);
            this.Controls.Add(this.BT_8);
            this.Controls.Add(this.BT_7);
            this.Controls.Add(this.TB_Display);
            this.Controls.Add(this.BT_Multiply);
            this.Controls.Add(this.BT_Minus);
            this.Controls.Add(this.BT_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.Button BT_Minus;
        private System.Windows.Forms.Button BT_Multiply;
        private System.Windows.Forms.TextBox TB_Display;
        private System.Windows.Forms.Button BT_7;
        private System.Windows.Forms.Button BT_8;
        private System.Windows.Forms.Button BT_9;
        private System.Windows.Forms.Button BT_4;
        private System.Windows.Forms.Button BT_5;
        private System.Windows.Forms.Button BT_6;
        private System.Windows.Forms.Button BT_1;
        private System.Windows.Forms.Button BT_2;
        private System.Windows.Forms.Button BT_3;
        private System.Windows.Forms.Button BT_Decimal;
        private System.Windows.Forms.Button BT_Calculate;
        private System.Windows.Forms.Button BT_0;
        private System.Windows.Forms.Button BT_ClearEntry;
        private System.Windows.Forms.Button BT_Divide;
        private System.Windows.Forms.Button BT_Delete;
    }
}

