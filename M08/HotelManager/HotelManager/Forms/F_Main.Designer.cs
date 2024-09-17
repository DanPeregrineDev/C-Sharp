namespace HotelManager
{
    partial class F_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Main));
            this.BT_AppClose = new System.Windows.Forms.Button();
            this.BT_AppMinimize = new System.Windows.Forms.Button();
            this.LB_AppTitle = new System.Windows.Forms.Label();
            this.LBX_AvailableRooms = new System.Windows.Forms.ListBox();
            this.LB_AvailableCount = new System.Windows.Forms.Label();
            this.LBX_OccupiedRooms = new System.Windows.Forms.ListBox();
            this.LB_OccupiedCount = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.adicionarQuartoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerQuartoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocuparQuartoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desocuparQuartoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BT_UnoccupyRoom = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.UpdateCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.LB_Time = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_AppClose
            // 
            this.BT_AppClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BT_AppClose.FlatAppearance.BorderSize = 0;
            this.BT_AppClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BT_AppClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_AppClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AppClose.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_AppClose.Location = new System.Drawing.Point(780, -1);
            this.BT_AppClose.Name = "BT_AppClose";
            this.BT_AppClose.Size = new System.Drawing.Size(20, 22);
            this.BT_AppClose.TabIndex = 100;
            this.BT_AppClose.Text = "X";
            this.BT_AppClose.UseVisualStyleBackColor = false;
            this.BT_AppClose.Click += new System.EventHandler(this.BT_AppClose_Click);
            // 
            // BT_AppMinimize
            // 
            this.BT_AppMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BT_AppMinimize.FlatAppearance.BorderSize = 0;
            this.BT_AppMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BT_AppMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_AppMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_AppMinimize.Location = new System.Drawing.Point(754, 0);
            this.BT_AppMinimize.Name = "BT_AppMinimize";
            this.BT_AppMinimize.Size = new System.Drawing.Size(20, 22);
            this.BT_AppMinimize.TabIndex = 2;
            this.BT_AppMinimize.Text = "—";
            this.BT_AppMinimize.UseVisualStyleBackColor = false;
            this.BT_AppMinimize.Click += new System.EventHandler(this.BT_AppMinimize_Click);
            // 
            // LB_AppTitle
            // 
            this.LB_AppTitle.AutoSize = true;
            this.LB_AppTitle.BackColor = System.Drawing.Color.Black;
            this.LB_AppTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AppTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.LB_AppTitle.Location = new System.Drawing.Point(12, 6);
            this.LB_AppTitle.Name = "LB_AppTitle";
            this.LB_AppTitle.Size = new System.Drawing.Size(110, 18);
            this.LB_AppTitle.TabIndex = 3;
            this.LB_AppTitle.Text = "Hotel Manager";
            // 
            // LBX_AvailableRooms
            // 
            this.LBX_AvailableRooms.BackColor = System.Drawing.Color.Black;
            this.LBX_AvailableRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBX_AvailableRooms.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBX_AvailableRooms.ForeColor = System.Drawing.SystemColors.Control;
            this.LBX_AvailableRooms.FormattingEnabled = true;
            this.LBX_AvailableRooms.ItemHeight = 18;
            this.LBX_AvailableRooms.Location = new System.Drawing.Point(17, 67);
            this.LBX_AvailableRooms.Name = "LBX_AvailableRooms";
            this.LBX_AvailableRooms.Size = new System.Drawing.Size(175, 396);
            this.LBX_AvailableRooms.Sorted = true;
            this.LBX_AvailableRooms.TabIndex = 4;
            // 
            // LB_AvailableCount
            // 
            this.LB_AvailableCount.AutoSize = true;
            this.LB_AvailableCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LB_AvailableCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AvailableCount.ForeColor = System.Drawing.SystemColors.Control;
            this.LB_AvailableCount.Location = new System.Drawing.Point(14, 46);
            this.LB_AvailableCount.Name = "LB_AvailableCount";
            this.LB_AvailableCount.Size = new System.Drawing.Size(152, 18);
            this.LB_AvailableCount.TabIndex = 6;
            this.LB_AvailableCount.Text = "Quartos Disponíveis:";
            // 
            // LBX_OccupiedRooms
            // 
            this.LBX_OccupiedRooms.BackColor = System.Drawing.Color.Black;
            this.LBX_OccupiedRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBX_OccupiedRooms.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBX_OccupiedRooms.ForeColor = System.Drawing.SystemColors.Control;
            this.LBX_OccupiedRooms.FormattingEnabled = true;
            this.LBX_OccupiedRooms.ItemHeight = 18;
            this.LBX_OccupiedRooms.Location = new System.Drawing.Point(607, 67);
            this.LBX_OccupiedRooms.Name = "LBX_OccupiedRooms";
            this.LBX_OccupiedRooms.Size = new System.Drawing.Size(175, 396);
            this.LBX_OccupiedRooms.Sorted = true;
            this.LBX_OccupiedRooms.TabIndex = 8;
            // 
            // LB_OccupiedCount
            // 
            this.LB_OccupiedCount.AutoSize = true;
            this.LB_OccupiedCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LB_OccupiedCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_OccupiedCount.ForeColor = System.Drawing.SystemColors.Control;
            this.LB_OccupiedCount.Location = new System.Drawing.Point(602, 41);
            this.LB_OccupiedCount.Name = "LB_OccupiedCount";
            this.LB_OccupiedCount.Size = new System.Drawing.Size(143, 18);
            this.LB_OccupiedCount.TabIndex = 9;
            this.LB_OccupiedCount.Text = "Quartos Ocupados:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarQuartoToolStripMenuItem,
            this.removerQuartoToolStripMenuItem,
            this.ocuparQuartoToolStripMenuItem,
            this.desocuparQuartoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.Black;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton1.Text = "Quartos";
            // 
            // adicionarQuartoToolStripMenuItem
            // 
            this.adicionarQuartoToolStripMenuItem.Name = "adicionarQuartoToolStripMenuItem";
            this.adicionarQuartoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.adicionarQuartoToolStripMenuItem.Text = "Adicionar Quarto";
            this.adicionarQuartoToolStripMenuItem.Click += new System.EventHandler(this.adicionarQuartoToolStripMenuItem_Click);
            // 
            // removerQuartoToolStripMenuItem
            // 
            this.removerQuartoToolStripMenuItem.Name = "removerQuartoToolStripMenuItem";
            this.removerQuartoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.removerQuartoToolStripMenuItem.Text = "Remover Quarto";
            this.removerQuartoToolStripMenuItem.Click += new System.EventHandler(this.removerQuartoToolStripMenuItem_Click);
            // 
            // ocuparQuartoToolStripMenuItem
            // 
            this.ocuparQuartoToolStripMenuItem.Name = "ocuparQuartoToolStripMenuItem";
            this.ocuparQuartoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.ocuparQuartoToolStripMenuItem.Text = "Ocupar Quarto";
            this.ocuparQuartoToolStripMenuItem.Click += new System.EventHandler(this.ocuparQuartoToolStripMenuItem_Click);
            // 
            // desocuparQuartoToolStripMenuItem
            // 
            this.desocuparQuartoToolStripMenuItem.Name = "desocuparQuartoToolStripMenuItem";
            this.desocuparQuartoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.desocuparQuartoToolStripMenuItem.Text = "Desocupar Quarto";
            this.desocuparQuartoToolStripMenuItem.Click += new System.EventHandler(this.desocuparQuartoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.BT_AppClose_Click);
            // 
            // BT_UnoccupyRoom
            // 
            this.BT_UnoccupyRoom.BackColor = System.Drawing.Color.Black;
            this.BT_UnoccupyRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BT_UnoccupyRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_UnoccupyRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_UnoccupyRoom.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_UnoccupyRoom.Location = new System.Drawing.Point(425, 412);
            this.BT_UnoccupyRoom.Name = "BT_UnoccupyRoom";
            this.BT_UnoccupyRoom.Size = new System.Drawing.Size(175, 50);
            this.BT_UnoccupyRoom.TabIndex = 10;
            this.BT_UnoccupyRoom.Text = "Desocupar Quarto";
            this.BT_UnoccupyRoom.UseVisualStyleBackColor = false;
            this.BT_UnoccupyRoom.Click += new System.EventHandler(this.desocuparQuartoToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(198, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 50);
            this.button1.TabIndex = 101;
            this.button1.Text = "Remover Quarto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.removerQuartoToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(198, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 50);
            this.button2.TabIndex = 102;
            this.button2.Text = "Ocupar Quarto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ocuparQuartoToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(198, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 50);
            this.button3.TabIndex = 103;
            this.button3.Text = "Adicionar Quarto";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.adicionarQuartoToolStripMenuItem_Click);
            // 
            // UpdateCurrentTime
            // 
            this.UpdateCurrentTime.Enabled = true;
            this.UpdateCurrentTime.Tick += new System.EventHandler(this.UpdateCurrentTime_Tick);
            // 
            // LB_Time
            // 
            this.LB_Time.AutoSize = true;
            this.LB_Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LB_Time.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Time.ForeColor = System.Drawing.SystemColors.Control;
            this.LB_Time.Location = new System.Drawing.Point(375, 46);
            this.LB_Time.Name = "LB_Time";
            this.LB_Time.Size = new System.Drawing.Size(48, 18);
            this.LB_Time.TabIndex = 104;
            this.LB_Time.Text = "09:30";
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.LB_Time);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BT_AppMinimize);
            this.Controls.Add(this.BT_AppClose);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BT_UnoccupyRoom);
            this.Controls.Add(this.LB_OccupiedCount);
            this.Controls.Add(this.LBX_OccupiedRooms);
            this.Controls.Add(this.LB_AvailableCount);
            this.Controls.Add(this.LBX_AvailableRooms);
            this.Controls.Add(this.LB_AppTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Manager";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BT_AppClose;
        private System.Windows.Forms.Button BT_AppMinimize;
        private System.Windows.Forms.Label LB_AppTitle;
        public System.Windows.Forms.ListBox LBX_AvailableRooms;
        private System.Windows.Forms.Label LB_AvailableCount;
        public System.Windows.Forms.ListBox LBX_OccupiedRooms;
        private System.Windows.Forms.Label LB_OccupiedCount;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem adicionarQuartoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerQuartoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocuparQuartoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desocuparQuartoToolStripMenuItem;
        private System.Windows.Forms.Button BT_UnoccupyRoom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer UpdateCurrentTime;
        private System.Windows.Forms.Label LB_Time;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

