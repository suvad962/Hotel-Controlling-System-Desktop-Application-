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
    public partial class Edit_Rooms : MetroFramework.Forms.MetroForm
    {

        BLL blrm = new BLL();
        vari roomv = new vari();


        public Edit_Rooms(vari a)
        {
            InitializeComponent();
            roomv = a;

            List<Roomviewvar> roomlist = new List<Roomviewvar>();
            //List<Department> departments = new List<Department>();

            SqlDataReader reader = blrm.rmlist();
            while (reader.Read())
            {
               // Roomviewvar ser = new Roomviewvar();
                 roomv.id= reader.GetInt32(0);
                roomv.Type = reader.GetString(1);
                roomv.Price = reader.GetString(2);
                roomv.No_of_bed = reader.GetString(3);
                roomv.Level = reader.GetString(4);
                roomv.Extrabed = reader.GetString(5);
                roomv.Booking = reader.GetString(6);

                //roomlist.Add(ser);
            }

            //Roomlist.DataSource = roomlist;

            Room_Type.Text= roomv.Type;
            Room_Price.Text= roomv.Price;
            Nob.Text= roomv.No_of_bed;
            level.Text= roomv.Level;
            if (roomv.Extrabed == "Yes")
            {
                Extra_bedY.Checked = true;

            }
            else
            {
                E_bedN.Checked = true;
            }



        }

        private void Submit_Click(object sender, EventArgs e)
        {
            roomv.Type = Room_Type.Text;
            roomv.Price = Room_Price.Text;
            roomv.No_of_bed = Nob.Text;
            roomv.Level = level.Text;
            if (Extra_bedY.Checked)
            {
                roomv.Extrabed = "Yes";

            }
            else
            {
                roomv.Extrabed = "False";
            }
        }
    }
}
