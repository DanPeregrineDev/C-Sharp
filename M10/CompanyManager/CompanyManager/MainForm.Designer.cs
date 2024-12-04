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
        DG_01 = new System.Windows.Forms.DataGridView();
        BT_ViewEdit = new System.Windows.Forms.Button();
        BT_New = new System.Windows.Forms.Button();
        BT_Remove = new System.Windows.Forms.Button();
        BT_Exit = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)DG_01).BeginInit();
        SuspendLayout();
        // 
        // DG_01
        // 
        DG_01.BackgroundColor = System.Drawing.SystemColors.ControlLight;
        DG_01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DG_01.Location = new System.Drawing.Point(12, 12);
        DG_01.Name = "DG_01";
        DG_01.Size = new System.Drawing.Size(828, 449);
        DG_01.TabIndex = 0;
        // 
        // BT_ViewEdit
        // 
        BT_ViewEdit.Location = new System.Drawing.Point(846, 12);
        BT_ViewEdit.Name = "BT_ViewEdit";
        BT_ViewEdit.Size = new System.Drawing.Size(150, 30);
        BT_ViewEdit.TabIndex = 1;
        BT_ViewEdit.Text = "View Edit";
        BT_ViewEdit.UseVisualStyleBackColor = true;
        // 
        // BT_New
        // 
        BT_New.Location = new System.Drawing.Point(846, 48);
        BT_New.Name = "BT_New";
        BT_New.Size = new System.Drawing.Size(150, 30);
        BT_New.TabIndex = 2;
        BT_New.Text = "New";
        BT_New.UseVisualStyleBackColor = true;
        // 
        // BT_Remove
        // 
        BT_Remove.Location = new System.Drawing.Point(846, 84);
        BT_Remove.Name = "BT_Remove";
        BT_Remove.Size = new System.Drawing.Size(150, 30);
        BT_Remove.TabIndex = 3;
        BT_Remove.Text = "Remove";
        BT_Remove.UseVisualStyleBackColor = true;
        // 
        // BT_Exit
        // 
        BT_Exit.Location = new System.Drawing.Point(846, 431);
        BT_Exit.Name = "BT_Exit";
        BT_Exit.Size = new System.Drawing.Size(150, 30);
        BT_Exit.TabIndex = 4;
        BT_Exit.Text = "Exit";
        BT_Exit.UseVisualStyleBackColor = true;
        BT_Exit.Click += BT_Exit_Click;
        // 
        // CompanyManager
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1008, 473);
        Controls.Add(BT_Exit);
        Controls.Add(BT_Remove);
        Controls.Add(BT_New);
        Controls.Add(BT_ViewEdit);
        Controls.Add(DG_01);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        ShowIcon = false;
        Text = "Company Manager";
        Load += CompanyManager_Load;
        ((System.ComponentModel.ISupportInitialize)DG_01).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.DataGridView DG_01;
    private Button BT_ViewEdit;
    private Button BT_New;
    private Button BT_Remove;
    private System.Windows.Forms.Button BT_Exit;
}