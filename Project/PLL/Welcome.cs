﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALL;


namespace Project.PLL
{
    public partial class Welcome :MetroFramework.Forms.MetroForm
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
           // a.Parent = this;
            a.Show();

           // Visible = false;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
           Guest g = new Guest();
           g.Show();

            //Visible = false;

          DBC d = new DBC();

           d.getcon();
        }
    }
}
