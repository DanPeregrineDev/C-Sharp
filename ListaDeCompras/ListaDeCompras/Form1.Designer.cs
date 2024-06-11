namespace ListaDeCompras
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
            this.GroceryList = new System.Windows.Forms.ListBox();
            this.BT_ADD = new System.Windows.Forms.Button();
            this.BT_DELETE_LIST = new System.Windows.Forms.Button();
            this.LB_TOTAL = new System.Windows.Forms.Label();
            this.TB_ITEM_NAME = new System.Windows.Forms.TextBox();
            this.NUD_PRICE = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NUD_QUANTITY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PRICE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_QUANTITY)).BeginInit();
            this.SuspendLayout();
            // 
            // GroceryList
            // 
            this.GroceryList.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroceryList.FormattingEnabled = true;
            this.GroceryList.ItemHeight = 29;
            this.GroceryList.Location = new System.Drawing.Point(12, 47);
            this.GroceryList.Name = "GroceryList";
            this.GroceryList.Size = new System.Drawing.Size(228, 236);
            this.GroceryList.TabIndex = 0;
            // 
            // BT_ADD
            // 
            this.BT_ADD.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ADD.Location = new System.Drawing.Point(644, 39);
            this.BT_ADD.Name = "BT_ADD";
            this.BT_ADD.Size = new System.Drawing.Size(125, 50);
            this.BT_ADD.TabIndex = 1;
            this.BT_ADD.Text = "Adicionar";
            this.BT_ADD.UseVisualStyleBackColor = true;
            this.BT_ADD.Click += new System.EventHandler(this.BT_ADD_Click);
            // 
            // BT_DELETE_LIST
            // 
            this.BT_DELETE_LIST.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_DELETE_LIST.Location = new System.Drawing.Point(246, 108);
            this.BT_DELETE_LIST.Name = "BT_DELETE_LIST";
            this.BT_DELETE_LIST.Size = new System.Drawing.Size(201, 50);
            this.BT_DELETE_LIST.TabIndex = 2;
            this.BT_DELETE_LIST.Text = "Apagar Lista";
            this.BT_DELETE_LIST.UseVisualStyleBackColor = true;
            this.BT_DELETE_LIST.Click += new System.EventHandler(this.BT_REMOVE_Click);
            // 
            // LB_TOTAL
            // 
            this.LB_TOTAL.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LB_TOTAL.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TOTAL.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LB_TOTAL.Location = new System.Drawing.Point(303, 252);
            this.LB_TOTAL.Name = "LB_TOTAL";
            this.LB_TOTAL.Size = new System.Drawing.Size(117, 30);
            this.LB_TOTAL.TabIndex = 4;
            this.LB_TOTAL.Text = "0";
            this.LB_TOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_ITEM_NAME
            // 
            this.TB_ITEM_NAME.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ITEM_NAME.Location = new System.Drawing.Point(246, 47);
            this.TB_ITEM_NAME.Name = "TB_ITEM_NAME";
            this.TB_ITEM_NAME.Size = new System.Drawing.Size(125, 36);
            this.TB_ITEM_NAME.TabIndex = 5;
            // 
            // NUD_PRICE
            // 
            this.NUD_PRICE.DecimalPlaces = 2;
            this.NUD_PRICE.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_PRICE.Location = new System.Drawing.Point(377, 48);
            this.NUD_PRICE.Name = "NUD_PRICE";
            this.NUD_PRICE.Size = new System.Drawing.Size(101, 36);
            this.NUD_PRICE.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome";
            // 
            // NUD_QUANTITY
            // 
            this.NUD_QUANTITY.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_QUANTITY.Location = new System.Drawing.Point(516, 47);
            this.NUD_QUANTITY.Name = "NUD_QUANTITY";
            this.NUD_QUANTITY.Size = new System.Drawing.Size(101, 36);
            this.NUD_QUANTITY.TabIndex = 10;
            this.NUD_QUANTITY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(506, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lista de compras";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(247, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 30);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(417, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "€";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 297);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NUD_QUANTITY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUD_PRICE);
            this.Controls.Add(this.TB_ITEM_NAME);
            this.Controls.Add(this.LB_TOTAL);
            this.Controls.Add(this.BT_DELETE_LIST);
            this.Controls.Add(this.BT_ADD);
            this.Controls.Add(this.GroceryList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Lista de Compras";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PRICE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_QUANTITY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox GroceryList;
        private System.Windows.Forms.Button BT_ADD;
        private System.Windows.Forms.Button BT_DELETE_LIST;
        private System.Windows.Forms.Label LB_TOTAL;
        private System.Windows.Forms.TextBox TB_ITEM_NAME;
        private System.Windows.Forms.NumericUpDown NUD_PRICE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUD_QUANTITY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

