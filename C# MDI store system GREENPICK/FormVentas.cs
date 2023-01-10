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
    public partial class FormVentas : Form
    {
        public string usuario;
        public int List = 0;
        public int indice;

        public FormVentas()
        {
            InitializeComponent();
        }

        private void butbuscar_Click(object sender, EventArgs e)
        {

            if (comboventas.Text != "")
            {
                try
                {
                    dataGridView1.Enabled = true;
                    int numfactura = Convert.ToInt32(comboventas.Text);

                    string datos = "select * from factura where idfactura = " + numfactura;
                    SqlConnection Conectando1 = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");

                    Conectando1.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, Conectando1);
                    DataTable dt = new DataTable();
                    SqlCommand cmdvalidar = new SqlCommand(datos, Conectando1);
                    dataAdapter.Fill(dt);
                    SqlDataReader reader = cmdvalidar.ExecuteReader();

                    if (reader.Read())
                    {
                        dataGridView1.DataSource = dt;
                        dataGridView1.Visible = true;
                        Conectando1.Close();
                    }
                    else
                    {
                        MessageBox.Show("Numero de factura no existe");
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Numero de factura no existe", ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el numero de factura","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            }
            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List = e.RowIndex;
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            labnom.Text = usuario;

        }

        private void textBbuscar_TextChanged(object sender, EventArgs e)
        {
            
            
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

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label8.Visible = false;

        }

        private void textBbuscar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboventas.Text == "")
            {
                {
                    MessageBox.Show("No hay datos que limpiar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                comboventas.Text = default;
            }
     

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {


            SqlConnection Conectando1 = new SqlConnection("Data Source = DESKTOP-710LBMG\\SQLEXPRESS; Initial Catalog = GreenPick; Integrated Security = True");

            string combovent= "select distinct(idfactura) as factura, nom_Cliente from factura";
            SqlCommand commandProd = new SqlCommand(combovent, Conectando1);
            SqlDataAdapter daprod = new SqlDataAdapter();
            daprod.SelectCommand = commandProd;
            DataTable dtprod = new DataTable();
            daprod.Fill(dtprod);

            //Pasando Datos
            comboventas.DataSource = dtprod;
            comboventas.ValueMember = "nom_Cliente";
            comboventas.DisplayMember = "factura";
            comboventas.SelectedItem = default;
        


 
        }

        private void butvent_Click(object sender, EventArgs e)
        {
            Xventas informe = new Xventas();
            informe.fecha = comboventasaño.Text;
            informe.Show();
            
        }

        private void comboventasaño_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-710LBMG\\SQLEXPRESS;Initial Catalog=GreenPick;Integrated Security=True");
            conectar.Open();

            string comboaño = "select  distinct(datepart(YY,fecha)) as año from factura";
            SqlCommand commandfecha = new SqlCommand(comboaño, conectar);
            SqlDataAdapter dafecha = new SqlDataAdapter();
            dafecha.SelectCommand = commandfecha;
            DataTable dt = new DataTable();
            dafecha.Fill(dt);

            //Pasando Datos
            comboventasaño.DataSource = dt;
            comboventasaño.ValueMember = "año";
            comboventasaño.DisplayMember = "año";
            comboventasaño.SelectedItem = default;

        }

        private void comboventasaño_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-710LBMG\\SQLEXPRESS;Initial Catalog=GreenPick;Integrated Security=True");
            conexion.Open();

            if (comboventas.Text == default)
                {
                MessageBox.Show("Introduzca un ID", "Error de eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboventas.Focus();
            }
            else
            {
                string id = comboventas.Text;
                string eliminar = "Delete from factura where idfactura = '" + id + "'";

                SqlCommand cmd = new SqlCommand(eliminar, conexion);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Se eliminaron los datos con exito!");
                comboventas.Text = "";
              

                /*
                else
                {
                    MessageBox.Show("No se elimino ningun registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexion.Close();
                }
                */

                //actualizando datagriview
                SqlConnection conectando = new SqlConnection("Data Source=DESKTOP-710LBMG\\SQLEXPRESS;Initial Catalog=GreenPick;Integrated Security=True");
                conectando.Open();

                string datos = "Select * from factura";
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(datos, conectando);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conectando.Close();
                  

                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }
            
        }
    }
}
