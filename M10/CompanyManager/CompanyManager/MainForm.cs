namespace CompanyManager;

public partial class CompanyManager : Form
{
    public CompanyManager()
    {
        InitializeComponent();
    }

    private void CompanyManager_Load(object sender, EventArgs e)
    {
        Text = $"{Company.appName} - {Company.appVersion}";
        
        DG_01.DataSource = Company.employees;
        DG_01.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        DG_01.MultiSelect = false;
        DG_01.RowHeadersVisible = false;
        DG_01.ReadOnly = true;
        DG_01.AllowUserToAddRows = false;
        DG_01.AllowUserToDeleteRows = false;
        DG_01.AllowUserToResizeRows = false;
        DG_01.AllowUserToOrderColumns = false;

        for (int i = 4; i < DG_01.Columns.Count; i++)
        {
            DG_01.Columns[i].Visible = false;
        }
        
        DG_01.Columns["valueId"].HeaderText = "ID";
        DG_01.Columns["abreviatedName"].HeaderText = "Abreviated Name";

        DG_01.Columns["valueId"].Width = 50;
        
        DG_01.Columns["valueId"].DefaultCellStyle.BackColor = Color.LightBlue;
        DG_01.Columns["valueId"].DefaultCellStyle.Font = new Font("Nunito", 12, FontStyle.Bold);

        DG_01.Columns["AbreviatedName"].Width = 150;
        DG_01.Columns["Locality"].Width = 120;
        
        KeyPreview = true;
    }

    private void BT_Exit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}