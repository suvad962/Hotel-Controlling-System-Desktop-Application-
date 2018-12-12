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
    public partial class Booking_Details : MetroFramework.Forms.MetroForm
    {
        BLL bookinglist = new BLL();
        public Booking_Details()
        {
            InitializeComponent();

            List<Booking_Variables> Booking_list = new List<Booking_Variables>();
            //List<Department> departments = new List<Department>();

            SqlDataReader reader = bookinglist.View_Booking_List();
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

            dataGridView1.DataSource = Booking_list;












        }
    }
}
