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
    public partial class FormRegistroP : Form

    {
        public int indice;
        public int List;
        public string usuario;

        public FormRegistroP()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "" && textBoxProducto.Text != "" && textBoxPrecio.Text != "" && textBoxCantidad.Text != "" && textBoxIdsup.Text != "" && textBcat.Text != "" && (radioButton1.Checked == true || radioButton2.Checked == true))

            {
                SqlConnection conectar = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");
                conectar.Open();
                string id = textBoxID.Text;
                string prod = textBoxProducto.Text;
                string precio = textBoxPrecio.Text;
                string cantidad = textBoxCantidad.Text;
                string idsup = textBoxIdsup.Text;
                string categoria = textBcat.Text;
                string estado = "0";

                if (radioButton1.Checked == true)
                {
                    estado = "1";
                }
                else if (radioButton2.Checked == true)
                {
                    estado = "0";
                }


                string query = "insert into productos Values('" + id + "','" + prod + "','" + precio + "','" + cantidad + "','" + idsup + "','" + categoria + "','" + estado + "')";

                SqlCommand command = new SqlCommand(query, conectar);
                command.ExecuteNonQuery();
                MessageBox.Show("Sus Datos fueron registrados Exitosamente");
                textBoxID.Text = "";
                textBoxProducto.Text = "";
                textBoxPrecio.Text = "";
                textBoxCantidad.Text = "";
                textBoxIdsup.Text = "";
                textBcat.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;

                textBoxID.Focus();
                dataGridView3.Refresh();
                lbcontrol.Visible = false;
                conectar.Close();
                string datos = "select * from Productos";
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

        private void FormRegistroP_Load(object sender, EventArgs e)
        {
            labnom.Text = usuario;
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-710LBMG\\SQLEXPRESS;Initial Catalog=GreenPick;Integrated Security=True");
            conectar.Close();
            string datos = "select * from productos";
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
            /*   indice = dataGridView3.Rows.Add();

               //fila 1
               dataGridView3.Rows[indice].Cells[0].Value = "1";
               dataGridView3.Rows[indice].Cells[1].Value = "Ensalada Verde";
               dataGridView3.Rows[indice].Cells[2].Value = "400";
               dataGridView3.Rows[indice].Cells[3].Value = "100";
               dataGridView3.Rows[indice].Cells[4].Value = "3";
               dataGridView3.Rows[indice].Cells[5].Value = "1";
               dataGridView3.Rows[indice].Cells[6].Value = "Disponible";
               indice = dataGridView3.Rows.Add();
               //fila 2
               dataGridView3.Rows[indice].Cells[0].Value = "2";
               dataGridView3.Rows[indice].Cells[1].Value = "Ensalada Cesar";
               dataGridView3.Rows[indice].Cells[2].Value = "550";
               dataGridView3.Rows[indice].Cells[3].Value = "200";
               dataGridView3.Rows[indice].Cells[4].Value = "3";
               dataGridView3.Rows[indice].Cells[5].Value = "1";
               dataGridView3.Rows[indice].Cells[6].Value = "Disponible";
               indice = dataGridView3.Rows.Add();
               //fila 3
               dataGridView3.Rows[indice].Cells[0].Value = "3";
               dataGridView3.Rows[indice].Cells[1].Value = "Ensalada Roja";
               dataGridView3.Rows[indice].Cells[2].Value = "450";
               dataGridView3.Rows[indice].Cells[3].Value = "70";
               dataGridView3.Rows[indice].Cells[4].Value = "3";
               dataGridView3.Rows[indice].Cells[5].Value = "1";
               dataGridView3.Rows[indice].Cells[6].Value = "Disponible";
               indice = dataGridView3.Rows.Add();
               //fila 4
               dataGridView3.Rows[indice].Cells[0].Value = "4";
               dataGridView3.Rows[indice].Cells[1].Value = "Ensalada Rusa";
               dataGridView3.Rows[indice].Cells[2].Value = "360";
               dataGridView3.Rows[indice].Cells[3].Value = "170";
               dataGridView3.Rows[indice].Cells[4].Value = "3";
               dataGridView3.Rows[indice].Cells[5].Value = "1";
               dataGridView3.Rows[indice].Cells[6].Value = "Disponible";
               indice = dataGridView3.Rows.Add();
               //fila 5
               dataGridView3.Rows[indice].Cells[0].Value = "5";
               dataGridView3.Rows[indice].Cells[1].Value = "Ensalada Griega";
               dataGridView3.Rows[indice].Cells[2].Value = "370";
               dataGridView3.Rows[indice].Cells[3].Value = "150";
               dataGridView3.Rows[indice].Cells[4].Value = "3";
               dataGridView3.Rows[indice].Cells[5].Value = "1";
               dataGridView3.Rows[indice].Cells[6].Value = "Disponible";
             */
            this.dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);


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
                string precio = textBoxPrecio.Text;
                string cantidad = textBoxCantidad.Text;
                string idsup = textBoxIdsup.Text;
                string categoria = textBcat.Text;
                string estado = "0";
                string eliminar = "DELETE FROM Productos WHERE ID_producto = '" + id + "'";
                SqlCommand cmd = new SqlCommand(eliminar, conectar);
                int conteo;
                conteo = cmd.ExecuteNonQuery();
                if (conteo == 1)
                {
                    textBoxID.Text = "";
                    textBoxProducto.Text = "";
                    textBoxPrecio.Text = "";
                    textBoxCantidad.Text = "";
                    textBoxIdsup.Text = "";
                    textBcat.Text = "";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
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

        private void FormRegistroP_MouseHover(object sender, EventArgs e)
        {


        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label8.Visible = false;
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

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

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label8.Visible = true;
        }

        private void butbuscar_Click(object sender, EventArgs e)
        {


            if (textBoxID.Text != "")
            {
                SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-710LBMG\\SQLEXPRESS;Initial Catalog=GreenPick;Integrated Security=True");
                conectar.Open();


                String id = textBoxID.Text;
        
                String cadena = "select ID_producto, Producto, Precio, Cantidad, ID_suplidor, ID_categoria, Estado from Productos where ID_producto = " + id;
                SqlCommand command = new SqlCommand(cadena, conectar);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    textBoxProducto.Text = reader["Producto"].ToString();
                    textBoxPrecio.Text = reader["Precio"].ToString();
                    textBoxCantidad.Text = reader["Cantidad"].ToString();
                    textBoxIdsup.Text = reader["ID_suplidor"].ToString();
                    textBcat.Text = reader["ID_categoria"].ToString();

                    if (reader["Estado"].ToString() == "True")
                    {
                        radioButton1.Checked = true;
                        radioButton2.Checked = false;
                    }
                    else if (reader["Estado"].ToString() == "False")
                    {
                        radioButton2.Checked = true;
                        radioButton1.Checked = false;
                    }

                }


            }
            else
            {
                DialogResult resultado = MessageBox.Show("Debe ingresar el id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butlimpiar_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "" && textBoxProducto.Text == "" && textBoxPrecio.Text == "" && textBoxCantidad.Text == "" && textBoxIdsup.Text == "" && textBcat.Text == "" && radioButton1.Checked == false && radioButton1.Checked == false)
            {
                MessageBox.Show("No hay datos que limpiar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBoxID.Text = "";
                textBoxProducto.Text = "";
                textBoxPrecio.Text = "";
                textBoxCantidad.Text = "";
                textBoxIdsup.Text = "";
                textBcat.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;

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
                string precio = textBoxPrecio.Text;
                string cantidad = textBoxCantidad.Text;
                string idsup = textBoxIdsup.Text;
                string categoria = textBcat.Text;
                string estado = "0";

                String cadena = "select * from productos where ID_producto=" + id;

                SqlCommand command = new SqlCommand(cadena, conectar);
                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())

                {

                    string actualizar = "update Productos set Productos = '" + prod + "', Precio = '" + precio + "', Cantidad = '" + cantidad + "' , ID_suplidor = '" + idsup + "' , ID_categoria = '" + categoria + "', Estado = '" + estado + "' where ID_producto = '" + id + "' ";
                    SqlCommand cmd = new SqlCommand(actualizar, conectar);
                    int controlador;
                    controlador = cmd.ExecuteNonQuery();
                    if (controlador == 1)
                    {
                        MessageBox.Show("Fueron modificados los Datos");
                        textBoxID.Text = "";
                        textBoxProducto.Text = "";
                        textBoxPrecio.Text = "";
                        textBoxCantidad.Text = "";
                        textBoxIdsup.Text = "";
                        textBcat.Text = "";
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;

                        butmodificar.Enabled = false;


                    }
                    string datos = "select * from Productos";
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
                    MessageBox.Show("No existe este producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void textBoxPrecio_MouseClick(object sender, MouseEventArgs e)
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

        private void textBoxCantidad_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPrecio.Text != "")
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
            if (textBoxCantidad.Text != "")
            {
                butmodificar.Enabled = true;
            }

            else
            {
                butmodificar.Enabled = false;
            }

        }

        private void textBcat_MouseClick(object sender, MouseEventArgs e)
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

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBcat.Text != "")
            {
                butmodificar.Enabled = true;
            }

            else
            {
                butmodificar.Enabled = false;
            }

        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBcat.Text != "")
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
                 //   conectar.Open();
                    string id = textBoxID.Text;
                    string prod = textBoxProducto.Text;
                    string precio = textBoxPrecio.Text;
                    string cantidad = textBoxCantidad.Text;
                    string idsup = textBoxIdsup.Text;
                    string categoria = textBcat.Text;
                    string estado = "0";

                    string cadena = "Insert into Productos(ID_producto, Producto, Precio, Cantidad, ID_suplidor,ID_categoria,Estado,imagen) Values(@id , @prod, @precio,@cantidad,@idsup,@categoria,@estado, @imagen)";
                        SqlCommand cmd = new SqlCommand(cadena, conectar);
                        cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@prod", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@precio", System.Data.SqlDbType.Decimal);
                        cmd.Parameters.Add("@cantidad", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@idsup", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@categoria", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@estado", System.Data.SqlDbType.Bit);

                        //Ensamble
                        cmd.Parameters.Add("@imagen", System.Data.SqlDbType.Image);

                        cmd.Parameters["@id"].Value = int.Parse(textBoxID.Text);
                        cmd.Parameters["@prod"].Value = textBoxProducto.Text;
                    cmd.Parameters["@precio"].Value = Convert.ToDecimal(textBoxPrecio.Text);
                        cmd.Parameters["@cantidad"].Value = int.Parse(textBoxCantidad.Text);
                        cmd.Parameters["@idsup"].Value = int.Parse(textBoxIdsup.Text);
                        cmd.Parameters["@categoria"].Value = int.Parse(textBcat.Text);

                    if(radioButton1.Checked==true)
                    {
                        cmd.Parameters["@estado"].Value = 1;
                    }else if (radioButton2.Checked == true)
                    {
                        cmd.Parameters["@estado"].Value = 2;
                    }

                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        pictureBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        cmd.Parameters["@imagen"].Value = ms.GetBuffer();

                        conectar.Open();
                        cmd.ExecuteNonQuery();
                        conectar.Close();

                    }

                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }



                string datos = "select * from Productos";
                SqlConnection Conectando = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");
                Conectando.Open();
           
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
                }
            }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
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
                    string buscar = "select * from Productos where ID_producto =" + id;
                    SqlCommand command = new SqlCommand(buscar, conectar);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        MemoryStream memory = new MemoryStream((byte[])reader["imagen"]);
                        Bitmap bm = new Bitmap(memory);
                        pictureBox2.Image = bm;
                        textBoxProducto.Text = reader["Producto"].ToString();
                        textBoxPrecio.Text = reader["Precio"].ToString();
                        textBoxCantidad.Text = reader["Cantidad"].ToString();
                        textBoxIdsup.Text = reader["ID_suplidor"].ToString();
                        textBcat.Text = reader["ID_categoria"].ToString();

                        if (reader["Estado"].ToString() == "True")
                        {
                            radioButton1.Checked = true;
                            radioButton2.Checked = false;
                        }
                        else if (reader["Estado"].ToString() == "False")
                        {
                            radioButton2.Checked = true;
                            radioButton1.Checked = false;
                        }

                    }
                }

                catch (Exception e1)
                {
                    MessageBox.Show("el codigo no existe", e1.Message);
                }

            }
        }
    }
    }
    