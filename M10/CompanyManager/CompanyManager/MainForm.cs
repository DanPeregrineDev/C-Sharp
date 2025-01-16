using System.Text.RegularExpressions;

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

    private Employee GetCurrentDataRow()
    {
        if (DG_01.SelectedRows.Count > 0)
        {
            return (Employee)DG_01.CurrentRow.DataBoundItem;
        }
        else
        {
            return null;
        }
    }

    private void BT_ViewEdit_Click(object sender, EventArgs e)
    {
        if (DG_01.Rows.Count == 0)
        {
            MessageBox.Show("Nenhum empregado na lista de dados", Company.appName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            return;
        }
        
        Employee data = GetCurrentDataRow();

        if (data != null)
        {
            int i = Company.employees.IndexOf(data);
            
            EmployeeForm form = new EmployeeForm((Employee)Company.employees[i].Clone());
            
            DialogResult dr = form.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Company.employees[i] = form.employee;
                MessageBox.Show("Empregado atualizado com sucesso", Company.appName);
            }
        }
        else
        {
            MessageBox.Show("Não existe o empregado na lista", Company.appName);
        }
    }

    private void BT_New_Click(object sender, EventArgs e)
    {
        EmployeeForm form = new EmployeeForm(null);
        DialogResult result = form.ShowDialog();

        if (result == DialogResult.OK)
        {
            Company.employees.Add(form.employee);
            MessageBox.Show("Empregado criado com sucesso", Company.appName);
        }
    }

    private void BT_Remove_Click(object sender, EventArgs e)
    {
        if (DG_01.Rows.Count > 0)
        {
            Employee data = GetCurrentDataRow();
            int position = Company.employees.IndexOf(data);

            if (position < 0)
            {
                MessageBox.Show("Empregado não encontrado", Company.appName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            DialogResult dr = MessageBox.Show($"Deseja remover o {data.GetRole()} ao {data.Name}?", Company.appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Company.employees.RemoveAt(position);
            }

            if (DG_01.Rows.Count > 0 && DG_01.SelectedRows.Count == 0)
            {
                DG_01.Rows[DG_01.Rows.Count - 1].Selected = true;
            }
        }
    }
}