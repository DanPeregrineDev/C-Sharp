namespace HotelManager.Forms
{
    partial class F_UnoccupyRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_UnoccupyRoom));
            this.CB_Rooms = new System.Windows.Forms.ComboBox();
            this.LB_01 = new System.Windows.Forms.Label();
            this.BT_Unoccupy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB_Rooms
            // 
            this.CB_Rooms.BackColor = System.Drawing.Color.Black;
            this.CB_Rooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Rooms.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Rooms.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_Rooms.FormattingEnabled = true;
            this.CB_Rooms.Location = new System.Drawing.Point(230, 40);
            this.CB_Rooms.Name = "CB_Rooms";
            this.CB_Rooms.Size = new System.Drawing.Size(175, 26);
            this.CB_Rooms.TabIndex = 9;
            // 
            // LB_01
            // 
            this.LB_01.AutoSize = true;
            this.LB_01.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_01.ForeColor = System.Drawing.SystemColors.Control;
            this.LB_01.Location = new System.Drawing.Point(15, 33);
            this.LB_01.Name = "LB_01";
            this.LB_01.Size = new System.Drawing.Size(200, 36);
            this.LB_01.TabIndex = 8;
            this.LB_01.Text = "Nº do quarto:";
            // 
            // BT_Unoccupy
            // 
            this.BT_Unoccupy.BackColor = System.Drawing.Color.Black;
            this.BT_Unoccupy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BT_Unoccupy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Unoccupy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Unoccupy.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_Unoccupy.Location = new System.Drawing.Point(21, 100);
            this.BT_Unoccupy.Name = "BT_Unoccupy";
            this.BT_Unoccupy.Size = new System.Drawing.Size(384, 40);
            this.BT_Unoccupy.TabIndex = 10;
            this.BT_Unoccupy.Text = "Desocupar";
            this.BT_Unoccupy.UseVisualStyleBackColor = false;
            this.BT_Unoccupy.Click += new System.EventHandler(this.BT_Unoccupy_Click);
            // 
            // F_UnoccupyRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(434, 171);
            this.Controls.Add(this.BT_Unoccupy);
            this.Controls.Add(this.CB_Rooms);
            this.Controls.Add(this.LB_01);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_UnoccupyRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desocupar Quarto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Rooms;
        private System.Windows.Forms.Label LB_01;
        private System.Windows.Forms.Button BT_Unoccupy;
    }
}