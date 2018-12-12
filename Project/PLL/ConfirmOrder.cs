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
    public partial class ConfirmOrder : MetroFramework.Forms.MetroForm
    {
        BLL bl = new BLL();
        vari var = new vari();

        public ConfirmOrder(vari v)
        {

            var = v;

            InitializeComponent();

          //  var.gid = g.gid;

            List<Orderlist> Order = new List<Orderlist>();
            //List<Department> departments = new List<Department>();

            SqlDataReader reader = bl.OrderlistBYid(var);
            while (reader.Read())
            {
                Orderlist order = new Orderlist();
                order.Id = reader.GetInt32(0);
                order.G_id = reader.GetString(1);
                order.Price = reader.GetString(2);
                order.Payment = reader.GetString(3);
                order.Service = reader.GetString(4);
                order.Status = reader.GetString(5);
                order.S_id = reader.GetString(6);
                Order.Add(order);
            }

            dataGridView1.DataSource = Order;
            //dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var.Payment = "Paid";
            bl.PayOrder(var);
            MessageBox.Show(this, "Payment Successful");

        }
    }
}
