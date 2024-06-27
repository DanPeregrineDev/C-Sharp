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
    public partial class F_AddRooms : Form
    {
        F_Main mainForm;

        public F_AddRooms(F_Main f_Main)
        {
            mainForm = f_Main;
            InitializeComponent();
        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            string roomNumber = TB_RoomNumber.Text;

            if (!string.IsNullOrEmpty(roomNumber))
            {
                bool existsInAvailableRooms = mainForm.LBX_AvailableRooms.Items.Contains(roomNumber);
                bool existsInOccupiedRooms = false;

                foreach (string item in mainForm.LBX_OccupiedRooms.Items)
                {
                    string occupiedRoomNumber = item.Split('|')[0].Trim();

                    if (occupiedRoomNumber == roomNumber)
                    {
                        existsInOccupiedRooms = true;
                        break;
                    }
                }

                if (!existsInAvailableRooms && !existsInOccupiedRooms)
                {
                    mainForm.LBX_AvailableRooms.Items.Add(roomNumber);
                    mainForm.refreshCounts();
                    Close();
                }
                else
                {
                    MessageBox.Show("Quarto já existe!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
