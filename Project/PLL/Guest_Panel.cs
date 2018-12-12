using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLL;
using variable;


namespace Project.PLL
{
    public partial class Guest_Panel : MetroFramework.Forms.MetroForm
    {
        BLL gbll = new BLL();
        vari gvar = new vari();

        public Guest_Panel(vari g_id)
        {

            gvar = g_id;

            InitializeComponent();
        }

        private void Guest_Panel_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Guest_Booking gb = new Guest_Booking(gvar);
            this.Hide();
            gb.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Order og = new Order(gvar);
            this.Hide();
            og.Show();
            
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Book_A_Service bas = new Book_A_Service(gvar);
            this.Hide();
            bas.Show();
        }
    }
}
