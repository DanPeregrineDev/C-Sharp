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
    public partial class F_UnoccupyRoom : Form
    {
        F_Main mainForm;

        public F_UnoccupyRoom(F_Main f_Main)
        {
            mainForm = f_Main;
            InitializeComponent();

            // Add all occupied rooms to the dropdown menu
            for (int i = 0; i < mainForm.LBX_OccupiedRooms.Items.Count; i++)
            {
                CB_Rooms.Items.Add(mainForm.LBX_OccupiedRooms.Items[i].ToString());
            }
        }

        private void BT_Unoccupy_Click(object sender, EventArgs e)
        {
            if (CB_Rooms.SelectedIndex != -1)
            {
                string selectedItem = CB_Rooms.SelectedItem.ToString();
                string roomNumber = selectedItem.Split('|')[0].Trim();

                mainForm.LBX_AvailableRooms.Items.Add(roomNumber);
                mainForm.LBX_OccupiedRooms.Items.Remove(selectedItem);

                mainForm.refreshCounts();

                Close();
            }
            else
            {
                MessageBox.Show("Nenhum quarto selecionado!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
