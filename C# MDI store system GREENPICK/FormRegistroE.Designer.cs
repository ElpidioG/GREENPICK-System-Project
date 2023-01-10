
namespace Mdi5toA
{
    partial class FormRegistroE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.butborrar = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textBfechac = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxfechan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxcargo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxapellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxiddep = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.butbuscar = new System.Windows.Forms.Button();
            this.butlimpiar = new System.Windows.Forms.Button();
            this.lbcontrol = new System.Windows.Forms.Label();
            this.butmodificar = new System.Windows.Forms.Button();
            this.btCargar = new System.Windows.Forms.Button();
            this.btADD = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labnom = new System.Windows.Forms.Label();
            this.labelus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butborrar
            // 
            this.butborrar.BackColor = System.Drawing.Color.Black;
            this.butborrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butborrar.Font = new System.Drawing.Font("Sirukota", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butborrar.ForeColor = System.Drawing.Color.White;
            this.butborrar.Location = new System.Drawing.Point(146, 404);
            this.butborrar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.butborrar.Name = "butborrar";
            this.butborrar.Size = new System.Drawing.Size(102, 30);
            this.butborrar.TabIndex = 9;
            this.butborrar.Text = "Borrar";
            this.butborrar.UseVisualStyleBackColor = false;
            this.butborrar.Click += new System.EventHandler(this.butborrar_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(392, 104);
            this.dataGridView3.Name = "dataGridView3";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.Size = new System.Drawing.Size(589, 283);
            this.dataGridView3.TabIndex = 43;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            this.dataGridView3.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView3_CellMouseClick);
            // 
            // textBfechac
            // 
            this.textBfechac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBfechac.Location = new System.Drawing.Point(251, 323);
            this.textBfechac.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBfechac.Name = "textBfechac";
            this.textBfechac.Size = new System.Drawing.Size(122, 22);
            this.textBfechac.TabIndex = 6;
            this.textBfechac.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBfechac_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Sirukota", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 326);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "Fecha de Contratación";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxfechan
            // 
            this.textBoxfechan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxfechan.Location = new System.Drawing.Point(251, 236);
            this.textBoxfechan.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxfechan.Name = "textBoxfechan";
            this.textBoxfechan.Size = new System.Drawing.Size(122, 22);
            this.textBoxfechan.TabIndex = 4;
            this.textBoxfechan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxfechan_MouseClick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sirukota", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 45);
            this.label4.TabIndex = 38;
            this.label4.Text = "Fecha de Nacimiento";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxcargo
            // 
            this.textBoxcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcargo.Location = new System.Drawing.Point(251, 281);
            this.textBoxcargo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxcargo.Name = "textBoxcargo";
            this.textBoxcargo.Size = new System.Drawing.Size(122, 22);
            this.textBoxcargo.TabIndex = 5;
            this.textBoxcargo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxcargo_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sirukota", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(78, 362);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Id Departamento";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Sirukota", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(173, 283);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Cargo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(178, 106);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(42, 29);
            this.textBoxID.TabIndex = 1;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.BackColor = System.Drawing.Color.Transparent;
            this.labelId.Font = new System.Drawing.Font("Sirukota", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.Color.White;
            this.labelId.Location = new System.Drawing.Point(139, 108);
            this.labelId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(27, 25);
            this.labelId.TabIndex = 33;
            this.labelId.Text = "Id";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Sirukota", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(23, 404);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxapellido
            // 
            this.textBoxapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxapellido.Location = new System.Drawing.Point(251, 193);
            this.textBoxapellido.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxapellido.Name = "textBoxapellido";
            this.textBoxapellido.Size = new System.Drawing.Size(122, 22);
            this.textBoxapellido.TabIndex = 3;
            this.textBoxapellido.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxapellido_MouseClick);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(251, 148);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(122, 22);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxNombre_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sirukota", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(146, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Apellido";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sirukota", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(156, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sirukota", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(214, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 67);
            this.label1.TabIndex = 27;
            this.label1.Text = "Registro de Empleados";
            // 
            // textBoxiddep
            // 
            this.textBoxiddep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxiddep.Location = new System.Drawing.Point(251, 361);
            this.textBoxiddep.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxiddep.Name = "textBoxiddep";
            this.textBoxiddep.Size = new System.Drawing.Size(122, 22);
            this.textBoxiddep.TabIndex = 7;
            this.textBoxiddep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxiddep_MouseClick);
            this.textBoxiddep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxiddep_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Mdi5toA.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(1254, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Sirukota", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1151, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 73;
            this.label8.Text = "Regresar";
            this.label8.Visible = false;
            // 
            // butbuscar
            // 
            this.butbuscar.BackColor = System.Drawing.Color.Black;
            this.butbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butbuscar.Font = new System.Drawing.Font("Sirukota", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butbuscar.ForeColor = System.Drawing.Color.White;
            this.butbuscar.Location = new System.Drawing.Point(226, 106);
            this.butbuscar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.butbuscar.Name = "butbuscar";
            this.butbuscar.Size = new System.Drawing.Size(77, 30);
            this.butbuscar.TabIndex = 74;
            this.butbuscar.Text = "Buscar";
            this.butbuscar.UseVisualStyleBackColor = false;
            this.butbuscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // butlimpiar
            // 
            this.butlimpiar.BackColor = System.Drawing.Color.Black;
            this.butlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butlimpiar.Font = new System.Drawing.Font("Sirukota", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butlimpiar.ForeColor = System.Drawing.Color.White;
            this.butlimpiar.Location = new System.Drawing.Point(307, 106);
            this.butlimpiar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.butlimpiar.Name = "butlimpiar";
            this.butlimpiar.Size = new System.Drawing.Size(78, 30);
            this.butlimpiar.TabIndex = 96;
            this.butlimpiar.Text = "Limpiar";
            this.butlimpiar.UseVisualStyleBackColor = false;
            this.butlimpiar.Click += new System.EventHandler(this.butlimpiar_Click);
            // 
            // lbcontrol
            // 
            this.lbcontrol.AutoSize = true;
            this.lbcontrol.BackColor = System.Drawing.Color.Transparent;
            this.lbcontrol.Font = new System.Drawing.Font("Sirukota", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcontrol.ForeColor = System.Drawing.Color.White;
            this.lbcontrol.Location = new System.Drawing.Point(399, 409);
            this.lbcontrol.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbcontrol.Name = "lbcontrol";
            this.lbcontrol.Size = new System.Drawing.Size(0, 25);
            this.lbcontrol.TabIndex = 97;
            this.lbcontrol.Visible = false;
            this.lbcontrol.Click += new System.EventHandler(this.lbcontrol_Click);
            // 
            // butmodificar
            // 
            this.butmodificar.BackColor = System.Drawing.Color.Black;
            this.butmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butmodificar.Font = new System.Drawing.Font("Sirukota", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butmodificar.ForeColor = System.Drawing.Color.White;
            this.butmodificar.Location = new System.Drawing.Point(269, 403);
            this.butmodificar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.butmodificar.Name = "butmodificar";
            this.butmodificar.Size = new System.Drawing.Size(102, 30);
            this.butmodificar.TabIndex = 98;
            this.butmodificar.Text = "Modificar";
            this.butmodificar.UseVisualStyleBackColor = false;
            this.butmodificar.Click += new System.EventHandler(this.butmodificar_Click);
            // 
            // btCargar
            // 
            this.btCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCargar.Location = new System.Drawing.Point(1015, 341);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(136, 32);
            this.btCargar.TabIndex = 99;
            this.btCargar.Text = "Cargar";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // btADD
            // 
            this.btADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btADD.Location = new System.Drawing.Point(1160, 340);
            this.btADD.Name = "btADD";
            this.btADD.Size = new System.Drawing.Size(136, 32);
            this.btADD.TabIndex = 100;
            this.btADD.Text = "ADD";
            this.btADD.UseVisualStyleBackColor = true;
            this.btADD.Click += new System.EventHandler(this.btADD_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(1039, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(235, 221);
            this.pictureBox2.TabIndex = 101;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(1093, 379);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(136, 32);
            this.btBuscar.TabIndex = 102;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labnom);
            this.panel1.Controls.Add(this.labelus);
            this.panel1.Location = new System.Drawing.Point(5, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 36);
            this.panel1.TabIndex = 103;
            // 
            // labnom
            // 
            this.labnom.AutoSize = true;
            this.labnom.Location = new System.Drawing.Point(52, 19);
            this.labnom.Name = "labnom";
            this.labnom.Size = new System.Drawing.Size(0, 13);
            this.labnom.TabIndex = 1;
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
            // FormRegistroE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mdi5toA.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1308, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btADD);
            this.Controls.Add(this.btCargar);
            this.Controls.Add(this.butmodificar);
            this.Controls.Add(this.lbcontrol);
            this.Controls.Add(this.butlimpiar);
            this.Controls.Add(this.butbuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxiddep);
            this.Controls.Add(this.butborrar);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.textBfechac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxfechan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxcargo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxapellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormRegistroE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Registro de Empleados";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butborrar;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBfechac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxfechan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxcargo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxapellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxiddep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button butbuscar;
        private System.Windows.Forms.Button butlimpiar;
        private System.Windows.Forms.Label lbcontrol;
        private System.Windows.Forms.Button butmodificar;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.Button btADD;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labnom;
        private System.Windows.Forms.Label labelus;
    }
}