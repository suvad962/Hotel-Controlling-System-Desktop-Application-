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

namespace Project.PLL
{
    public partial class Booking_Details2 : MetroFramework.Forms.MetroForm
    {
        BLL bookinglist2 = new BLL();
        public Booking_Details2()
        {
            InitializeComponent();

            List<Booking_Variables> Booking_list = new List<Booking_Variables>();
            //List<Department> departments = new List<Department>();

            SqlDataReader reader = bookinglist2.View_Booking_List();
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

            BookingDetails2.DataSource = Booking_list;












        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Confirm_Booking cb = new Confirm_Booking();
            this.Hide();
            cb.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Admin_Booking ab = new Admin_Booking();

            this.Hide();
            ab.Show();

        }
    }
}
