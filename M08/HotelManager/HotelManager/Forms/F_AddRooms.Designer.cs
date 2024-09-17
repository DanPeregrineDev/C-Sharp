namespace HotelManager.Forms
{
    partial class F_AddRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_AddRooms));
            this.TB_RoomNumber = new System.Windows.Forms.TextBox();
            this.LB_01 = new System.Windows.Forms.Label();
            this.BT_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_RoomNumber
            // 
            this.TB_RoomNumber.BackColor = System.Drawing.Color.Black;
            this.TB_RoomNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_RoomNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.TB_RoomNumber.Location = new System.Drawing.Point(228, 44);
            this.TB_RoomNumber.MaxLength = 4;
            this.TB_RoomNumber.Name = "TB_RoomNumber";
            this.TB_RoomNumber.Size = new System.Drawing.Size(175, 26);
            this.TB_RoomNumber.TabIndex = 0;
            this.TB_RoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LB_01
            // 
            this.LB_01.AutoSize = true;
            this.LB_01.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_01.ForeColor = System.Drawing.SystemColors.Control;
            this.LB_01.Location = new System.Drawing.Point(13, 36);
            this.LB_01.Name = "LB_01";
            this.LB_01.Size = new System.Drawing.Size(200, 36);
            this.LB_01.TabIndex = 1;
            this.LB_01.Text = "Nº do quarto:";
            // 
            // BT_Add
            // 
            this.BT_Add.BackColor = System.Drawing.Color.Black;
            this.BT_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BT_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Add.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_Add.Location = new System.Drawing.Point(21, 90);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(382, 40);
            this.BT_Add.TabIndex = 2;
            this.BT_Add.Text = "Adicionar";
            this.BT_Add.UseVisualStyleBackColor = false;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // F_AddRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(434, 161);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.LB_01);
            this.Controls.Add(this.TB_RoomNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_AddRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Quarto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_RoomNumber;
        private System.Windows.Forms.Label LB_01;
        private System.Windows.Forms.Button BT_Add;
    }
}