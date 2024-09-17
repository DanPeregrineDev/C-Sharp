using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateAge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DT_Birthday.MaxDate = DateTime.Now;
        }

        private void BT_Calculate_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            DateTime birthDate = DT_Birthday.Value;
            int birthYear = birthDate.Year;

            TimeSpan lifespan = currentDate.Date - birthDate.Date;
            
            LB_Age.Text = ((int)lifespan.TotalDays / 365).ToString() + " Years old";

            if (birthYear % 4 == 0)
            {
                LB_LeapYear.Text = "Leap year";
            }
            else
            {
                LB_LeapYear.Text = "Not a Leap Year";
            }
        }
    }
}
