using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager.Forms
{
    public partial class F_OccupyRoom : Form
    {
        F_Main mainForm;

        public F_OccupyRoom(F_Main f_Main)
        {
            mainForm = f_Main;
            InitializeComponent();

            // Add all available rooms to the dropdown menu
            for (int i = 0; i < mainForm.LBX_AvailableRooms.Items.Count; i++)
            {
                CB_Rooms.Items.Add(mainForm.LBX_AvailableRooms.Items[i].ToString());
            }

            // If room is selected then make it a value of the ComboBox
            if (mainForm.LBX_AvailableRooms.SelectedItem != null)
            {
                CB_Rooms.SelectedItem = mainForm.LBX_AvailableRooms.SelectedItem;
            }
        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            mainForm.LBX_OccupiedRooms.Items.Add(CB_Rooms.SelectedItem.ToString() + " | " + TB_OccupantName.Text);
            mainForm.LBX_AvailableRooms.Items.Remove(CB_Rooms.SelectedItem.ToString());

            mainForm.refreshCounts();

            Close();
        }
    }
}
