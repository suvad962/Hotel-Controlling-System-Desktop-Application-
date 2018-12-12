using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using variable;
using BLLL;

namespace Project.PLL
{
    public partial class Guest : MetroFramework.Forms.MetroForm
    {
        public Guest()
        {
            InitializeComponent();
            //w.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            vari vguest = new vari();
            vguest.uname = guser.Text;
            vguest.password = gpass.Text;
            BLL b = new BLL();
            DataTable data = b.guestlogin(vguest);
            


            if (data.Rows.Count > 0)
            {

                // MessageBox.Show("Login Success!");
                

                foreach (DataRow dr in data.Rows)
                {
                    vguest.gid = dr["Id"].ToString();
                    //string col2 = dr["col2"].ToString();
                }
                Guest_Panel gp = new Guest_Panel(vguest);
                this.Hide();
                gp.Show();

            }



        }


        private void metroButton2_Click(object sender, EventArgs e)
        {
            Guest_Details gd = new Guest_Details();
            gd.Show();
        }
    }
}