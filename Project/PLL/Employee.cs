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
using System.Data.SqlClient;
using variable;

namespace Project.PLL
{
    public partial class Employee : MetroFramework.Forms.MetroForm
    {
        BLL bl = new BLL();
        public Employee()
        {
            InitializeComponent();


            List<ViewEmpVar> emplist = new List<ViewEmpVar>();
            //List<Department> departments = new List<Department>();

            SqlDataReader reader = bl.Showemplist();
            while (reader.Read())
            {
                ViewEmpVar ser = new ViewEmpVar();
                ser.Id = reader.GetInt32(0);
                ser.Name = reader.GetString(1);
                ser.Department = reader.GetString(2);
                ser.Salary = reader.GetString(3);
                ser.Available = reader.GetString(4);
                ser.Address = reader.GetString(5);
                emplist.Add(ser);
            }

            EmpView.DataSource = emplist;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            

            Employee_Add empadd = new Employee_Add();
            this.Hide();
            empadd.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            vari vdmp = new vari();
            vdmp.id = Convert.ToInt32(Empid.Text);
            DeleteEmp demmp = new DeleteEmp(vdmp);
            this.Hide();
            demmp.Show();

        }

        private void EmpView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            vari v = new vari();
            v.id = Convert.ToInt32(Empid.Text);
            UpdateEmp uemp = new UpdateEmp(v);
            this.Hide();
            uemp.Show();
        }
    }
}
