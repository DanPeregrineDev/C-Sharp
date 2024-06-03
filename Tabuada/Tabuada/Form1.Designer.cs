namespace Tabuada
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
            this.LB_01 = new System.Windows.Forms.Label();
            this.BT_Calcular = new System.Windows.Forms.Button();
            this.TB_N = new System.Windows.Forms.TextBox();
            this.ListBox_Tabuada = new System.Windows.Forms.ListBox();
            this.BT_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_01
            // 
            this.LB_01.AutoSize = true;
            this.LB_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_01.Location = new System.Drawing.Point(29, 31);
            this.LB_01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_01.Name = "LB_01";
            this.LB_01.Size = new System.Drawing.Size(126, 26);
            this.LB_01.TabIndex = 0;
            this.LB_01.Text = "Tabuada de";
            // 
            // BT_Calcular
            // 
            this.BT_Calcular.Location = new System.Drawing.Point(347, 86);
            this.BT_Calcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BT_Calcular.Name = "BT_Calcular";
            this.BT_Calcular.Size = new System.Drawing.Size(172, 58);
            this.BT_Calcular.TabIndex = 1;
            this.BT_Calcular.Text = "Calcular";
            this.BT_Calcular.UseVisualStyleBackColor = true;
            this.BT_Calcular.Click += new System.EventHandler(this.BT_Calcular_Click);
            // 
            // TB_N
            // 
            this.TB_N.Location = new System.Drawing.Point(205, 38);
            this.TB_N.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_N.MaxLength = 3;
            this.TB_N.Name = "TB_N";
            this.TB_N.Size = new System.Drawing.Size(132, 22);
            this.TB_N.TabIndex = 2;
            this.TB_N.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_N_KeyPress);
            // 
            // ListBox_Tabuada
            // 
            this.ListBox_Tabuada.FormattingEnabled = true;
            this.ListBox_Tabuada.ItemHeight = 16;
            this.ListBox_Tabuada.Location = new System.Drawing.Point(36, 86);
            this.ListBox_Tabuada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListBox_Tabuada.Name = "ListBox_Tabuada";
            this.ListBox_Tabuada.Size = new System.Drawing.Size(301, 212);
            this.ListBox_Tabuada.TabIndex = 3;
            // 
            // BT_Limpar
            // 
            this.BT_Limpar.Location = new System.Drawing.Point(347, 151);
            this.BT_Limpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BT_Limpar.Name = "BT_Limpar";
            this.BT_Limpar.Size = new System.Drawing.Size(172, 58);
            this.BT_Limpar.TabIndex = 4;
            this.BT_Limpar.Text = "Limpar";
            this.BT_Limpar.UseVisualStyleBackColor = true;
            this.BT_Limpar.Click += new System.EventHandler(this.BT_Limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 338);
            this.Controls.Add(this.BT_Limpar);
            this.Controls.Add(this.ListBox_Tabuada);
            this.Controls.Add(this.TB_N);
            this.Controls.Add(this.BT_Calcular);
            this.Controls.Add(this.LB_01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_01;
        private System.Windows.Forms.Button BT_Calcular;
        private System.Windows.Forms.TextBox TB_N;
        private System.Windows.Forms.ListBox ListBox_Tabuada;
        private System.Windows.Forms.Button BT_Limpar;
    }
}

