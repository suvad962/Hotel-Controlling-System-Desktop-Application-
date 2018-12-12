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
    public partial class DeleteService : MetroFramework.Forms.MetroForm
    {
        BLL n = new BLL();
        vari dservice = new vari();

        public DeleteService(vari v)
        {
            InitializeComponent();

            dservice = v;
            List<Services> servicelist = new List<Services>();
            //List<Department> departments = new List<Department>();

            SqlDataReader reader = n.DServicelist(dservice);
            while (reader.Read())
            {
                Services ser = new Services();
                ser.Id = reader.GetInt32(0);
                ser.Service_Name = reader.GetString(1);
                ser.Price = reader.GetString(2);
                ser.Available = reader.GetString(3);

                servicelist.Add(ser);
            }

            Delete_Service.DataSource = servicelist;





        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            n.DService(dservice);
        }
    }
}
