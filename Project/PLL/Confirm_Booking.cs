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
    public partial class Confirm_Booking : MetroFramework.Forms.MetroForm
    {

        BLL bl = new BLL();
        public Confirm_Booking()
        {
            InitializeComponent();

            List<Booking_Variables> Booking_list = new List<Booking_Variables>();
            //List<Department> departments = new List<Department>();

            SqlDataReader reader = bl.View_Booking_List();
            while (reader.Read())
            {
                Booking_Variables ser = new Booking_Variables();
                ser.Id = reader.GetInt32(0);
                ser.G_id = reader.GetString(1);
                ser.Price = reader.GetString(2);
                ser.Payment = reader.GetString(3);
                ser.Status = reader.GetString(4);
                ser.Service = reader.GetString(5);
                ser.S_id = reader.GetString(6);

                Booking_list.Add(ser);
            }

            Confirmgrid.DataSource = Booking_list;


        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            BLL servicequery = new BLL();
            vari servicevariable = new vari();

            servicevariable.Room_id= Confirm_id.Text;
            servicevariable.Status = "Confirmed";



            servicequery.ConfirmBooking(servicevariable);
        }
    }
}
