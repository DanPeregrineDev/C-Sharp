﻿using System;
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
    public partial class F_Splash : Form
    {
        public F_Splash()
        {
            InitializeComponent();
        }

        private void SplashDuration_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
