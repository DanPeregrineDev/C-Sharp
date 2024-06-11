namespace Check_Radio
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
            this.TB_NAME = new System.Windows.Forms.TextBox();
            this.LB_02 = new System.Windows.Forms.Label();
            this.NUD_AGE = new System.Windows.Forms.NumericUpDown();
            this.LB_03 = new System.Windows.Forms.Label();
            this.RB_ACTIVE = new System.Windows.Forms.RadioButton();
            this.RB_BLOCKED = new System.Windows.Forms.RadioButton();
            this.LB_04 = new System.Windows.Forms.Label();
            this.CB_ADMINISTRATOR = new System.Windows.Forms.CheckBox();
            this.CB_CLIENT = new System.Windows.Forms.CheckBox();
            this.CB_MANAGER = new System.Windows.Forms.CheckBox();
            this.BT_CLEAN = new System.Windows.Forms.Button();
            this.BT_VALIDATE = new System.Windows.Forms.Button();
            this.LB_MESSAGE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_AGE)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_01
            // 
            this.LB_01.AutoSize = true;
            this.LB_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_01.Location = new System.Drawing.Point(25, 22);
            this.LB_01.Name = "LB_01";
            this.LB_01.Size = new System.Drawing.Size(77, 26);
            this.LB_01.TabIndex = 0;
            this.LB_01.Text = "Nome:";
            // 
            // TB_NAME
            // 
            this.TB_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NAME.Location = new System.Drawing.Point(108, 19);
            this.TB_NAME.MaxLength = 15;
            this.TB_NAME.Name = "TB_NAME";
            this.TB_NAME.Size = new System.Drawing.Size(305, 32);
            this.TB_NAME.TabIndex = 1;
            // 
            // LB_02
            // 
            this.LB_02.AutoSize = true;
            this.LB_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_02.Location = new System.Drawing.Point(25, 100);
            this.LB_02.Name = "LB_02";
            this.LB_02.Size = new System.Drawing.Size(72, 26);
            this.LB_02.TabIndex = 2;
            this.LB_02.Text = "Idade:";
            // 
            // NUD_AGE
            // 
            this.NUD_AGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_AGE.Location = new System.Drawing.Point(108, 98);
            this.NUD_AGE.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.NUD_AGE.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.NUD_AGE.Name = "NUD_AGE";
            this.NUD_AGE.Size = new System.Drawing.Size(115, 32);
            this.NUD_AGE.TabIndex = 3;
            this.NUD_AGE.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // LB_03
            // 
            this.LB_03.AutoSize = true;
            this.LB_03.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_03.Location = new System.Drawing.Point(25, 178);
            this.LB_03.Name = "LB_03";
            this.LB_03.Size = new System.Drawing.Size(86, 26);
            this.LB_03.TabIndex = 4;
            this.LB_03.Text = "Estado:";
            // 
            // RB_ACTIVE
            // 
            this.RB_ACTIVE.AutoSize = true;
            this.RB_ACTIVE.Checked = true;
            this.RB_ACTIVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_ACTIVE.Location = new System.Drawing.Point(117, 178);
            this.RB_ACTIVE.Name = "RB_ACTIVE";
            this.RB_ACTIVE.Size = new System.Drawing.Size(79, 30);
            this.RB_ACTIVE.TabIndex = 5;
            this.RB_ACTIVE.TabStop = true;
            this.RB_ACTIVE.Text = "Ativo";
            this.RB_ACTIVE.UseVisualStyleBackColor = true;
            // 
            // RB_BLOCKED
            // 
            this.RB_BLOCKED.AutoSize = true;
            this.RB_BLOCKED.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_BLOCKED.Location = new System.Drawing.Point(202, 178);
            this.RB_BLOCKED.Name = "RB_BLOCKED";
            this.RB_BLOCKED.Size = new System.Drawing.Size(134, 30);
            this.RB_BLOCKED.TabIndex = 6;
            this.RB_BLOCKED.TabStop = true;
            this.RB_BLOCKED.Text = "Bloqueado";
            this.RB_BLOCKED.UseVisualStyleBackColor = true;
            // 
            // LB_04
            // 
            this.LB_04.AutoSize = true;
            this.LB_04.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_04.Location = new System.Drawing.Point(25, 253);
            this.LB_04.Name = "LB_04";
            this.LB_04.Size = new System.Drawing.Size(191, 26);
            this.LB_04.TabIndex = 7;
            this.LB_04.Text = "Perfil de utilizador:";
            // 
            // CB_ADMINISTRATOR
            // 
            this.CB_ADMINISTRATOR.AutoSize = true;
            this.CB_ADMINISTRATOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ADMINISTRATOR.Location = new System.Drawing.Point(429, 253);
            this.CB_ADMINISTRATOR.Name = "CB_ADMINISTRATOR";
            this.CB_ADMINISTRATOR.Size = new System.Drawing.Size(166, 30);
            this.CB_ADMINISTRATOR.TabIndex = 8;
            this.CB_ADMINISTRATOR.Text = "Administrador";
            this.CB_ADMINISTRATOR.UseVisualStyleBackColor = true;
            // 
            // CB_CLIENT
            // 
            this.CB_CLIENT.AutoSize = true;
            this.CB_CLIENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_CLIENT.Location = new System.Drawing.Point(222, 253);
            this.CB_CLIENT.Name = "CB_CLIENT";
            this.CB_CLIENT.Size = new System.Drawing.Size(99, 30);
            this.CB_CLIENT.TabIndex = 9;
            this.CB_CLIENT.Text = "Cliente";
            this.CB_CLIENT.UseVisualStyleBackColor = true;
            // 
            // CB_MANAGER
            // 
            this.CB_MANAGER.AutoSize = true;
            this.CB_MANAGER.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_MANAGER.Location = new System.Drawing.Point(327, 253);
            this.CB_MANAGER.Name = "CB_MANAGER";
            this.CB_MANAGER.Size = new System.Drawing.Size(96, 30);
            this.CB_MANAGER.TabIndex = 10;
            this.CB_MANAGER.Text = "Gestor";
            this.CB_MANAGER.UseVisualStyleBackColor = true;
            // 
            // BT_CLEAN
            // 
            this.BT_CLEAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CLEAN.Location = new System.Drawing.Point(30, 455);
            this.BT_CLEAN.Name = "BT_CLEAN";
            this.BT_CLEAN.Size = new System.Drawing.Size(246, 75);
            this.BT_CLEAN.TabIndex = 11;
            this.BT_CLEAN.Text = "Limpar";
            this.BT_CLEAN.UseVisualStyleBackColor = true;
            this.BT_CLEAN.Click += new System.EventHandler(this.BT_CLEAN_Click);
            // 
            // BT_VALIDATE
            // 
            this.BT_VALIDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_VALIDATE.Location = new System.Drawing.Point(339, 455);
            this.BT_VALIDATE.Name = "BT_VALIDATE";
            this.BT_VALIDATE.Size = new System.Drawing.Size(243, 75);
            this.BT_VALIDATE.TabIndex = 12;
            this.BT_VALIDATE.Text = "Validar";
            this.BT_VALIDATE.UseVisualStyleBackColor = true;
            this.BT_VALIDATE.Click += new System.EventHandler(this.BT_VALIDATE_Click);
            // 
            // LB_MESSAGE
            // 
            this.LB_MESSAGE.AutoEllipsis = true;
            this.LB_MESSAGE.AutoSize = true;
            this.LB_MESSAGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MESSAGE.Location = new System.Drawing.Point(25, 327);
            this.LB_MESSAGE.Name = "LB_MESSAGE";
            this.LB_MESSAGE.Size = new System.Drawing.Size(0, 26);
            this.LB_MESSAGE.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 561);
            this.Controls.Add(this.LB_MESSAGE);
            this.Controls.Add(this.BT_VALIDATE);
            this.Controls.Add(this.BT_CLEAN);
            this.Controls.Add(this.CB_MANAGER);
            this.Controls.Add(this.CB_CLIENT);
            this.Controls.Add(this.CB_ADMINISTRATOR);
            this.Controls.Add(this.LB_04);
            this.Controls.Add(this.RB_BLOCKED);
            this.Controls.Add(this.RB_ACTIVE);
            this.Controls.Add(this.LB_03);
            this.Controls.Add(this.NUD_AGE);
            this.Controls.Add(this.LB_02);
            this.Controls.Add(this.TB_NAME);
            this.Controls.Add(this.LB_01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_AGE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_01;
        private System.Windows.Forms.TextBox TB_NAME;
        private System.Windows.Forms.Label LB_02;
        private System.Windows.Forms.NumericUpDown NUD_AGE;
        private System.Windows.Forms.Label LB_03;
        private System.Windows.Forms.RadioButton RB_ACTIVE;
        private System.Windows.Forms.RadioButton RB_BLOCKED;
        private System.Windows.Forms.Label LB_04;
        private System.Windows.Forms.CheckBox CB_ADMINISTRATOR;
        private System.Windows.Forms.CheckBox CB_CLIENT;
        private System.Windows.Forms.CheckBox CB_MANAGER;
        private System.Windows.Forms.Button BT_CLEAN;
        private System.Windows.Forms.Button BT_VALIDATE;
        private System.Windows.Forms.Label LB_MESSAGE;
    }
}

