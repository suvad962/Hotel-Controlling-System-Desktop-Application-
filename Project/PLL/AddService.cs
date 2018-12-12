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

namespace Project.PLL
{
    public partial class AddService : MetroFramework.Forms.MetroForm
    {
        public AddService()
        {
            InitializeComponent();
        }

        private void AddService_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            BLL servicequery = new BLL();
            vari servicevariable = new vari();

            servicevariable.name = Sname.Text;
            servicevariable.Price = Price.Text;
            servicevariable.Description = Description.Text;
            servicevariable.available = Available.Text;

            servicequery.insertservice(servicevariable);
        }
    }
}
