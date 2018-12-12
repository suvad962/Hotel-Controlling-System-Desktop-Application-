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
    public partial class Guest_Booking : MetroFramework.Forms.MetroForm
    {

        BLL bl = new BLL();
        vari g_id = new vari();
        public Guest_Booking(vari gvar)
        {
            g_id = gvar;

            InitializeComponent();

            // MessageBox.Show(this,g_id.id);

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
            //dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            vari bookingid = new vari();

            bookingid.id = Convert.ToInt32(Room_no.Text);
            bookingid.gid = g_id.gid;
            bookingid.Booking = "Yes";

            bl.BookRoom(bookingid);
            
            SqlDataReader reader= bl.ReturnRoomInfo(bookingid);
            while (reader.Read())
            {
                //HotelRoom rooms = new HotelRoom();
                //.Id = reader.GetInt32(0);
                //rooms.Room_Type = reader.GetString(1);
                bookingid.Price = reader.GetString(2);
                //rooms.No_bed = reader.GetString(3);
                //rooms.Room_Floor = reader.GetString(4);
                //rooms.Extrabed = reader.GetString(5);
                //rooms.booking = reader.GetString(6);
                //hotelrooms.Add(rooms);
                bookingid.Service = "Room";
                bookingid.Payment = "Not Paid";
                bookingid.Status = "Pending";
            }
            bl.placeorder(bookingid);




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
