namespace OperadoresAritmeticos
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
            this.TB_N1 = new System.Windows.Forms.TextBox();
            this.CB_Operadores = new System.Windows.Forms.ComboBox();
            this.TB_N2 = new System.Windows.Forms.TextBox();
            this.BT_Calculate = new System.Windows.Forms.Button();
            this.TB_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TB_N1
            // 
            this.TB_N1.Location = new System.Drawing.Point(25, 25);
            this.TB_N1.Name = "TB_N1";
            this.TB_N1.Size = new System.Drawing.Size(100, 20);
            this.TB_N1.TabIndex = 0;
            // 
            // CB_Operadores
            // 
            this.CB_Operadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Operadores.FormattingEnabled = true;
            this.CB_Operadores.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.CB_Operadores.Location = new System.Drawing.Point(131, 25);
            this.CB_Operadores.Name = "CB_Operadores";
            this.CB_Operadores.Size = new System.Drawing.Size(35, 21);
            this.CB_Operadores.TabIndex = 1;
            // 
            // TB_N2
            // 
            this.TB_N2.Location = new System.Drawing.Point(172, 26);
            this.TB_N2.Name = "TB_N2";
            this.TB_N2.Size = new System.Drawing.Size(100, 20);
            this.TB_N2.TabIndex = 2;
            // 
            // BT_Calculate
            // 
            this.BT_Calculate.Location = new System.Drawing.Point(278, 26);
            this.BT_Calculate.Name = "BT_Calculate";
            this.BT_Calculate.Size = new System.Drawing.Size(35, 23);
            this.BT_Calculate.TabIndex = 3;
            this.BT_Calculate.Text = "=";
            this.BT_Calculate.UseVisualStyleBackColor = true;
            this.BT_Calculate.Click += new System.EventHandler(this.BT_Calculate_Click);
            // 
            // TB_Result
            // 
            this.TB_Result.Location = new System.Drawing.Point(319, 28);
            this.TB_Result.Name = "TB_Result";
            this.TB_Result.Size = new System.Drawing.Size(100, 20);
            this.TB_Result.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 76);
            this.Controls.Add(this.TB_Result);
            this.Controls.Add(this.BT_Calculate);
            this.Controls.Add(this.TB_N2);
            this.Controls.Add(this.CB_Operadores);
            this.Controls.Add(this.TB_N1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_N1;
        private System.Windows.Forms.ComboBox CB_Operadores;
        private System.Windows.Forms.TextBox TB_N2;
        private System.Windows.Forms.Button BT_Calculate;
        private System.Windows.Forms.TextBox TB_Result;
    }
}

