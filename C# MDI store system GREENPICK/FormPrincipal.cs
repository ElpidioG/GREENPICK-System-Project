using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mdi5toA
{
    
    public partial class FormPrincipal : Form
    {
        Form Form2 = new FormRegistro();

        
        public FormPrincipal()
        {
            InitializeComponent();

         

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form Form3 = new FormReloj();
            Form3.MdiParent = this;
            Form3.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("Esta accion cerrara el programa", "Cerrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (opcion == DialogResult.OK)
            {
                Close();
            }

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form2 != null)
            {
                Form2 = new FormRegistro();
                Form2.MdiParent = this;
                Form2.Show();

            }
            else
            {
                Form2.Hide();
            }


        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Form2 != null)
            {
                Form2 = new FormRegistro();
                Form2.MdiParent = this;
                Form2.Show();

            }
            else
            {
                Form2.Hide();
            }
        }

        private void horaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
    }
}
