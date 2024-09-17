using HotelManager.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();

            // Splash screen
            F_Splash splash = new F_Splash();
            splash.ShowDialog();

            // Show how many rooms are available and occupied
            refreshCounts();
        }

        public void refreshCounts()
        {
            LB_AvailableCount.Text = "Quartos disponíveis: " + LBX_AvailableRooms.Items.Count;
            LB_OccupiedCount.Text = "Quartos ocupados: " + LBX_OccupiedRooms.Items.Count;
        }

        // Close app button
        private void BT_AppClose_Click(object sender, EventArgs e)
        {
            DialogResult reply = MessageBox.Show("Tem a certeza que deseja sair do programa?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (reply == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Minimize App Button
        private void BT_AppMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Add available room button
        private void adicionarQuartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_AddRooms addRooms = new F_AddRooms(this);
            addRooms.ShowDialog();
        }

        // Remove available room button
        private void removerQuartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LBX_AvailableRooms.SelectedIndex != -1)
            {
                string selectedRoom = LBX_AvailableRooms.SelectedItem.ToString();

                DialogResult Reply = MessageBox.Show($"Tem a certeza que deseja apagar o quarto {selectedRoom}?", "Tem a certeza", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Reply == DialogResult.Yes)
                {
                    LBX_AvailableRooms.Items.RemoveAt(LBX_AvailableRooms.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Nenhum quarto selecionado!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Occupy room button
        private void ocuparQuartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LBX_AvailableRooms.Items.Count != 0)
            {
                F_OccupyRoom occupyRoom = new F_OccupyRoom(this);
                occupyRoom.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não existem quartos disponíveis!\nAdicione um quarto primeiro", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Unoccupy room button
        private void desocuparQuartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LBX_OccupiedRooms.SelectedIndex != -1)
            {
                string selectedItem = LBX_OccupiedRooms.SelectedItem.ToString();
                string roomNumber = selectedItem.Split('|')[0].Trim();

                LBX_AvailableRooms.Items.Add(roomNumber);
                LBX_OccupiedRooms.Items.RemoveAt(LBX_OccupiedRooms.SelectedIndex);

                refreshCounts();
            }
            else
            {
                if (LBX_OccupiedRooms.Items.Count > 0)
                {
                    F_UnoccupyRoom unoccupyRoom = new F_UnoccupyRoom(this);
                    unoccupyRoom.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Não existem quartos ocupados!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void UpdateCurrentTime_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            LB_Time.Text = dateTime.ToString("HH:mm");
        }
    }
}
