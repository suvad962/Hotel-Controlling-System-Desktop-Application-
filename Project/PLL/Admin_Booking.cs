using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using variable;
using BLLL;
using System.Data.SqlClient;

namespace Project.PLL
{
    public partial class Admin_Booking : MetroFramework.Forms.MetroForm
    {

        BLL bl = new BLL();
        public Admin_Booking()
        {
            InitializeComponent();


            List<HotelRoom> hotelrooms = new List<HotelRoom>();
            //List<Department> departments = new List<Department>();

            SqlDataReader reader = bl.Showroomlist();
            while (reader.Read())
            {
                HotelRoom rooms = new HotelRoom();
                rooms.Id = reader.GetInt32(0);
                rooms.Room_Type = reader.GetString(1);
                rooms.Room_Price = reader.GetString(2);
                rooms.No_bed = reader.GetString(3);
                rooms.Room_Floor = reader.GetString(4);
                rooms.Extrabed = reader.GetString(5);
                rooms.booking = reader.GetString(6);
                hotelrooms.Add(rooms);
            }

            dataGridView1.DataSource = hotelrooms;


        }

        private void Admin_Booking_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            vari abooking = new vari();
            abooking.gid = Guestid.Text;
            abooking.id = Convert.ToInt32(Room_no.Text);
            abooking.Booking = "Yes";

            bl.BookRoom(abooking);

            // Confirm_Booking cb = new Confirm_Booking(abooking);

            BLL abookingbl = new BLL();



        }

        private void Room_no_Click(object sender, EventArgs e)
        {

        }
    }
}
