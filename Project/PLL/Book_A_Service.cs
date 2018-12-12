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
    public partial class Book_A_Service : MetroFramework.Forms.MetroForm
    {
        BLL n = new BLL();
        vari v = new vari();
        public Book_A_Service(vari gid)
        {
            InitializeComponent();
            v.gid = gid.gid;

            List<ComboService> servicelist = new List<ComboService>();
            //List<Department> departments = new List<Department>();

            SqlDataReader reader = n.Servicelist();
            while (reader.Read())
            {
                ComboService ser = new ComboService();
               // ser.Id = reader.GetInt32(0);
                ser.Service_Name = reader.GetString(1);
               // ser.Price = reader.GetString(2);
              //  ser.Description = reader.GetString(3);
                //ser.Available = reader.GetString(4);

                servicelist.Add(ser);
            }

            metroComboBox1.DataSource = servicelist;
            metroComboBox1.ValueMember = "Service_Name";
            
            metroComboBox1.DisplayMember = "Service_Name";
        }

        private void ServiceName_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Services> servicelist = new List<Services>();
            //List<Department> departments = new List<Department>();

            SqlDataReader reader = n.Servicelist();
            while (reader.Read())
            {
                Services ser = new Services();
                ser.Id = reader.GetInt32(0);
                ser.Service_Name = reader.GetString(1);
                ser.Price = reader.GetString(2);
                ser.Description = reader.GetString(3);
                ser.Available = reader.GetString(4);

                if (metroComboBox1.Text == ser.Service_Name)
                {

                    Price.Text = ser.Price;
                    v.id = ser.Id;
                    break;
                }

                //servicelist.Add(ser);
            }

            //dataGridView1.DataSource = servicelist;


        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            v.name = metroComboBox1.Text;
            int total = Convert.ToInt32(Price.Text)* Convert.ToInt32(quantity.Text);
            v.Price = Convert.ToString(total);
            //v.Quantity =quantity.Text;
            v.Service = "Service";
            v.Payment = "Not Paid";
            v.Status = "Pending";
            n.placeorder(v);

        }
    }
}
