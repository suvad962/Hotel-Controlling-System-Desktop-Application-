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
    public partial class Employee_Add : MetroFramework.Forms.MetroForm
    {
        public Employee_Add()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            BLL empb = new BLL();
            vari empv = new vari();

            empv.name = Ename.Text;
            empv.Department = Department.Text;
            empv.salary = Salary.Text;
            empv.address = Address.Text;
            if (Yes.Checked)
            {
                empv.available = "Yes";

            }
            else
            {
                empv.available = "No";
            }
            empb.newemp(empv);
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {


        }

        private void Department_Click(object sender, EventArgs e)
        {

        }
    }
}
