using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyManager
{
    public partial class EmployeeForm : Form
    {
        public Employee employee { get; private set; }

        public EmployeeForm(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;

            if (employee != null)
            {
                Text = "Verify / Edit Employee";

                CB_Edit.Enabled = true;
                CB_Edit.Checked = false;

                updateCheckEdit(false);
            }
            else
            {
                Text = "New Employee";

                CB_Edit.Enabled = false;
                CB_Edit.Checked = true;

                updateCheckEdit(true);
            }

            AcceptButton = BT_Ok;
            CancelButton = BT_Cancel;

            BT_Ok.DialogResult = DialogResult.OK;

            BT_Cancel.CausesValidation = false;
            BT_Cancel.DialogResult = DialogResult.Cancel;

            CB_Role.DataSource = Company.roles;

            CB_Role.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            if (employee is Analyst)
            {
                CB_Role.SelectedIndex = Company.ROLE_ANALYST;
            }
            else if (employee is Employee)
            {
                CB_Role.SelectedIndex = Company.ROLE_EMPLOYEE;
            }
            else if (employee is Programmer)
            {
                CB_Role.SelectedIndex = Company.ROLE_PROGRAMMER;
            }

            P_Analyst.Visible = (employee is Analyst || employee == null);
            P_Programmer.Visible = (employee is Programmer);

            if (employee != null)
            {
                TB_Name.Text = employee.Name;
                TB_ID.Text = employee.valueId.ToString();
                TB_Email.Text = employee.Email;
                TB_Phone.Text = employee.Phone;
                TB_Street.Text = employee.adress.Street;
                TB_PostalCode.Text = employee.adress.PostalCode;
                TB_Locality.Text = employee.adress.Locality;
                TB_Door.Text = employee.adress.Door;

                if (employee.Birthday != DateTime.Now)
                {
                    DTP_Birthdate.Value = DateTime.Now;
                }

                if (employee is Programmer)
                {
                    TB_ProjectProgrammer.Text = ((Programmer)(employee)).Project;
                }
                else if (employee is Analyst)
                {
                    TB_ProjectAnalyst.Text = ((Analyst)(employee)).Speciality;
                }
            }
        }

        public void updateCheckEdit(bool check)
        {
            CB_Role.Enabled = check;
            TB_PostalCode.Enabled = check;
            DTP_Birthdate.Enabled = check;

            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = check;
                }
            }

            foreach (Control c in P_Analyst.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = check;
                }
            }

            foreach (Control c in P_Programmer.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = check;
                }
            }

            foreach (Control c in GB_Address.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = check;
                }
            }

            TB_ID.Enabled = false;
        }

        private void BT_Ok_Click(object sender, EventArgs e)
        {
            if (CB_Role.SelectedIndex == Company.ROLE_ANALYST)
            {
                if ((employee == null) || (employee is Analyst))
                {
                    employee = new Analyst(TB_Name.Text, TB_Email.Text, TB_Phone.Text, new Adress(TB_Street.Text, TB_Door.Text, TB_Locality.Text, TB_PostalCode.Text), DTP_Birthdate.Value, TB_ProjectAnalyst.Text);
                }
            }
            else if (CB_Role.SelectedIndex == Company.ROLE_PROGRAMMER)
            {
                if ((employee == null) || (employee is Programmer))
                {
                    employee = new Programmer(TB_Name.Text, TB_Email.Text, TB_Phone.Text, new Adress(TB_Street.Text, TB_Door.Text, TB_Locality.Text, TB_PostalCode.Text), DTP_Birthdate.Value, TB_ProjectProgrammer.Text);
                }
            }
            else
            {
                if ((employee == null) || (employee is Analyst) || (employee is Programmer))
                {
                    employee = new Employee(TB_Name.Text, TB_Email.Text, TB_Phone.Text, new Adress(TB_Street.Text, TB_Door.Text, TB_Locality.Text, TB_PostalCode.Text), DTP_Birthdate.Value);
                }
            }

            updateDataEmployee();
        }

        private void updateDataEmployee()
        {
            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
                return;
            }

            if (employee == null)
            {
                return;
            }

            employee.Name = TB_Name.Text;
            employee.Email = TB_Email.Text;
            employee.Phone = TB_Phone.Text;
            employee.adress = new Adress(TB_Street.Text, TB_Door.Text, TB_Locality.Text, TB_PostalCode.Text);
            employee.Birthday = DTP_Birthdate.Value;

            if (employee is Analyst)
            {
                ((Analyst)employee).Speciality = TB_ProjectAnalyst.Text;
            }

            if (employee is Programmer)
            {
                ((Programmer)employee).Project = TB_ProjectProgrammer.Text;
            }
        }


        private void CB_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Role.SelectedIndex == Company.ROLE_ANALYST)
            {
                P_Analyst.Visible = true;
                P_Programmer.Visible = false;
            }
            else if (CB_Role.SelectedIndex == Company.ROLE_PROGRAMMER)
            {
                P_Analyst.Visible = false;
                P_Programmer.Visible = true;
            }
            else
            {
                P_Analyst.Visible = false;
                P_Programmer.Visible = false;
            }
        }

        private void CB_Edit_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckEdit(CB_Edit.Checked);
        }

        private void TB_Name_Validating(object sender, CancelEventArgs e)
        {
            if (!Employee.isValidName(TB_Name.Text))
            {
                e.Cancel = true;
                EP_VerifyName.SetError(TB_Name, "Invalid name. it should contain at least 2 words and a minimum of 7 characters");
            }
            else
            {
                EP_VerifyName = null;
            }
        }

        private void TB_Email_Validating(object sender, CancelEventArgs e)
        {
            if (!Employee.isValidEmail(TB_Email.Text))
            {
                e.Cancel = true;
                EP_VerifyEmail.SetError(TB_Email, "Invalid email. it should countain a '@'.");
            }
            else
            {
                EP_VerifyEmail = null;
            }
        }

        private void TB_Phone_Validating(object sender, CancelEventArgs e)
        {
            if (!Employee.isValidPhone(TB_Phone.Text))
            {
                e.Cancel = true;
                EP_VerifyPhone.SetError(TB_Phone, "Invalid phone number.");
            }
        }

        private void TB_PostalCode_Validating(object sender, CancelEventArgs e)
        {
            if (!Adress.verifyPostalCode(TB_PostalCode.Text))
            {
                e.Cancel = true;
                EP_VerifyPostalCode.SetError(TB_PostalCode, "Invalid postal code.");
            }
        }

        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
