using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Mdi5toA
{
    public partial class FormRegistroE : Form
    {
        public int indice;
        public string usuario;
        public FormRegistroE()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            labnom.Text = usuario;
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-710LBMG\\SQLEXPRESS;Initial Catalog=GreenPick;Integrated Security=True");
            conectar.Close();
            string datos = "select * from empleados";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "" && textBoxNombre.Text != "" && textBoxapellido.Text != "" && textBoxfechan.Text != "" && textBoxcargo.Text != "" && textBfechac.Text != "" && textBoxiddep.Text != "")

            {
                SqlConnection conectar = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");
                conectar.Open();
                string id = textBoxID.Text;
                string nombre = textBoxNombre.Text;
                string apellido = textBoxapellido.Text;
                string fecnac = textBoxfechan.Text;
                string cargo = textBoxcargo.Text;
                string fechac = textBfechac.Text;
                string iddep = textBoxiddep.Text;
                
            


                string query = "insert into Empleados Values('" + id + "','" + nombre + "','" + apellido + "','" + fecnac + "','" + cargo + "','" + fechac + "','" + iddep + "')";

                SqlCommand command = new SqlCommand(query, conectar);
                command.ExecuteNonQuery();
                MessageBox.Show("Sus Datos fueron registrados Exitosamente");
                textBoxID.Text = "";
                textBoxNombre.Text = "";
                textBoxapellido.Text = "";
                textBoxfechan.Text = "";
                textBoxcargo.Text = "";
                textBfechac.Text = "";
                textBoxiddep.Text = "";
                textBoxID.Focus();
                dataGridView3.Refresh();
                lbcontrol.Visible = false;
                conectar.Close();
                string datos = "select * from Empleados";
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
                string cargo = textBoxcargo.Text;
                string fechac = textBfechac.Text;
                string iddep = textBoxiddep.Text;

                string eliminar = "DELETE FROM Empleados WHERE ID_Empleado = '" + id + "'";
                SqlCommand cmd = new SqlCommand(eliminar, conectar);
                int conteo;
                conteo = cmd.ExecuteNonQuery();
                if (conteo == 1)
                {
                    textBoxID.Text = "";
                    textBoxNombre.Text = "";
                    textBoxapellido.Text = "";
                    textBoxfechan.Text = "";
                    textBoxcargo.Text = "";
                    textBfechac.Text = "";
                    textBoxiddep.Text = "";
                    pictureBox2.Image = default;
                    MessageBox.Show("Fueron eliminados los Datos");


                }

                else
                {
                    MessageBox.Show("No Existe este Empleado");
                }

                string datos = "select * from Empleados";
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

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            butborrar.Enabled = true;
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
            label8.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label8.Visible = false;
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

        private void textBoxiddep_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBoxID.Text == "")
            {
                MessageBox.Show("Digite un Codigo");
            }
            else
            {
                SqlConnection Conectar = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");
               
                Conectar.Open();
                String id = textBoxID.Text;

                String cadena = "select ID_empleado,Nombre,Apellido,Fecha_Nacimiento,Cargo,Fecha_contratación,ID_departamento, imagen from Empleados where ID_empleado=" + id;
                SqlCommand command = new SqlCommand(cadena, Conectar);
                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    textBoxNombre.Text = reader["Nombre"].ToString();
                    textBoxapellido.Text = reader["Apellido"].ToString();
                    textBoxfechan.Text = reader["Fecha_Nacimiento"].ToString();
                    textBoxcargo.Text = reader["Cargo"].ToString();
                    textBfechac.Text = reader["Fecha_contratación"].ToString();
                    textBoxiddep.Text = reader["ID_departamento"].ToString();
                }
                else
                {
                    MessageBox.Show("El empleado no existe","ERROR");
                }



            }



         

        }

        private void butlimpiar_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "" && textBoxNombre.Text == "" && textBoxapellido.Text == "" &&  textBoxfechan.Text == "" && textBoxcargo.Text == "" &&textBfechac.Text == "" && textBoxiddep.Text == "" && pictureBox2.Image == default)
            {
                MessageBox.Show("No hay datos que limpiar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBoxID.Text = "";
                textBoxNombre.Text = "";
                textBoxapellido.Text = "";
                textBoxfechan.Text = "";
                textBoxcargo.Text = "";
                textBfechac.Text = "";
                textBoxiddep.Text = "";
                pictureBox2.Image = default;
            }
          


        }

        private void butmodificar_Click(object sender, EventArgs e)
        {

            if (textBoxID.Text !="")

            {

                
            SqlConnection conectar = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");
            conectar.Open();



            string id = textBoxID.Text;

            string nombre = textBoxNombre.Text;
            string apellido = textBoxapellido.Text;
            string fecnac = textBoxfechan.Text;
            string cargo = textBoxcargo.Text;
            string fechac = textBfechac.Text;
            string iddep = textBoxiddep.Text;
            Image imagen = pictureBox2.Image;
               
            String cadena = "select ID_empleado,Nombre,Apellido,Fecha_Nacimiento,Cargo,Fecha_contratación,ID_departamento, imagen from Empleados where ID_empleado=" + id;
            SqlCommand command = new SqlCommand(cadena, conectar);
            SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())

                {
                    string actualizar = "update Empleados set Nombre = '" + nombre + "', Apellido = '" + apellido + "', Fecha_Nacimiento = '" + fecnac + "' , Cargo = '" + cargo + "' , Fecha_contratación = '" + fechac + "', ID_departamento = '" + iddep + "', imagen = '" + imagen + "' where ID_empleado = '" + id + "' ";
                    SqlConnection conect = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");

                    conect.Open();
                    SqlCommand cm = new SqlCommand(actualizar, conect);
                    int controlador;
                    controlador = cm.ExecuteNonQuery();
                    if (controlador == 1)
                    {
                        MessageBox.Show("Fueron modificados los Datos");
                        textBoxID.Text = "";
                        textBoxNombre.Text = "";
                        textBoxapellido.Text = "";
                        textBoxfechan.Text = "";
                        textBoxcargo.Text = "";
                        textBfechac.Text = "";
                        textBoxiddep.Text = "";
                        butmodificar.Enabled = false;

                    }
                    string datos = "select * from Empleados";
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
                    MessageBox.Show("No existe este empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void textBoxcargo_MouseClick(object sender, MouseEventArgs e)
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

        private void textBfechac_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxcargo.Text != "")
            {
                butmodificar.Enabled = true;
            }

            else
            {
                butmodificar.Enabled = false;
            }

        }

        private void textBoxiddep_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBfechac.Text != "")
            {
                butmodificar.Enabled = true;
            }

            else
            {
                butmodificar.Enabled = false;
            }

        }

        private void btCargar_Click(object sender, EventArgs e)
        {

           
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBox2.Image = Image.FromFile(imagen);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("El archivo selecionado no es un tipo de imagen", ex.Message);
            }
        }

        private void btADD_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Debe poner una foto");
            }

            else
            {

                try
                {
                    SqlConnection conectar = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");
                  //  conectar.Open();
                    string id = textBoxID.Text;
                    string nombre = textBoxNombre.Text;
                    string apellido = textBoxapellido.Text;
                    string fecnac = textBoxfechan.Text;
                    string cargo = textBoxcargo.Text;
                    string fechac = textBfechac.Text;
                    string iddep = textBoxiddep.Text;

                    string cadena = "Insert into Empleados(ID_Empleado, Nombre, Apellido, Fecha_Nacimiento,Cargo, Fecha_contratación, ID_departamento, imagen) Values(@id , @nombre, @apellido,@fecnac,@cargo,@fechac,@iddep, @imagen)";
                    SqlCommand cmd = new SqlCommand(cadena, conectar);
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@apellido", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@fecnac", System.Data.SqlDbType.Date);
                    cmd.Parameters.Add("@cargo", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@fechac", System.Data.SqlDbType.Date);
                    cmd.Parameters.Add("@iddep", System.Data.SqlDbType.Int);

                    //Ensamble
                    cmd.Parameters.Add("@imagen", System.Data.SqlDbType.Image);

                    cmd.Parameters["@id"].Value = int.Parse(textBoxID.Text);
                    cmd.Parameters["@nombre"].Value = textBoxNombre.Text;
                    cmd.Parameters["@apellido"].Value = textBoxapellido.Text;
                    cmd.Parameters["@fecnac"].Value = Convert.ToDateTime(textBoxfechan.Text);
                    cmd.Parameters["@cargo"].Value = textBoxcargo.Text;
                    cmd.Parameters["@fechac"].Value = Convert.ToDateTime(textBfechac.Text);
                    cmd.Parameters["@iddep"].Value = int.Parse(textBoxiddep.Text);



                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    cmd.Parameters["@imagen"].Value = ms.GetBuffer();

                    conectar.Open();
                    cmd.ExecuteNonQuery();
                    conectar.Close();

                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



                SqlConnection Conectando = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");
                Conectando.Open();
                string datos = "select * from Empleados";
                try
                {
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

                textBoxID.Text = "";
                textBoxNombre.Text = "";
                textBoxapellido.Text = "";
                textBoxfechan.Text = "";
                textBoxcargo.Text = "";
                textBfechac.Text = "";
                textBoxiddep.Text = "";
                pictureBox2.Image = default;
            }




        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text=="")
            {
                MessageBox.Show("Debe ingresar el ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            
            try
            {
                SqlConnection conectar = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");

                conectar.Open();
                string id = textBoxID.Text;
                string buscar = "select * from Empleados where ID_empleado =" + id;
                SqlCommand command = new SqlCommand(buscar, conectar);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    MemoryStream memory = new MemoryStream((byte[])reader["imagen"]);
                    Bitmap bm = new Bitmap(memory);
                    pictureBox2.Image = bm;
                    textBoxNombre.Text = reader["Nombre"].ToString();
                    textBoxapellido.Text = reader["Apellido"].ToString();
                    textBoxfechan.Text = reader["Fecha_Nacimiento"].ToString();
                    textBoxcargo.Text = reader["Cargo"].ToString();
                    textBfechac.Text = reader["Fecha_contratación"].ToString();
                    textBoxiddep.Text = reader["ID_departamento"].ToString();
                }
            }

            catch (Exception e1)
            {
                MessageBox.Show("el codigo no existe", e1.Message);
            }

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lbcontrol_Click(object sender, EventArgs e)
        {

        }
    }
}
