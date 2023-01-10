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
    public partial class FormCompras : Form
    {
        public string usuario;
        public int indice;
        public FormCompras()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "" && textBoxProducto.Text != "" && textBoxfechap.Text != "" && textBoxfechae.Text != ""
               && textBoxIdsup.Text != "" && textBoxppu.Text != "" && textBcant.Text != "")
            {
                SqlConnection conectar = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");
                conectar.Open();
                string id = textBoxID.Text;
                string prod = textBoxProducto.Text;
                string fecpedido = textBoxfechap.Text;
                string fecentrega = textBoxfechae.Text;
                string idsup = textBoxIdsup.Text;
                string preciouni = textBoxppu.Text;
                string cantidad = textBcant.Text;

                string query = "insert into compras Values('" + id + "','" + prod + "','" + fecpedido + "','" + fecentrega + "','" + idsup + "','" + preciouni + "','" + cantidad + "')";

                SqlCommand command = new SqlCommand(query, conectar);
                command.ExecuteNonQuery();
                MessageBox.Show("Sus Datos fueron registrados Exitosamente");
                textBoxID.Text = "";
                textBoxProducto.Text = "";
                textBoxfechap.Text = "";
                textBoxfechae.Text = "";
                textBoxIdsup.Text = "";
                textBoxppu.Text = "";
                textBcant.Text = "";

                textBoxID.Focus();
                dataGridView3.Refresh();
                lbcontrol.Visible = false;
                conectar.Close();
                string datos = "select * from Compras";
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
                string prod = textBoxProducto.Text;
                string fecpedido = textBoxfechap.Text;
                string fecentrega = textBoxfechae.Text;
                string idsup = textBoxIdsup.Text;
                string preciouni = textBoxppu.Text;
                string cantidad = textBcant.Text;
                string eliminar = "DELETE FROM Compras WHERE ID_compra = '" + id + "'";
                SqlCommand cmd = new SqlCommand(eliminar, conectar);
                int conteo;
                conteo = cmd.ExecuteNonQuery();
                if (conteo == 1)
                {
                    textBoxID.Text = "";
                    textBoxfechae.Text = "";
                    textBcant.Text = "";
                    textBoxfechap.Text = "";
                    textBoxppu.Text = "";
                    textBoxProducto.Text = "";
                    textBoxIdsup.Text = "";

                    MessageBox.Show("Fueron eliminados los Datos");


                }

                else
                {
                    MessageBox.Show("No Existe esta compra");
                }

                string datos = "select * from Compras";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro que quieres regresar?", "¿Desea volver?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
              
                FormMenu Form5 = new FormMenu();
                Form5.usuario = usuario;
                Form5.MdiParent = FormPrincipal.ActiveForm;
                Form5.Show();
                this.Close();
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label8.Visible = true;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {

        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            labuser.Text = usuario;
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-710LBMG\\SQLEXPRESS;Initial Catalog=GreenPick;Integrated Security=True");
            conectar.Close();
            string datos = "select * from Compras";
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

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIdsup_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIdsup_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBcat_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBoxProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBcat_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label8.Visible = false;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                String cadena = "select ID_compra, Producto, Fecha_pedido, Fecha_entrega, Id_suplidor,Precio_unidad, Cantidad from Compras where ID_compra =" + id;
                SqlCommand command = new SqlCommand(cadena, conectar);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    textBoxProducto.Text = reader["Producto"].ToString();
                    textBoxfechap.Text = reader["Fecha_pedido"].ToString();
                    textBoxfechae.Text = reader["Fecha_entrega"].ToString();
                    textBoxIdsup.Text = reader["Id_suplidor"].ToString();
                    textBoxppu.Text = reader["Precio_unidad"].ToString();
                    textBcant.Text = reader["Cantidad"].ToString();

                }


            }
            else
            {
                DialogResult resultado = MessageBox.Show("Debe ingresar el id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butlimpiar_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "" && textBoxfechae.Text == "" && textBcant.Text == "" && textBoxfechap.Text == "" && textBoxppu.Text == "" && textBoxProducto.Text == "" && textBoxIdsup.Text == "")
            {
                MessageBox.Show("No hay datos que limpiar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBoxID.Text = "";
                textBoxfechae.Text = "";
                textBcant.Text = "";
                textBoxfechap.Text = "";
                textBoxppu.Text = "";
                textBoxProducto.Text = "";
                textBoxIdsup.Text = "";


            }

        }

        private void butmodificar_Click(object sender, EventArgs e)
        {


            if (textBoxID.Text != "")

            {
                SqlConnection conectar = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");
                conectar.Open();
                string id = textBoxID.Text;
                string prod = textBoxProducto.Text;
                string fecpedido = textBoxfechap.Text;
                string fecentrega = textBoxfechae.Text;
                string idsup = textBoxIdsup.Text;
                string preciouni = textBoxppu.Text;
                string cantidad = textBcant.Text;

                String cadena = "select * from Compras where ID_compra=" + id;
                SqlCommand command = new SqlCommand(cadena, conectar);
                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())

                {
                    string actualizar = "update Compras set Producto = '" + prod + "', Fecha_pedido = '" + fecpedido + "', Fecha_entrega = '" + fecentrega + "' , Id_suplidor = '" + idsup + "' , Precio_unidad = '" + preciouni + "', cantidad = '" + cantidad + "' where ID_compra = '" + id + "' ";
                    SqlCommand cmd = new SqlCommand(actualizar, conectar);
                    int controlador;
                    controlador = cmd.ExecuteNonQuery();
                    if (controlador == 1)
                    {
                        MessageBox.Show("Fueron modificados los Datos");
                        textBoxID.Text = "";
                        textBoxfechae.Text = "";
                        textBcant.Text = "";
                        textBoxfechap.Text = "";
                        textBoxppu.Text = "";
                        textBoxProducto.Text = "";
                        textBoxIdsup.Text = "";

                        butmodificar.Enabled = false;

                    }
                    string datos = "select * from Compras";
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
                    MessageBox.Show("No existe esta compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Ingrese el id a modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void textBoxProducto_MouseClick(object sender, MouseEventArgs e)
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

        private void textBoxfechap_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxProducto.Text != "")
            {
                butmodificar.Enabled = true;
            }

            else
            {
                butmodificar.Enabled = false;
            }

        }

        private void FormCompras_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void textBoxfechae_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxfechap.Text != "")
            {
                butmodificar.Enabled = true;
            }

            else
            {
                butmodificar.Enabled = false;
            }

        }

        private void textBoxIdsup_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxfechae.Text != "")
            {
                butmodificar.Enabled = true;
            }

            else
            {
                butmodificar.Enabled = false;
            }

        }

        private void textBoxppu_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxIdsup.Text != "")
            {
                butmodificar.Enabled = true;
            }

            else
            {
                butmodificar.Enabled = false;
            }

        }

        private void textBcant_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxppu.Text != "")
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