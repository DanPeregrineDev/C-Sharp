namespace CompanyManager;

partial class CompanyManager
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        DG_01 = new DataGridView();
        BT_ViewEdit = new Button();
        BT_New = new Button();
        BT_Remove = new Button();
        BT_Exit = new Button();
        ((System.ComponentModel.ISupportInitialize)DG_01).BeginInit();
        SuspendLayout();
        // 
        // DG_01
        // 
        DG_01.BackgroundColor = SystemColors.ControlLight;
        DG_01.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DG_01.Location = new Point(12, 12);
        DG_01.Name = "DG_01";
        DG_01.Size = new Size(828, 449);
        DG_01.TabIndex = 0;
        // 
        // BT_ViewEdit
        // 
        BT_ViewEdit.Location = new Point(846, 12);
        BT_ViewEdit.Name = "BT_ViewEdit";
        BT_ViewEdit.Size = new Size(150, 30);
        BT_ViewEdit.TabIndex = 1;
        BT_ViewEdit.Text = "View Edit";
        BT_ViewEdit.UseVisualStyleBackColor = true;
        BT_ViewEdit.Click += BT_ViewEdit_Click;
        // 
        // BT_New
        // 
        BT_New.Location = new Point(846, 48);
        BT_New.Name = "BT_New";
        BT_New.Size = new Size(150, 30);
        BT_New.TabIndex = 2;
        BT_New.Text = "New";
        BT_New.UseVisualStyleBackColor = true;
        BT_New.Click += BT_New_Click;
        // 
        // BT_Remove
        // 
        BT_Remove.Location = new Point(846, 84);
        BT_Remove.Name = "BT_Remove";
        BT_Remove.Size = new Size(150, 30);
        BT_Remove.TabIndex = 3;
        BT_Remove.Text = "Remove";
        BT_Remove.UseVisualStyleBackColor = true;
        BT_Remove.Click += BT_Remove_Click;
        // 
        // BT_Exit
        // 
        BT_Exit.Location = new Point(846, 431);
        BT_Exit.Name = "BT_Exit";
        BT_Exit.Size = new Size(150, 30);
        BT_Exit.TabIndex = 4;
        BT_Exit.Text = "Exit";
        BT_Exit.UseVisualStyleBackColor = true;
        BT_Exit.Click += BT_Exit_Click;
        // 
        // CompanyManager
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1008, 473);
        Controls.Add(BT_Exit);
        Controls.Add(BT_Remove);
        Controls.Add(BT_New);
        Controls.Add(BT_ViewEdit);
        Controls.Add(DG_01);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "CompanyManager";
        ShowIcon = false;
        Text = "Company Manager";
        FormClosed += CompanyManager_FormClosed;
        Load += CompanyManager_Load;
        ((System.ComponentModel.ISupportInitialize)DG_01).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.DataGridView DG_01;
    private System.Windows.Forms.Button BT_ViewEdit;
    private System.Windows.Forms.Button BT_New;
    private System.Windows.Forms.Button BT_Remove;
    private System.Windows.Forms.Button BT_Exit;
}