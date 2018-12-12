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
using System.Data.SqlClient;
using variable;

namespace Project.PLL
{
    public partial class DeleteRoom : MetroFramework.Forms.MetroForm
    {
        BLL dbl = new BLL();
        vari vdbl = new vari();

        public DeleteRoom(vari v)
        {
            vdbl = v;
            InitializeComponent();
            List<Roomviewvar> roomlist = new List<Roomviewvar>();
            //List<Department> departments = new List<Department>();

            SqlDataReader reader = dbl.drmlist(vdbl);
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

           RoomGrid.DataSource = roomlist;









        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            dbl.Droom(vdbl);
        }
    }
}
