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
    public partial class FormRegistroD : Form
    {
        public int indice;
        public string usuario;
        public FormRegistroD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "" && textBoxNombre.Text != "" && textBoxdescripcion.Text != "")

            {
                    SqlConnection conectar = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");
                    conectar.Open();
               string id = textBoxID.Text;
               string nombre = textBoxNombre.Text;
               string descripcion = textBoxdescripcion.Text;

                string query = "insert into Departamentos Values('" + id + "','" + nombre + "','" + descripcion + "')";

                    SqlCommand command = new SqlCommand(query, conectar);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sus Datos fueron registrados Exitosamente");
                textBoxID.Text = "";
                textBoxNombre.Text = "";
                textBoxdescripcion.Text = "";

                textBoxID.Focus();
                    dataGridView3.Refresh();
                    lbcontrol.Visible = false;
                conectar.Close();
                string datos = "select * from Departamentos";
                SqlConnection Conectando1 = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");
                try
                {
                    Conectando1.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, Conectando1);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dataGridView3.DataSource = dt;
                    Conectando1.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                {
                    lbcontrol.Text = "Debe llenar todos los campos";
                    lbcontrol.Visible = true;

                }

            }

        private void butborrar_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "")
            {

            

            string id = textBoxID.Text;
            SqlConnection conectar = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");
            conectar.Open();
            string delete= "delete from Departamentos where ID_Departamento = " + id;
            SqlCommand cmd = new SqlCommand(delete, conectar);
            int contador;
            contador= cmd.ExecuteNonQuery();

            if (contador ==1)
            {
                textBoxID.Text = "";
                textBoxNombre.Text = "";
                textBoxdescripcion.Text = "";
            }
            else
            {
                MessageBox.Show("No existe ese departamento");

            }


            string datos = "select * from Departamentos";
            SqlConnection Conectando = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");


            try
            {
                Conectando.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, Conectando);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView3.DataSource = dt;
                Conectando.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
            else
            {
                MessageBox.Show("Debe llenar el ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro que quieres regresar?", "¿Desea volver?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
              
                FormRegistrar Form10 = new FormRegistrar();
                Form10.usuario = usuario;
                Form10.MdiParent = FormPrincipal.ActiveForm;
                Form10.Show();
                this.Close();
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label9.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label9.Visible = false;
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void FormRegistroD_Load(object sender, EventArgs e)
        {
            labnom.Text = usuario;
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-710LBMG\\SQLEXPRESS;Initial Catalog=GreenPick;Integrated Security=True");
            conectar.Close();
            string datos = "select * from Departamentos";
            try
            {

                SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, conectar);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView3.DataSource = dt;
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void butbuscar_Click(object sender, EventArgs e)
        {

            if (textBoxID.Text != "")
            {

                SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-710LBMG\\SQLEXPRESS;Initial Catalog=GreenPick;Integrated Security=True");
                conectar.Open();

                String id = textBoxID.Text;
                //  String nombre = textBoxNombre.Text;
                //  String apellido = textBoxapellido.Text;
                String cadena = "select ID_departamento, Nombre, Descripcion from Departamentos where ID_departamento = " + id;
                SqlCommand command = new SqlCommand(cadena, conectar);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    textBoxNombre.Text = reader["Nombre"].ToString();
                    textBoxdescripcion.Text = reader["Descripcion"].ToString();

                }

            }
            else
            {
                DialogResult resultado = MessageBox.Show("Debe ingresar el id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butlimpiar_Click(object sender, EventArgs e)
        {
            
            if (textBoxID.Text == "" && textBoxNombre.Text == "" && textBoxdescripcion.Text == "")
            {
                MessageBox.Show("No hay datos que limpiar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                textBoxID.Text = "";
                textBoxNombre.Text = "";
                textBoxdescripcion.Text = "";
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");
            conectar.Open();
            string id = textBoxID.Text;
            string nombre_Departamento = textBoxNombre.Text;
            string descrip = textBoxdescripcion.Text;
            string actualizar = "update Departamentos set Nombre = '" + nombre_Departamento + "', Descripcion = '" + descrip + "' where ID_Departamento = '" + id + "' ";
            SqlCommand cmd = new SqlCommand(actualizar, conectar);
            int controlador;
            controlador = cmd.ExecuteNonQuery();
            if (controlador == 1)
            {
                MessageBox.Show("Fueron modificados los Datos");
                textBoxID.Text = "";
                textBoxNombre.Text = "";
                textBoxdescripcion.Text = "";
                butmodificar.Enabled = false;

            }

            else
            {
                MessageBox.Show("No se pudo modificar los Datos");
                conectar.Close();
            }
            string datos = "select * from Departamentos";
            SqlConnection Conectando = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");


            try
            {
                Conectando.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, Conectando);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView3.DataSource = dt;
                Conectando.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBoxNombre_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxID.Text != "")
            {
                butmodificar.Enabled = true;
            }

            else
            {
                butmodificar.Enabled = false;
            }
        }

        private void textBoxdescripcion_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxNombre.Text != "")
            {
                butmodificar.Enabled = true;
            }

            else
            {
                butmodificar.Enabled = false;
            }
        }
    }
}
