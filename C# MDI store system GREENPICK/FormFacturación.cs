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
    public partial class FormFactura : Form
    {
        public int numero_factura;
        public string usuario;
        public string prod;
        public FormFactura()
        {
            InitializeComponent();
        }

       
        private void textBoxCant_TextChanged(object sender, EventArgs e)
        {

        }

        private void butbuscardata_Click(object sender, EventArgs e)
        {
            if (textBoxbuscar.Visible != true)
            {
                butbuscardata.Text = "Ocultar";
                textBoxbuscar.Visible = true;
                labelno.Visible = true;
           
                butenviar.Visible = true;
               

            }
            else
            {
                butbuscardata.Text = "Buscar";
                textBoxbuscar.Visible = false ;
                labelno.Visible = false;
                butenviar.Visible = false;
                dataGridView1.Visible = false;
            }



        }

        private void butenviar_Click(object sender, EventArgs e)
        {
            if (textBoxbuscar.Text != "")
            {
          try
                {
                    int numfactura = Convert.ToInt32(textBoxbuscar.Text);

                    string datos = "select * from factura where idfactura = " + numfactura;
                    SqlConnection Conectando1 = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");

                    Conectando1.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, Conectando1);
                    DataTable dt = new DataTable();
                    SqlCommand cmdvalidar = new SqlCommand(datos,Conectando1);
                    dataAdapter.Fill(dt);
                    SqlDataReader reader = cmdvalidar.ExecuteReader();

                    if (reader.Read())
                    {
                        dataGridView1.DataSource = dt;
                        dataGridView1.Visible = true;
                        Conectando1.Close();
                    }else
                    {
                        MessageBox.Show("Numero de factura no existe");
                    }

                
               
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Numero de factura no existe",ex.Message);
                }

            }
        }

        private void comboborrarprod_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-710LBMG\\SQLEXPRESS;Initial Catalog=GreenPick;Integrated Security=True");
            conectar.Open();

            string comboprod = "select ID_Producto,Producto from Productos";
            SqlCommand commandProd = new SqlCommand(comboprod, conectar);
            SqlDataAdapter daprod = new SqlDataAdapter();
            daprod.SelectCommand = commandProd;
            DataTable dtprod = new DataTable();
            daprod.Fill(dtprod);

            //Pasando Datos
            comboborrarprod.DataSource = dtprod;
            comboborrarprod.ValueMember = "ID_Producto";
            comboborrarprod.DisplayMember = "Producto";
            comboborrarprod.SelectedItem = default;
            

 

        }

        private void comboproducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboborrarprod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxbuscar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void labelprecios_Click(object sender, EventArgs e)
        {

        }

        private void labelcants_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
           
             
        }

        private void textBoxnumfac_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxnumfac.Text !="" )
            {

                SqlConnection conectar = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");
                conectar.Open();
                string id = textBoxnumfac.Text;

                String cadena = "select * from factura where idfactura=" + id;
                SqlCommand command = new SqlCommand(cadena, conectar);
                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())

                {
                    FormFacturas Facturas = new FormFacturas();
                    Facturas.numero_factura = Convert.ToInt32(textBoxnumfac.Text);
                    Facturas.Show();
                    comboborrarprod.Text = default;
                    combocliente.Text = default;
                    textBoxnumfac.Text = Convert.ToString(Convert.ToInt32(textBoxnumfac.Text) + 1);
                    labelprecios.Visible = false;
                    labelcants.Visible = false;
                    butagregar.Visible = false;
                    butfac.Visible = false;
                    labelno.Visible = false;
               
                    butenviar.Visible = false;
                    textBoxbuscar.Visible = false;
                    dataGridView1.Visible = false;
                    comboborrarprod.Visible = false;
                    butdel.Visible = false;
                    labelborrarp.Visible = false;
                }
                else
                {
                    MessageBox.Show("La factura está vacía", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            
                


            }

        }

        private void textBoxCant_KeyPress(object sender, KeyPressEventArgs e)
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

        private void butagregar_Click(object sender, EventArgs e)
        {
            if (textBoxPrecio.Text != "" && textBoxCant.Text != "" && combocliente.SelectedItem != default && comboproducto.SelectedItem != default)
            {
                comboproducto.Enabled = true;
                comboborrarprod.Visible = true;
                labelborrarp.Visible = true;
                butdel.Visible = true;
                butfac.Visible = true;

                double precio = Convert.ToDouble(textBoxPrecio.Text);
                double cantidad = Convert.ToDouble(textBoxCant.Text);
                double total = precio * cantidad;

                try
                {

                    string id = textBoxnumfac.Text;
                    string cliente = combocliente.Text;
                     prod = comboproducto.Text;
                    string price = textBoxPrecio.Text;
                    string cant = textBoxCant.Text;
                    string fecha = labfecha.Text;
                    string empleado = labuser.Text;    
                    SqlConnection connect = new SqlConnection("Data Source=DESKTOP-710LBMG\\SQLEXPRESS;Initial Catalog=GreenPick;Integrated Security=True");
                   
                    
                    connect.Open();
                    string queryinsert = "insert into factura(idfactura,nom_Cliente,nom_producto,precio,cantidad,precio_total,fecha,empleado) values ('"+id+ "','" + cliente + "','" + prod + "','" + price + "','" + cant + "','" + total.ToString() + "','" + fecha + "','" + empleado + "')";

                    SqlCommand command = new SqlCommand(queryinsert, connect);
                    command.ExecuteNonQuery();

                    textBoxPrecio.Text = "";
                    textBoxCant.Text = "";
               
                    textBoxPrecio.Visible = false;
                    textBoxCant.Visible = false;
                    butagregar.Visible = false;


                    int numfactura = Convert.ToInt32(textBoxnumfac.Text);
                    connect.Close();
                    string datos = "select * from factura where idfactura = "+numfactura;
                    SqlConnection Conectando1 = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");
                    try
                    {
                        Conectando1.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, Conectando1);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dataGridView1.Visible = true;
                        Conectando1.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                catch(Exception e1)
                {
                    MessageBox.Show("Error al insertar los datos", e1.Message);
                }
                comboproducto.SelectedItem = default;

                labelprecios.Visible = false;
                labelcants.Visible = false;
            }
            else
            {
                MessageBox.Show("campo vacio");

            }
        }

        private void butbuscar_Click(object sender, EventArgs e)
        {

            if (combocliente.Text !="" && comboproducto.Text != "")
            {

            comboproducto.Enabled = false;
            textBoxPrecio.Visible = true;
            textBoxCant.Visible = true;
            labelcants.Visible = true;
            labelprecios.Visible = true;
            butagregar.Visible = true;
            textBoxCant.Text = "";
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-710LBMG\\SQLEXPRESS;Initial Catalog=GreenPick;Integrated Security=True");
            conectar.Open();
            int indice = combocliente.SelectedIndex;
            
            string id = comboproducto.SelectedValue.ToString();
      
           
            string cadena = "select ID_producto,Producto ,Precio from Productos where ID_producto = " + id;
            SqlCommand command = new SqlCommand(cadena, conectar);
            SqlDataReader reader = command.ExecuteReader();
       

            if(reader.Read())
            {
                textBoxPrecio.Text = reader["precio"].ToString();
            
             

            }
            textBoxCant.Focus();



            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente y el producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBcant5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBcant4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBcant3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBcant2_KeyPress(object sender, KeyPressEventArgs e)
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

      
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label5.Visible = true;
        }


    

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro que quieres regresar?", "¿Desea volver?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
                FormMenu Form5 = new FormMenu();
                Form5.usuario = usuario;
                Form5.MdiParent = FormPrincipal.ActiveForm;
                Form5.Show();
            }
        }

  
 
        private void FormFactura_Load(object sender, EventArgs e)
        {
            labuser.Text = usuario;
            combocliente.Focus();

            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-710LBMG\\SQLEXPRESS;Initial Catalog=GreenPick;Integrated Security=True");
            conectar.Open();


            string combolist = "select ID_Cliente, Nombre+' '+Apellido as Nombres from Clientes";
            SqlCommand command = new SqlCommand(combolist, conectar);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);

            //Pasando Datos
           combocliente.DataSource = dt;
            combocliente.ValueMember = "ID_Cliente";
            combocliente.DisplayMember = "Nombres";



            string comboprod = "select ID_Producto,Producto from Productos";
            SqlCommand commandProd = new SqlCommand(comboprod, conectar);
            SqlDataAdapter daprod = new SqlDataAdapter();
            daprod.SelectCommand = commandProd;
            DataTable dtprod = new DataTable();
            daprod.Fill(dtprod);

            //Pasando Datos
            comboproducto.DataSource = dtprod;
            comboproducto.ValueMember = "ID_Producto";
            comboproducto.DisplayMember = "Producto";
            comboproducto.SelectedItem = default;
            combocliente.SelectedItem = default;



            //cargando factura num
            String cadena = "select max(idfactura)+1 as numfact from factura ";
            SqlCommand commando = new SqlCommand(cadena, conectar);
            SqlDataReader reader = commando.ExecuteReader();


            if (reader.Read())
            {
                textBoxnumfac.Text = reader["numfact"].ToString();


            }
        }

        private void groupBfactura_Enter(object sender, EventArgs e)
        {

        }

  

        private void butdel_Click(object sender, EventArgs e)
        {
            if(comboborrarprod.SelectedItem == default)
            {
                MessageBox.Show("Seleccione un producto", "Error");

            }
            else
            {
    
                SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-710LBMG\\SQLEXPRESS;Initial Catalog=GreenPick;Integrated Security=True");
                conectar.Open();
                string numfactura = textBoxnumfac.Text;
                string nombrep = comboborrarprod.Text;
                string borrar = "delete factura where idfactura = '" + numfactura + "' and nom_producto = '" + nombrep + "'";
                SqlCommand sql = new SqlCommand(borrar, conectar);
                sql.ExecuteNonQuery();
                string datos = "select * from factura where idfactura = " + numfactura;
                SqlConnection Conectando1 = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");
                try
                {
                    Conectando1.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, Conectando1);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Visible = true;
                    Conectando1.Close();
                }
              
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                comboproducto.SelectedItem = default;
                comboborrarprod.SelectedItem = default;
            }


        }

        private void labfecha_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            labfecha.Text = DateTime.Now.ToString();
        }

        private void combocliente_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void labclien_Click(object sender, EventArgs e)
        {

        }
    }
}
