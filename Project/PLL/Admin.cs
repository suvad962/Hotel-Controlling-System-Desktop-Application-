using System;
using MetroFramework.Forms;
using MetroFramework;
using BLLL;
using variable;
using System.Data;
using System.Windows.Forms;

namespace Project.PLL
{
    public partial class Admin : MetroFramework.Forms.MetroForm
    {
        public Admin()
        {
            InitializeComponent();
            //w.Hide();


            //this.test();

        }
        



        
        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)


        {

            vari vadmin = new vari();
            vadmin.uname = Ausername.Text;
            vadmin.password = Apassword.Text;
            BLL b = new BLL();
            DataTable data =b.adminlogin(vadmin);
            if (data.Rows.Count > 0)
            {
                AdminPanel ap = new AdminPanel();
                this.Hide();
                ap.Show();
            }

          /*  foreach(var usr in ef.Admindbs)
            {
                if(usr.Username==Ausername.Text && usr.Password == Apassword.Text)
                {

                    Guest g = new Guest();
                    g.Show();
                }

            }*/
        }
    }
}
