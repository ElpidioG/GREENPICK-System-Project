
namespace Mdi5toA
{
    partial class FormFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labcliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combocliente = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboproducto = new System.Windows.Forms.ComboBox();
            this.labprods = new System.Windows.Forms.Label();
            this.butagregar = new System.Windows.Forms.Button();
            this.textBoxCant = new System.Windows.Forms.TextBox();
            this.labelcants = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.labelprecios = new System.Windows.Forms.Label();
            this.butbuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LabNoFac = new System.Windows.Forms.Label();
            this.textBoxnumfac = new System.Windows.Forms.TextBox();
            this.butbuscardata = new System.Windows.Forms.Button();
            this.textBoxbuscar = new System.Windows.Forms.TextBox();
            this.labelno = new System.Windows.Forms.Label();
            this.butenviar = new System.Windows.Forms.Button();
            this.butdel = new System.Windows.Forms.Button();
            this.butfac = new System.Windows.Forms.Button();
            this.labfecha = new System.Windows.Forms.Label();
            this.comboborrarprod = new System.Windows.Forms.ComboBox();
            this.labelborrarp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labuser = new System.Windows.Forms.Label();
            this.labelus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sirukota", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facturación";
            // 
            // labcliente
            // 
            this.labcliente.AutoSize = true;
            this.labcliente.BackColor = System.Drawing.Color.Transparent;
            this.labcliente.Font = new System.Drawing.Font("Sirukota", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcliente.ForeColor = System.Drawing.Color.White;
            this.labcliente.Location = new System.Drawing.Point(9, 77);
            this.labcliente.Name = "labcliente";
            this.labcliente.Size = new System.Drawing.Size(56, 16);
            this.labcliente.TabIndex = 5;
            this.labcliente.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sirukota", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(142, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 50);
            this.label4.TabIndex = 20;
            this.label4.Text = "GreenPick";
            // 
            // combocliente
            // 
            this.combocliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocliente.FormattingEnabled = true;
            this.combocliente.Location = new System.Drawing.Point(9, 97);
            this.combocliente.Name = "combocliente";
            this.combocliente.Size = new System.Drawing.Size(161, 21);
            this.combocliente.TabIndex = 29;
            this.combocliente.SelectedIndexChanged += new System.EventHandler(this.combocliente_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Mdi5toA.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(627, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sirukota", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(526, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Regresar";
            this.label5.Visible = false;
            // 
            // comboproducto
            // 
            this.comboproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboproducto.FormattingEnabled = true;
            this.comboproducto.Location = new System.Drawing.Point(9, 150);
            this.comboproducto.Name = "comboproducto";
            this.comboproducto.Size = new System.Drawing.Size(161, 21);
            this.comboproducto.TabIndex = 41;
            this.comboproducto.SelectedIndexChanged += new System.EventHandler(this.comboproducto_SelectedIndexChanged);
            // 
            // labprods
            // 
            this.labprods.AutoSize = true;
            this.labprods.BackColor = System.Drawing.Color.Transparent;
            this.labprods.Font = new System.Drawing.Font("Sirukota", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labprods.ForeColor = System.Drawing.Color.White;
            this.labprods.Location = new System.Drawing.Point(9, 130);
            this.labprods.Name = "labprods";
            this.labprods.Size = new System.Drawing.Size(63, 16);
            this.labprods.TabIndex = 40;
            this.labprods.Text = "Producto";
            // 
            // butagregar
            // 
            this.butagregar.BackColor = System.Drawing.Color.LightGreen;
            this.butagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butagregar.Font = new System.Drawing.Font("Sirukota", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butagregar.ForeColor = System.Drawing.Color.Black;
            this.butagregar.Location = new System.Drawing.Point(12, 231);
            this.butagregar.Name = "butagregar";
            this.butagregar.Size = new System.Drawing.Size(121, 43);
            this.butagregar.TabIndex = 43;
            this.butagregar.Text = "Agregar";
            this.butagregar.UseVisualStyleBackColor = false;
            this.butagregar.Visible = false;
            this.butagregar.Click += new System.EventHandler(this.butagregar_Click);
            // 
            // textBoxCant
            // 
            this.textBoxCant.Location = new System.Drawing.Point(89, 205);
            this.textBoxCant.Name = "textBoxCant";
            this.textBoxCant.Size = new System.Drawing.Size(44, 20);
            this.textBoxCant.TabIndex = 47;
            this.textBoxCant.Visible = false;
            this.textBoxCant.TextChanged += new System.EventHandler(this.textBoxCant_TextChanged);
            this.textBoxCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCant_KeyPress);
            // 
            // labelcants
            // 
            this.labelcants.AutoSize = true;
            this.labelcants.BackColor = System.Drawing.Color.Transparent;
            this.labelcants.Font = new System.Drawing.Font("Sirukota", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcants.ForeColor = System.Drawing.Color.White;
            this.labelcants.Location = new System.Drawing.Point(79, 183);
            this.labelcants.Name = "labelcants";
            this.labelcants.Size = new System.Drawing.Size(66, 16);
            this.labelcants.TabIndex = 46;
            this.labelcants.Text = "Cantidad";
            this.labelcants.Visible = false;
            this.labelcants.Click += new System.EventHandler(this.labelcants_Click);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(10, 205);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.ReadOnly = true;
            this.textBoxPrecio.Size = new System.Drawing.Size(44, 20);
            this.textBoxPrecio.TabIndex = 45;
            this.textBoxPrecio.Visible = false;
            this.textBoxPrecio.TextChanged += new System.EventHandler(this.textBoxPrecio_TextChanged);
            this.textBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecio_KeyPress);
            // 
            // labelprecios
            // 
            this.labelprecios.AutoSize = true;
            this.labelprecios.BackColor = System.Drawing.Color.Transparent;
            this.labelprecios.Font = new System.Drawing.Font("Sirukota", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprecios.ForeColor = System.Drawing.Color.White;
            this.labelprecios.Location = new System.Drawing.Point(11, 183);
            this.labelprecios.Name = "labelprecios";
            this.labelprecios.Size = new System.Drawing.Size(49, 16);
            this.labelprecios.TabIndex = 44;
            this.labelprecios.Text = "Precio";
            this.labelprecios.Visible = false;
            this.labelprecios.Click += new System.EventHandler(this.labelprecios_Click);
            // 
            // butbuscar
            // 
            this.butbuscar.BackColor = System.Drawing.Color.LightGreen;
            this.butbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butbuscar.Font = new System.Drawing.Font("Sirukota", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butbuscar.ForeColor = System.Drawing.Color.Black;
            this.butbuscar.Location = new System.Drawing.Point(12, 280);
            this.butbuscar.Name = "butbuscar";
            this.butbuscar.Size = new System.Drawing.Size(121, 43);
            this.butbuscar.TabIndex = 48;
            this.butbuscar.Text = "Buscar";
            this.butbuscar.UseVisualStyleBackColor = false;
            this.butbuscar.Click += new System.EventHandler(this.butbuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 150);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.Visible = false;
            // 
            // LabNoFac
            // 
            this.LabNoFac.AutoSize = true;
            this.LabNoFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LabNoFac.Location = new System.Drawing.Point(280, 97);
            this.LabNoFac.Name = "LabNoFac";
            this.LabNoFac.Size = new System.Drawing.Size(34, 20);
            this.LabNoFac.TabIndex = 51;
            this.LabNoFac.Text = "No.";
            // 
            // textBoxnumfac
            // 
            this.textBoxnumfac.Enabled = false;
            this.textBoxnumfac.Location = new System.Drawing.Point(325, 97);
            this.textBoxnumfac.Name = "textBoxnumfac";
            this.textBoxnumfac.Size = new System.Drawing.Size(36, 20);
            this.textBoxnumfac.TabIndex = 52;
            this.textBoxnumfac.Text = "1001";
            this.textBoxnumfac.TextChanged += new System.EventHandler(this.textBoxnumfac_TextChanged);
            // 
            // butbuscardata
            // 
            this.butbuscardata.BackColor = System.Drawing.Color.LightGreen;
            this.butbuscardata.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butbuscardata.Font = new System.Drawing.Font("Sirukota", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butbuscardata.ForeColor = System.Drawing.Color.Black;
            this.butbuscardata.Location = new System.Drawing.Point(579, 285);
            this.butbuscardata.Name = "butbuscardata";
            this.butbuscardata.Size = new System.Drawing.Size(73, 32);
            this.butbuscardata.TabIndex = 53;
            this.butbuscardata.Text = "Mostrar";
            this.butbuscardata.UseVisualStyleBackColor = false;
            this.butbuscardata.Click += new System.EventHandler(this.butbuscardata_Click);
            // 
            // textBoxbuscar
            // 
            this.textBoxbuscar.Location = new System.Drawing.Point(526, 297);
            this.textBoxbuscar.Name = "textBoxbuscar";
            this.textBoxbuscar.Size = new System.Drawing.Size(36, 20);
            this.textBoxbuscar.TabIndex = 55;
            this.textBoxbuscar.Visible = false;
            this.textBoxbuscar.TextChanged += new System.EventHandler(this.textBoxbuscar_TextChanged);
            this.textBoxbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxbuscar_KeyPress);
            // 
            // labelno
            // 
            this.labelno.AutoSize = true;
            this.labelno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelno.Location = new System.Drawing.Point(481, 297);
            this.labelno.Name = "labelno";
            this.labelno.Size = new System.Drawing.Size(34, 20);
            this.labelno.TabIndex = 54;
            this.labelno.Text = "No.";
            this.labelno.Visible = false;
            // 
            // butenviar
            // 
            this.butenviar.BackColor = System.Drawing.Color.LightGreen;
            this.butenviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butenviar.Font = new System.Drawing.Font("Sirukota", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butenviar.ForeColor = System.Drawing.Color.Black;
            this.butenviar.Location = new System.Drawing.Point(579, 319);
            this.butenviar.Name = "butenviar";
            this.butenviar.Size = new System.Drawing.Size(73, 32);
            this.butenviar.TabIndex = 56;
            this.butenviar.Text = "Enviar";
            this.butenviar.UseVisualStyleBackColor = false;
            this.butenviar.Visible = false;
            this.butenviar.Click += new System.EventHandler(this.butenviar_Click);
            // 
            // butdel
            // 
            this.butdel.BackColor = System.Drawing.Color.LightGreen;
            this.butdel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butdel.Font = new System.Drawing.Font("Sirukota", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdel.ForeColor = System.Drawing.Color.Black;
            this.butdel.Location = new System.Drawing.Point(299, 329);
            this.butdel.Name = "butdel";
            this.butdel.Size = new System.Drawing.Size(121, 43);
            this.butdel.TabIndex = 8;
            this.butdel.Text = "Eliminar";
            this.butdel.UseVisualStyleBackColor = false;
            this.butdel.Visible = false;
            this.butdel.Click += new System.EventHandler(this.butdel_Click);
            // 
            // butfac
            // 
            this.butfac.BackColor = System.Drawing.Color.LightGreen;
            this.butfac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butfac.Font = new System.Drawing.Font("Sirukota", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butfac.ForeColor = System.Drawing.Color.Black;
            this.butfac.Location = new System.Drawing.Point(12, 329);
            this.butfac.Name = "butfac";
            this.butfac.Size = new System.Drawing.Size(121, 43);
            this.butfac.TabIndex = 57;
            this.butfac.Text = "Facturar";
            this.butfac.UseVisualStyleBackColor = false;
            this.butfac.Visible = false;
            this.butfac.Click += new System.EventHandler(this.button1_Click);
            // 
            // labfecha
            // 
            this.labfecha.AutoSize = true;
            this.labfecha.Location = new System.Drawing.Point(586, 100);
            this.labfecha.Name = "labfecha";
            this.labfecha.Size = new System.Drawing.Size(13, 13);
            this.labfecha.TabIndex = 58;
            this.labfecha.Text = "d";
            // 
            // comboborrarprod
            // 
            this.comboborrarprod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboborrarprod.FormattingEnabled = true;
            this.comboborrarprod.Location = new System.Drawing.Point(282, 301);
            this.comboborrarprod.Name = "comboborrarprod";
            this.comboborrarprod.Size = new System.Drawing.Size(161, 21);
            this.comboborrarprod.TabIndex = 60;
            this.comboborrarprod.Visible = false;
            this.comboborrarprod.SelectedIndexChanged += new System.EventHandler(this.comboborrarprod_SelectedIndexChanged);
            this.comboborrarprod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboborrarprod_MouseClick);
            // 
            // labelborrarp
            // 
            this.labelborrarp.AutoSize = true;
            this.labelborrarp.BackColor = System.Drawing.Color.Transparent;
            this.labelborrarp.Font = new System.Drawing.Font("Sirukota", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelborrarp.ForeColor = System.Drawing.Color.White;
            this.labelborrarp.Location = new System.Drawing.Point(302, 285);
            this.labelborrarp.Name = "labelborrarp";
            this.labelborrarp.Size = new System.Drawing.Size(63, 16);
            this.labelborrarp.TabIndex = 61;
            this.labelborrarp.Text = "Producto";
            this.labelborrarp.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labuser);
            this.panel1.Controls.Add(this.labelus);
            this.panel1.Location = new System.Drawing.Point(367, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 50);
            this.panel1.TabIndex = 62;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labuser
            // 
            this.labuser.AutoSize = true;
            this.labuser.Location = new System.Drawing.Point(52, 19);
            this.labuser.Name = "labuser";
            this.labuser.Size = new System.Drawing.Size(0, 13);
            this.labuser.TabIndex = 1;
            // 
            // labelus
            // 
            this.labelus.AutoSize = true;
            this.labelus.Location = new System.Drawing.Point(4, 19);
            this.labelus.Name = "labelus";
            this.labelus.Size = new System.Drawing.Size(46, 13);
            this.labelus.TabIndex = 0;
            this.labelus.Text = "Usuario:";
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mdi5toA.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(705, 393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelborrarp);
            this.Controls.Add(this.comboborrarprod);
            this.Controls.Add(this.labfecha);
            this.Controls.Add(this.butfac);
            this.Controls.Add(this.butenviar);
            this.Controls.Add(this.textBoxbuscar);
            this.Controls.Add(this.labelno);
            this.Controls.Add(this.butbuscardata);
            this.Controls.Add(this.textBoxnumfac);
            this.Controls.Add(this.LabNoFac);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butbuscar);
            this.Controls.Add(this.textBoxCant);
            this.Controls.Add(this.labelcants);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.labelprecios);
            this.Controls.Add(this.butagregar);
            this.Controls.Add(this.comboproducto);
            this.Controls.Add(this.labprods);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.combocliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butdel);
            this.Controls.Add(this.labcliente);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.FormFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labcliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combocliente;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboproducto;
        private System.Windows.Forms.Label labprods;
        private System.Windows.Forms.Button butagregar;
        private System.Windows.Forms.TextBox textBoxCant;
        private System.Windows.Forms.Label labelcants;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label labelprecios;
        private System.Windows.Forms.Button butbuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LabNoFac;
        private System.Windows.Forms.TextBox textBoxnumfac;
        private System.Windows.Forms.Button butbuscardata;
        private System.Windows.Forms.TextBox textBoxbuscar;
        private System.Windows.Forms.Label labelno;
        private System.Windows.Forms.Button butenviar;
        private System.Windows.Forms.Button butdel;
        private System.Windows.Forms.Button butfac;
        private System.Windows.Forms.Label labfecha;
        private System.Windows.Forms.ComboBox comboborrarprod;
        private System.Windows.Forms.Label labelborrarp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labuser;
        private System.Windows.Forms.Label labelus;
    }
}