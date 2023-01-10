using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mdi5toA
{
    public partial class FormRegistrar : Form
    {
        public string usuario;
        public FormRegistrar()
        {
            InitializeComponent();
        }

        private void butRegiP_Click(object sender, EventArgs e)
        {
         
            FormRegistroP Form6 = new FormRegistroP();
            Form6.usuario = labnom.Text;
            Form6.MdiParent = FormPrincipal.ActiveForm;
            Form6.Show();
            this.Close();

        }

        private void butRegC_Click(object sender, EventArgs e)
        {
          
            FormRegistroCl Form12 = new FormRegistroCl();
            Form12.usuario = labnom.Text;
            Form12.MdiParent = FormPrincipal.ActiveForm;
            Form12.Show();
            this.Close();
        }

        private void butRegd_Click(object sender, EventArgs e)
        {
        
            FormRegistroD Form13 = new FormRegistroD();
            Form13.usuario = labnom.Text;
            Form13.MdiParent = FormPrincipal.ActiveForm;
            Form13.Show();
            this.Close();

        }

        private void butRegE_Click(object sender, EventArgs e)
        {
        
            FormRegistroE Form11 = new FormRegistroE();
            Form11.usuario = labnom.Text;
            Form11.MdiParent = FormPrincipal.ActiveForm;
            Form11.Show();
            this.Close();

        }

        private void FormRegistrar_Load(object sender, EventArgs e)
        {
            labnom.Text = usuario;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Estás seguro que quieres regresar?", "¿Desea volver?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resultado == DialogResult.Yes)
            {
             
                FormMenu Form5 = new FormMenu();
                Form5.usuario= usuario;
                Form5.MdiParent = FormPrincipal.ActiveForm;
                Form5.Show();
                this.Close();
            }

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label8.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label8.Visible = false;
        }
    }
}
