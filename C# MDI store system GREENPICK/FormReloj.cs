using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mdi5toA
{
    public partial class FormReloj : Form
    {
        public FormReloj()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
          
          //  labtime.Text = fecha.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Estás seguro que quieres cerrar esta ventana?", "¿Desea cerrar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
                
            }

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           labtime.Text=  DateTime.Now.ToString();
        }
    }
}
