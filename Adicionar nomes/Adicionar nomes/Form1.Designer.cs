namespace Adicionar_nomes
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
            this.TB_Nome = new System.Windows.Forms.TextBox();
            this.BT_Adicionar = new System.Windows.Forms.Button();
            this.CB_Nomes = new System.Windows.Forms.ComboBox();
            this.BT_Remover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_01
            // 
            this.LB_01.AutoSize = true;
            this.LB_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_01.Location = new System.Drawing.Point(25, 26);
            this.LB_01.Name = "LB_01";
            this.LB_01.Size = new System.Drawing.Size(71, 26);
            this.LB_01.TabIndex = 0;
            this.LB_01.Text = "Nome";
            // 
            // TB_Nome
            // 
            this.TB_Nome.Location = new System.Drawing.Point(102, 31);
            this.TB_Nome.MaxLength = 20;
            this.TB_Nome.Name = "TB_Nome";
            this.TB_Nome.Size = new System.Drawing.Size(150, 20);
            this.TB_Nome.TabIndex = 1;
            // 
            // BT_Adicionar
            // 
            this.BT_Adicionar.Location = new System.Drawing.Point(258, 30);
            this.BT_Adicionar.Name = "BT_Adicionar";
            this.BT_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.BT_Adicionar.TabIndex = 2;
            this.BT_Adicionar.Text = "Adicionar";
            this.BT_Adicionar.UseVisualStyleBackColor = true;
            this.BT_Adicionar.Click += new System.EventHandler(this.BT_Adicionar_Click);
            // 
            // CB_Nomes
            // 
            this.CB_Nomes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Nomes.FormattingEnabled = true;
            this.CB_Nomes.Location = new System.Drawing.Point(102, 57);
            this.CB_Nomes.Name = "CB_Nomes";
            this.CB_Nomes.Size = new System.Drawing.Size(150, 21);
            this.CB_Nomes.TabIndex = 3;
            // 
            // BT_Remover
            // 
            this.BT_Remover.Location = new System.Drawing.Point(258, 56);
            this.BT_Remover.Name = "BT_Remover";
            this.BT_Remover.Size = new System.Drawing.Size(75, 23);
            this.BT_Remover.TabIndex = 4;
            this.BT_Remover.Text = "Remover";
            this.BT_Remover.UseVisualStyleBackColor = true;
            this.BT_Remover.Click += new System.EventHandler(this.BT_Remover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 111);
            this.Controls.Add(this.BT_Remover);
            this.Controls.Add(this.CB_Nomes);
            this.Controls.Add(this.BT_Adicionar);
            this.Controls.Add(this.TB_Nome);
            this.Controls.Add(this.LB_01);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Lista de nomes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_01;
        private System.Windows.Forms.TextBox TB_Nome;
        private System.Windows.Forms.Button BT_Adicionar;
        private System.Windows.Forms.ComboBox CB_Nomes;
        private System.Windows.Forms.Button BT_Remover;
    }
}

