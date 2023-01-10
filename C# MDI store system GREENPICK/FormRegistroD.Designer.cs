
namespace Mdi5toA
{
    partial class FormRegistroD
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxdescripcion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butborrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.butbuscar = new System.Windows.Forms.Button();
            this.butlimpiar = new System.Windows.Forms.Button();
            this.lbcontrol = new System.Windows.Forms.Label();
            this.butmodificar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labnom = new System.Windows.Forms.Label();
            this.labelus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(354, 139);
            this.dataGridView3.Name = "dataGridView3";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.Size = new System.Drawing.Size(430, 168);
            this.dataGridView3.TabIndex = 69;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(122, 139);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(52, 22);
            this.textBoxID.TabIndex = 1;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.BackColor = System.Drawing.Color.Transparent;
            this.labelId.Font = new System.Drawing.Font("Sirukota", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.Color.White;
            this.labelId.Location = new System.Drawing.Point(91, 139);
            this.labelId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(27, 25);
            this.labelId.TabIndex = 67;
            this.labelId.Text = "Id";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxdescripcion
            // 
            this.textBoxdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxdescripcion.Location = new System.Drawing.Point(151, 226);
            this.textBoxdescripcion.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxdescripcion.Name = "textBoxdescripcion";
            this.textBoxdescripcion.Size = new System.Drawing.Size(189, 22);
            this.textBoxdescripcion.TabIndex = 3;
            this.textBoxdescripcion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxdescripcion_MouseClick);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(151, 181);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(189, 22);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxNombre_MouseClick);
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sirukota", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 64;
            this.label3.Text = "Descripción";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sirukota", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sirukota", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 67);
            this.label1.TabIndex = 62;
            this.label1.Text = "Registro de Departamentos";
            // 
            // butborrar
            // 
            this.butborrar.BackColor = System.Drawing.Color.Black;
            this.butborrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butborrar.Font = new System.Drawing.Font("Sirukota", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butborrar.ForeColor = System.Drawing.Color.White;
            this.butborrar.Location = new System.Drawing.Point(132, 277);
            this.butborrar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.butborrar.Name = "butborrar";
            this.butborrar.Size = new System.Drawing.Size(102, 30);
            this.butborrar.TabIndex = 5;
            this.butborrar.Text = "Borrar";
            this.butborrar.UseVisualStyleBackColor = false;
            this.butborrar.Click += new System.EventHandler(this.butborrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Sirukota", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(9, 277);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Mdi5toA.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(746, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Sirukota", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(644, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 25);
            this.label9.TabIndex = 75;
            this.label9.Text = "Regresar";
            this.label9.Visible = false;
            // 
            // butbuscar
            // 
            this.butbuscar.BackColor = System.Drawing.Color.Black;
            this.butbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butbuscar.Font = new System.Drawing.Font("Sirukota", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butbuscar.ForeColor = System.Drawing.Color.White;
            this.butbuscar.Location = new System.Drawing.Point(176, 135);
            this.butbuscar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.butbuscar.Name = "butbuscar";
            this.butbuscar.Size = new System.Drawing.Size(72, 30);
            this.butbuscar.TabIndex = 76;
            this.butbuscar.Text = "Buscar";
            this.butbuscar.UseVisualStyleBackColor = false;
            this.butbuscar.Click += new System.EventHandler(this.butbuscar_Click);
            // 
            // butlimpiar
            // 
            this.butlimpiar.BackColor = System.Drawing.Color.Black;
            this.butlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butlimpiar.Font = new System.Drawing.Font("Sirukota", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butlimpiar.ForeColor = System.Drawing.Color.White;
            this.butlimpiar.Location = new System.Drawing.Point(260, 135);
            this.butlimpiar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.butlimpiar.Name = "butlimpiar";
            this.butlimpiar.Size = new System.Drawing.Size(80, 30);
            this.butlimpiar.TabIndex = 95;
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
            this.lbcontrol.Location = new System.Drawing.Point(127, 325);
            this.lbcontrol.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbcontrol.Name = "lbcontrol";
            this.lbcontrol.Size = new System.Drawing.Size(0, 25);
            this.lbcontrol.TabIndex = 97;
            this.lbcontrol.Visible = false;
            // 
            // butmodificar
            // 
            this.butmodificar.BackColor = System.Drawing.Color.Black;
            this.butmodificar.Enabled = false;
            this.butmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butmodificar.Font = new System.Drawing.Font("Sirukota", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butmodificar.ForeColor = System.Drawing.Color.White;
            this.butmodificar.Location = new System.Drawing.Point(246, 277);
            this.butmodificar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.butmodificar.Name = "butmodificar";
            this.butmodificar.Size = new System.Drawing.Size(102, 30);
            this.butmodificar.TabIndex = 98;
            this.butmodificar.Text = "Modificar";
            this.butmodificar.UseVisualStyleBackColor = false;
            this.butmodificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labnom);
            this.panel1.Controls.Add(this.labelus);
            this.panel1.Location = new System.Drawing.Point(9, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 36);
            this.panel1.TabIndex = 99;
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
            // FormRegistroD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mdi5toA.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butmodificar);
            this.Controls.Add(this.lbcontrol);
            this.Controls.Add(this.butlimpiar);
            this.Controls.Add(this.butbuscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butborrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxdescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormRegistroD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Registro de departamentos";
            this.Load += new System.EventHandler(this.FormRegistroD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxdescripcion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butborrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button butbuscar;
        private System.Windows.Forms.Button butlimpiar;
        private System.Windows.Forms.Label lbcontrol;
        private System.Windows.Forms.Button butmodificar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labnom;
        private System.Windows.Forms.Label labelus;
    }
}