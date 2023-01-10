using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mdi5toA
{
    public partial class Xventas : Form
    {
        public string fecha;
       
        public Xventas()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.sp_ventas' table. You can move, or remove it, as needed.
            this.sp_ventasTableAdapter.Fill(this.DataSet1.sp_ventas, fecha);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
