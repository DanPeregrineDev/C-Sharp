namespace HotelManager.Forms
{
    partial class F_OccupyRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_OccupyRoom));
            this.LB_01 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_OccupantName = new System.Windows.Forms.TextBox();
            this.BT_Add = new System.Windows.Forms.Button();
            this.CB_Rooms = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LB_01
            // 
            this.LB_01.AutoSize = true;
            this.LB_01.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_01.ForeColor = System.Drawing.SystemColors.Control;
            this.LB_01.Location = new System.Drawing.Point(20, 34);
            this.LB_01.Name = "LB_01";
            this.LB_01.Size = new System.Drawing.Size(200, 36);
            this.LB_01.TabIndex = 3;
            this.LB_01.Text = "Nº do quarto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(20, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome do ocupante:";
            // 
            // TB_OccupantName
            // 
            this.TB_OccupantName.BackColor = System.Drawing.Color.Black;
            this.TB_OccupantName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_OccupantName.ForeColor = System.Drawing.SystemColors.Control;
            this.TB_OccupantName.Location = new System.Drawing.Point(28, 151);
            this.TB_OccupantName.MaxLength = 64;
            this.TB_OccupantName.Name = "TB_OccupantName";
            this.TB_OccupantName.Size = new System.Drawing.Size(382, 26);
            this.TB_OccupantName.TabIndex = 5;
            this.TB_OccupantName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BT_Add
            // 
            this.BT_Add.BackColor = System.Drawing.Color.Black;
            this.BT_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BT_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Add.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_Add.Location = new System.Drawing.Point(28, 225);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(382, 40);
            this.BT_Add.TabIndex = 6;
            this.BT_Add.Text = "Concluir";
            this.BT_Add.UseVisualStyleBackColor = false;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // CB_Rooms
            // 
            this.CB_Rooms.BackColor = System.Drawing.Color.Black;
            this.CB_Rooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Rooms.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Rooms.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_Rooms.FormattingEnabled = true;
            this.CB_Rooms.Location = new System.Drawing.Point(235, 41);
            this.CB_Rooms.Name = "CB_Rooms";
            this.CB_Rooms.Size = new System.Drawing.Size(175, 26);
            this.CB_Rooms.TabIndex = 7;
            // 
            // F_OccupyRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(434, 286);
            this.Controls.Add(this.CB_Rooms);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.TB_OccupantName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_OccupyRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ocupar Quarto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_OccupantName;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.ComboBox CB_Rooms;
    }
}