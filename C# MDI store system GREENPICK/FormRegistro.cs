using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mdi5toA
{
    
    public partial class FormRegistro : Form
    {

        public FormRegistro()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void labwelcome_Click(object sender, EventArgs e)
        {

        }

        private void textBuser_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void butaceptar_Click(object sender, EventArgs e)
        {
            if (textBuser.Text != "" && textBpass.Text =="")
            {
                lab1.Visible = true;
                lab3.Visible = true;
                lab2.Visible = false;
                lab3.Text = "Llenar todos los Campos";
               
            }

           else if (textBpass.Text != "" && textBuser.Text=="")
            {
                lab2.Visible = true;
                lab3.Visible = true;
                lab1.Visible = false;
                lab3.Text = "Llenar todos los Campos";
               
            }
            if (textBuser.Text != "" && textBpass.Text != "")

            {
                lab1.Visible = false;
                lab2.Visible = false;
                lab3.Text = "";

                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-710LBMG\\SQLEXPRESS;Initial Catalog=GreenPick;Integrated Security=True");
                conn.Open();
                string usuario = textBuser.Text;
                string clave = textBpass.Text;
                string sqluser = @"select count(*) from Usuario where usuario = @user and clave = @clave ";
                SqlCommand cmd = new SqlCommand(sqluser, conn);
                cmd.Parameters.AddWithValue("@user", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);
                int contador = Convert.ToInt32(cmd.ExecuteScalar());

                if (contador == 0)
                {

                    MessageBox.Show("Usuario o Clave Incorrecto");
                }
                else
                {
                  
                    MessageBox.Show("Ha iniciado sesión correctamente", "Bienvenido", MessageBoxButtons.OK);
                    this.Hide();
                    FormMenu Form5 = new FormMenu();
                    Form5.usuario = Convert.ToString(textBuser.Text);
                    Form5.MdiParent = FormPrincipal.ActiveForm;   
                    Form5.Show();

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro que quieres cerrar esta ventana?", "¿Desea cerrar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void picturemostracontra_Click(object sender, EventArgs e)
        {
            if (textBpass.UseSystemPasswordChar == true)
            {
                textBpass.UseSystemPasswordChar = false;
            }
            
            else{
                textBpass.UseSystemPasswordChar = true;
            }
        }
    }
}
