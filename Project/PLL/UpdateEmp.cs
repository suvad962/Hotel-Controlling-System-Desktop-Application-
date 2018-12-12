using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLL;
using variable;

namespace Project.PLL
{
    public partial class UpdateEmp : MetroFramework.Forms.MetroForm
    {
        BLL bl = new BLL();
        vari v = new vari();

        public UpdateEmp(vari vi)
        {
            v=vi;
            InitializeComponent();



            List<ViewEmpVar> emplist = new List<ViewEmpVar>();
            //List<Department> departments = new List<Department>();

            SqlDataReader reader = bl.DShowemplist(vi);
            ViewEmpVar ser = new ViewEmpVar();
            while (reader.Read())
            {
               
               // ser.Id = reader.GetInt32(0);
                vi.name = reader.GetString(1);
                vi.Department = reader.GetString(2);
                vi.salary = reader.GetString(3);
                //vi.address= reader.GetString(4);
                vi.available = reader.GetString(4);
                vi.address = reader.GetString(5);
                //emplist.Add(ser);
            }

            // EmpView.DataSource = emplist;

            Ename.Text = vi.name;
            Department.Text = vi.Department;
            Salary.Text = vi.salary;
            Address.Text = vi.address;
            if (vi.available == "Yes")
            {

                Yes.Checked = true;
            }
            else
            {
                No.Checked = true;
            }



        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           v.name= Ename.Text;
            v.Department=Department.Text;
            v.salary=Salary.Text;
            if (Yes.Checked)
            {

                v.available = "Yes";
            }
            else
            {
                v.available = "No";
            }
            v.address = Address.Text;


            bl.UpdateEmp(v);
        }
    }
}
