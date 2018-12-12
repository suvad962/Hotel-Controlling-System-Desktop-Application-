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
    public partial class EditService : MetroFramework.Forms.MetroForm
    {
        BLL n = new BLL();
        vari v = new vari();

        public EditService(vari vi)
        {
            v = vi;
            InitializeComponent();

            List<Services> servicelist = new List<Services>();
            //List<Department> departments = new List<Department>();

            SqlDataReader reader = n.Servicelist();
            while (reader.Read())
            {
                Services ser = new Services();
                v.id = reader.GetInt32(0);
                v.name = reader.GetString(1);
                v.Price = reader.GetString(2);
                v.Description = reader.GetString(3);
                v.available = reader.GetString(4);

                servicelist.Add(ser);
            }

            Sname.Text=v.name;
            Price.Text=v.Price;
            Description.Text=v.Description;
            Available.Text=v.available;




        }

        private void EditService_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           // BLL servicequery = new BLL();
           // vari servicevariable = new vari();

            v.name = Sname.Text;
            v.Price = Price.Text;
            v.Description = Description.Text;
            v.available = Available.Text;

            n.UpdateService(v);
        }
    }
}
