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
using System.Data.SqlClient;

namespace Project.PLL
{
    public partial class DeleteEmp : MetroFramework.Forms.MetroForm
    {
        BLL bl = new BLL();
        vari vemp = new vari();
        public DeleteEmp(vari d_id)
        {
            InitializeComponent();
            vemp = d_id;

            List<ViewEmpVar> emplist = new List<ViewEmpVar>();
            //List<Department> departments = new List<Department>();

            SqlDataReader reader = bl.DShowemplist(vemp);
            while (reader.Read())
            {
                ViewEmpVar ser = new ViewEmpVar();
                ser.Id = reader.GetInt32(0);
                ser.Name = reader.GetString(1);
                ser.Department = reader.GetString(2);
                ser.Salary = reader.GetString(3);
                ser.Available = reader.GetString(4);
                emplist.Add(ser);
            }

            dempview.DataSource = emplist;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            bl.Demp(vemp);
        }
    }
}
