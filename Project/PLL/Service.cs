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
    public partial class Service : MetroFramework.Forms.MetroForm
    {
        BLL n = new BLL();
        vari v = new vari();

        public Service()
        {
            InitializeComponent();

            List<Services> servicelist= new List<Services>();
            //List<Department> departments = new List<Department>();

            SqlDataReader reader = n.Servicelist();
            while (reader.Read())
            {
                Services ser = new Services();
                ser.Id = reader.GetInt32(0);
                ser.Service_Name = reader.GetString(1);
                ser.Price = reader.GetString(2);
                ser.Description = reader.GetString(3);
                ser.Available= reader.GetString(4);

                servicelist.Add(ser);
            }

            dataGridView1.DataSource = servicelist;

        }

        private void Service_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
            AddService aser = new AddService();
            this.Hide();
            aser.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            v.id = Convert.ToInt32(ServiceID.Text);
            DeleteService ds = new DeleteService(v);
            this.Hide();
            ds.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            EditService es = new EditService(v);
            this.Hide();
            es.Show();
            
        }
    }
}
