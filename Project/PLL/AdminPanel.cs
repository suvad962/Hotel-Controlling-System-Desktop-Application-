using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.PLL
{
    public partial class AdminPanel : MetroFramework.Forms.MetroForm
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Room r = new Room();
            this.Hide();
            r.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            this.Hide();
            emp.Show();


        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Service s = new Service();
            this.Hide();
            s.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Booking_Details2 bkd = new Booking_Details2();
            this.Hide();
            bkd.Show();
        }
    }
}
