
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mdi5toA
{
    public partial class FormMenu : Form
    {
        public string usuario;
        public FormMenu()
        {
            InitializeComponent();
          
        }

        private void butRegistro_Click(object sender, EventArgs e)
        {
    
          FormRegistrar Form10 = new FormRegistrar();
          Form10.usuario = labnom.Text;
            Form10.MdiParent = FormPrincipal.ActiveForm;
          Form10.Show();
            this.Close();

        }

        private void butcompras_Click(object sender, EventArgs e)
        {
           
            FormCompras Form7 = new FormCompras();
            Form7.usuario = labnom.Text;
            Form7.MdiParent = FormPrincipal.ActiveForm;
            Form7.Show();
            this.Close();
        }

        private void butFacturar_Click(object sender, EventArgs e)
        {
          
            FormFactura FormFactura = new FormFactura();
            FormFactura.usuario = labnom.Text;
            FormFactura.MdiParent = FormPrincipal.ActiveForm;
            FormFactura.Show();
            this.Close();

        }

        private void butVentas_Click(object sender, EventArgs e)
        {
         
            FormVentas Form8 = new FormVentas();
            Form8.usuario = labnom.Text;
            Form8.MdiParent = FormPrincipal.ActiveForm;
            Form8.Show();
            this.Close();


        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            labnom.Text = usuario;

        }

        private void labeltit_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
            label1.Visible = true;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro que quieres cerrar sesión?", "¿Desea volver?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
                Form Form2 = new FormRegistro();
                Form2.MdiParent = FormPrincipal.ActiveForm;
                Form2.Show();
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }
}
