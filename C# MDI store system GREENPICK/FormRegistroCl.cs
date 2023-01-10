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
    public partial class FormRegistroCl : Form
    {
        public int indice;
        public string usuario;
        public FormRegistroCl()
        {
            InitializeComponent();
        }


        private void butborrar_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
            {
                lbcontrol.Text = "Debe llenar el Campo ID";
                lbcontrol.Visible = true;
            }
            if (textBoxID.Text != "")
            {
                SqlConnection conectar = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");
                conectar.Open();
                string id = textBoxID.Text;
                string nombre = textBoxNombre.Text;
                string apellido = textBoxapellido.Text;
                string fecnac = textBoxfechan.Text;
                string sexo = comboBox1.Text;
                string direccion = textBoxdireccion.Text;
                string telefono = textBtelefono.Text;
                string correo = textBoxemail.Text;


                string eliminar = "DELETE FROM Clientes WHERE ID_Cliente = '" + id + "'";
                SqlCommand cmd = new SqlCommand(eliminar, conectar);
                int conteo;
                conteo = cmd.ExecuteNonQuery();
                if (conteo == 1)
                {
                    textBoxID.Text = "";
                    textBoxNombre.Text = "";
                    textBoxapellido.Text = "";
                    comboBox1.Text = default;
                    textBoxfechan.Text = "";
                    textBtelefono.Text = "";
                    textBoxdireccion.Text = "";
                    textBoxemail.Text = "";
                    MessageBox.Show("Fueron eliminados los Datos");


                }

                else
                {
                    MessageBox.Show("No Existe este Cliente");
                }

                string datos = "select * from Clientes";
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


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (textBoxID.Text != "" && textBoxNombre.Text != "" && textBoxapellido.Text != "" && textBoxfechan.Text != ""
            && comboBox1.Text != "" && textBoxdireccion.Text != "" && textBtelefono.Text != "" && textBoxemail.Text != "")
            {
                SqlConnection conectar = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");
                conectar.Open();
                string id = textBoxID.Text;
                string nombre = textBoxNombre.Text;
                string apellido = textBoxapellido.Text;
                string fecnac = textBoxfechan.Text;
                string sexo = comboBox1.Text;
                string direccion = textBoxdireccion.Text;
                string telefono = textBtelefono.Text;
                string correo = textBoxemail.Text;

                string query = "insert into Clientes Values('" + id + "','" + nombre + "','" + apellido + "','" + fecnac + "','" + sexo + "','" + direccion + "','" + telefono + "','" + correo + "')";

                SqlCommand command = new SqlCommand(query, conectar);
                command.ExecuteNonQuery();
                MessageBox.Show("Sus Datos fueron registrados Exitosamente");
                textBoxID.Text = "";
                textBoxNombre.Text = "";
                textBoxapellido.Text = "";
                comboBox1.Text = default;
                textBoxfechan.Text = "";
                textBtelefono.Text = "";
                textBoxdireccion.Text = "";
                textBoxemail.Text = "";

                textBoxID.Focus();
                dataGridView3.Refresh();
                lbcontrol.Visible = false;
                conectar.Close();
                string datos = "select * from Clientes";
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

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
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

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FormRegistroCl_Load(object sender, EventArgs e)
        {

            labnom.Text = usuario;
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-710LBMG\\SQLEXPRESS;Initial Catalog=GreenPick;Integrated Security=True");
            conectar.Close();
            string datos = "select * from Clientes";
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

            /*      indice = dataGridView3.Rows.Add();

                  //fila 1
                  dataGridView3.Rows[indice].Cells[0].Value = "1";
                  dataGridView3.Rows[indice].Cells[1].Value = "Juan";
                  dataGridView3.Rows[indice].Cells[2].Value = "Marichal";
                  dataGridView3.Rows[indice].Cells[3].Value = "20/4/1990";
                  dataGridView3.Rows[indice].Cells[4].Value = "Masculino";
                  dataGridView3.Rows[indice].Cells[5].Value = "Calle Augusto Mota #1";
                  dataGridView3.Rows[indice].Cells[6].Value = "809-123-1234";
                  dataGridView3.Rows[indice].Cells[7].Value = "juanmarichal@gmail.com";
                  indice = dataGridView3.Rows.Add();
                  //fila 2
                  dataGridView3.Rows[indice].Cells[0].Value = "2";
                  dataGridView3.Rows[indice].Cells[1].Value = "Antonio";
                  dataGridView3.Rows[indice].Cells[2].Value = "Mechas";
                  dataGridView3.Rows[indice].Cells[3].Value = "21/2/1995";
                  dataGridView3.Rows[indice].Cells[4].Value = "Masculino";
                  dataGridView3.Rows[indice].Cells[5].Value = "Calle Augusto Federico Rueda #4";
                  dataGridView3.Rows[indice].Cells[6].Value = "809-153-1221";
                  dataGridView3.Rows[indice].Cells[7].Value = "antoniomechas@gmail.com";
                  indice = dataGridView3.Rows.Add();
                  //fila 3
                  dataGridView3.Rows[indice].Cells[0].Value = "3";
                  dataGridView3.Rows[indice].Cells[1].Value = "Marcos";
                  dataGridView3.Rows[indice].Cells[2].Value = "Bolo";
                  dataGridView3.Rows[indice].Cells[3].Value = "10/9/1987";
                  dataGridView3.Rows[indice].Cells[4].Value = "Masculino";
                  dataGridView3.Rows[indice].Cells[5].Value = "Calle Alberto Santo #19";
                  dataGridView3.Rows[indice].Cells[6].Value = "809-537-4312";
                  dataGridView3.Rows[indice].Cells[7].Value = "marcosbolo@gmail.com";
                  indice = dataGridView3.Rows.Add();
                  //fila 4
                  dataGridView3.Rows[indice].Cells[0].Value = "4";
                  dataGridView3.Rows[indice].Cells[1].Value = "Juana";
                  dataGridView3.Rows[indice].Cells[2].Value = "Pena";
                  dataGridView3.Rows[indice].Cells[3].Value = "31/4/1968";
                  dataGridView3.Rows[indice].Cells[4].Value = "Femenino";
                  dataGridView3.Rows[indice].Cells[5].Value = "Calle Salvador #1";
                  dataGridView3.Rows[indice].Cells[6].Value = "809-502-1564";
                  dataGridView3.Rows[indice].Cells[7].Value = "juanapena@gmail.com";
                  indice = dataGridView3.Rows.Add();
                  //fila 5
                  dataGridView3.Rows[indice].Cells[0].Value = "5";
                  dataGridView3.Rows[indice].Cells[1].Value = "Roberto";
                  dataGridView3.Rows[indice].Cells[2].Value = "Mota";
                  dataGridView3.Rows[indice].Cells[3].Value = "21/1/1999";
                  dataGridView3.Rows[indice].Cells[4].Value = "Masculino";
                  dataGridView3.Rows[indice].Cells[5].Value = "Calle  Motade #1";
                  dataGridView3.Rows[indice].Cells[6].Value = "8-723-1543";
                  dataGridView3.Rows[indice].Cells[7].Value = "robertomota@gmail.com";
             */
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
                String cadena = "select ID_cliente, Nombre, Apellido, Sexo, Fecha_Nacimiento, Direccion, Telefono, Sexo, Correo from Clientes where ID_cliente =" + id;
                SqlCommand command = new SqlCommand(cadena, conectar);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    textBoxNombre.Text = reader["Nombre"].ToString();
                    textBoxapellido.Text = reader["Apellido"].ToString();
                    comboBox1.Text = reader["Sexo"].ToString();
                    textBoxfechan.Text = reader["Fecha_Nacimiento"].ToString();
                    textBtelefono.Text = reader["Telefono"].ToString();
                    textBoxdireccion.Text = reader["Direccion"].ToString();
                    textBoxemail.Text = reader["Correo"].ToString();
                }


            }
            else
            {
                DialogResult resultado = MessageBox.Show("Debe ingresar el id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "" && textBoxNombre.Text == "" && textBoxapellido.Text == "" && textBoxfechan.Text == "" && comboBox1.Text == "" && textBtelefono.Text =="" && textBoxdireccion.Text == "" && textBoxemail.Text == "")
            {
                MessageBox.Show("No hay datos que limpiar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBoxID.Text = "";
                textBoxNombre.Text = "";
                textBoxapellido.Text = "";
                comboBox1.Text = default;
                textBoxfechan.Text = "";
                textBtelefono.Text = "";
                textBoxdireccion.Text = "";
                textBoxemail.Text = "";
            }
        }

        private void butmodificar_Click(object sender, EventArgs e)
        {

            if (textBoxID.Text != "")

            {
                SqlConnection conectar = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");
                conectar.Open();
                string id = textBoxID.Text;
                string nombre = textBoxNombre.Text;
                string apellido = textBoxapellido.Text;
                string fecnac = textBoxfechan.Text;
                string sexo = comboBox1.Text;
                string direccion = textBoxdireccion.Text;
                string telefono = textBtelefono.Text;
                string correo = textBoxemail.Text;
                string datos = "select * from Clientes where ID_cliente = " + id;

                SqlCommand command = new SqlCommand(datos, conectar);

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())

                {
                    string actualizar = "update Clientes set Nombre = '" + nombre + "', Apellido = '" + apellido + "', Fecha_Nacimiento = '" + fecnac + "' , Sexo = '" + sexo + "' , Direccion = '" + direccion + "', Telefono = '" + telefono + "' , Correo = '" + correo + "' where ID_cliente = '" + id + "' ";
                    SqlConnection conect = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");

                    conect.Open();

                    SqlCommand cmd = new SqlCommand(actualizar, conect);
                    int controlador;
                    controlador = cmd.ExecuteNonQuery();
                    if (controlador == 1)
                    {
                        MessageBox.Show("Fueron modificados los Datos");
                        textBoxID.Text = "";
                        textBoxNombre.Text = "";
                        textBoxapellido.Text = "";
                        comboBox1.Text = default;
                        textBoxfechan.Text = "";
                        textBtelefono.Text = "";
                        textBoxdireccion.Text = "";
                        textBoxemail.Text = "";
                        butmodificar.Enabled = false;

                        string datoss = "select * from Clientes";
                        SqlConnection Conectando = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");


                        try
                        {
                            Conectando.Open();
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(datoss, Conectando);
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

                }
                else
                {
                    MessageBox.Show("No existe este cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Ingrese el id a modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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

        private void textBoxapellido_MouseClick(object sender, MouseEventArgs e)
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

        private void textBoxfechan_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxapellido.Text != "")
            {
                butmodificar.Enabled = true;
            }

            else
            {
                butmodificar.Enabled = false;
            }

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxfechan.Text != "")
            {
                butmodificar.Enabled = true;
            }

            else
            {
                butmodificar.Enabled = false;
            }

        }

        private void textBoxdireccion_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox1.Text != default)
            {
                butmodificar.Enabled = true;
            }

            else
            {
                butmodificar.Enabled = false;
            }

        }

        private void textBtelefono_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxdireccion.Text != "")
            {
                butmodificar.Enabled = true;
            }

            else
            {
                butmodificar.Enabled = false;
            }

        }

        private void textBoxemail_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBtelefono.Text != "")
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