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
    public partial class FormFacturas : Form
    {
        public int numero_factura;
        public FormFacturas()
        {
            InitializeComponent();
        }

        private void FormFacturas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.sp_factura' table. You can move, or remove it, as needed.
            this.sp_facturaTableAdapter.Fill(this.dataSet1.sp_factura, numero_factura);
            // TODO: This line of code loads data into the 'dataSet1.factura' table. You can move, or remove it, as needed.
            this.facturaTableAdapter.Fill(this.dataSet1.factura);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
