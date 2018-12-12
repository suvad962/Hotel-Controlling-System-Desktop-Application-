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
using DALL;
using variable;
namespace Project.PLL
{
    public partial class Guest_Details : MetroFramework.Forms.MetroForm
    {

        public Guest_Details()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            BLL rb = new BLL();
            vari rv = new vari();

            rv.fname = fname.Text;
            rv.lname = lname.Text;
            rv.uname = uname.Text;
            rv.password = password.Text;
            //rv.DOB = this.DOB.Text;
            rv.address = Address.Text;
            if (Male.Checked) { rv.gender = "Male"; }
            if (Female.Checked) { rv.gender = "Female"; }
            rb.newguest(rv);


        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
