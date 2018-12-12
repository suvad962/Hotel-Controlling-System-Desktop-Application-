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
    

    public partial class Room : MetroFramework.Forms.MetroForm
    {
        BLL blrm = new BLL();
        vari roomv = new vari();
        public Room()
        {
            InitializeComponent();

            List<Roomviewvar> roomlist = new List<Roomviewvar>();
            //List<Department> departments = new List<Department>();

            SqlDataReader reader = blrm.rmlist();
            while (reader.Read())
            {
                Roomviewvar ser = new Roomviewvar();
                ser.Id = reader.GetInt32(0);
                ser.Type = reader.GetString(1);
                ser.Price = reader.GetString(2);
                ser.NOB = reader.GetString(3);
                ser.Floor = reader.GetString(4);
                ser.Extabed = reader.GetString(5);
                ser.Booking = reader.GetString(6);

                roomlist.Add(ser);
            }

            Roomlist.DataSource = roomlist;




        }

        private void Room_Load(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            roomv.id = Convert.ToInt32(Roomid.Text);
            DeleteRoom Dr = new DeleteRoom(roomv);
            this.Hide();
            Dr.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Add_Rooms add_room = new Add_Rooms();
            this.Hide();
            add_room.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Edit_Rooms er = new Edit_Rooms(roomv);
            this.Hide();
            er.Show();
        }
    }
}
