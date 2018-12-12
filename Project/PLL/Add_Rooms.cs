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
namespace Project.PLL
{
    public partial class Add_Rooms : MetroFramework.Forms.MetroForm
    {
        public Add_Rooms()
        {
            InitializeComponent();
        }

        private void Add_Rooms_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            BLL roomb = new BLL();
            vari roomv = new vari();

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
            roomb.newroom(roomv);

        }
    }
}
