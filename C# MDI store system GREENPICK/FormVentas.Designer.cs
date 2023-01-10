
namespace Mdi5toA
{
    partial class FormVentas
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butbuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butlimp = new System.Windows.Forms.Button();
            this.comboventas = new System.Windows.Forms.ComboBox();
            this.butvent = new System.Windows.Forms.Button();
            this.comboventasaño = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labnom = new System.Windows.Forms.Label();
            this.labelus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butdelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sirukota", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(302, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 67);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ventas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // butbuscar
            // 
            this.butbuscar.BackColor = System.Drawing.Color.Black;
            this.butbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butbuscar.Font = new System.Drawing.Font("Sirukota", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butbuscar.ForeColor = System.Drawing.Color.White;
            this.butbuscar.Location = new System.Drawing.Point(127, 106);
            this.butbuscar.Name = "butbuscar";
            this.butbuscar.Size = new System.Drawing.Size(98, 30);
            this.butbuscar.TabIndex = 2;
            this.butbuscar.Text = "Buscar";
            this.butbuscar.UseVisualStyleBackColor = false;
            this.butbuscar.Click += new System.EventHandler(this.butbuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Mdi5toA.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(745, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
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
            this.label8.Location = new System.Drawing.Point(642, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 71;
            this.label8.Text = "Regresar";
            this.label8.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sirukota", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 72;
            this.label2.Text = "ID";
            // 
            // butlimp
            // 
            this.butlimp.BackColor = System.Drawing.Color.Black;
            this.butlimp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butlimp.Font = new System.Drawing.Font("Sirukota", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butlimp.ForeColor = System.Drawing.Color.White;
            this.butlimp.Location = new System.Drawing.Point(377, 106);
            this.butlimp.Name = "butlimp";
            this.butlimp.Size = new System.Drawing.Size(98, 30);
            this.butlimp.TabIndex = 73;
            this.butlimp.Text = "Limpiar";
            this.butlimp.UseVisualStyleBackColor = false;
            this.butlimp.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboventas
            // 
            this.comboventas.FormattingEnabled = true;
            this.comboventas.Location = new System.Drawing.Point(40, 114);
            this.comboventas.Name = "comboventas";
            this.comboventas.Size = new System.Drawing.Size(81, 21);
            this.comboventas.TabIndex = 74;
            this.comboventas.Text = "Selecionar";
            this.comboventas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // butvent
            // 
            this.butvent.BackColor = System.Drawing.Color.Black;
            this.butvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butvent.Font = new System.Drawing.Font("Sirukota", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butvent.ForeColor = System.Drawing.Color.White;
            this.butvent.Location = new System.Drawing.Point(665, 106);
            this.butvent.Name = "butvent";
            this.butvent.Size = new System.Drawing.Size(98, 30);
            this.butvent.TabIndex = 75;
            this.butvent.Text = "Mostrar";
            this.butvent.UseVisualStyleBackColor = false;
            this.butvent.Click += new System.EventHandler(this.butvent_Click);
            // 
            // comboventasaño
            // 
            this.comboventasaño.FormattingEnabled = true;
            this.comboventasaño.Location = new System.Drawing.Point(567, 113);
            this.comboventasaño.Name = "comboventasaño";
            this.comboventasaño.Size = new System.Drawing.Size(92, 21);
            this.comboventasaño.TabIndex = 76;
            this.comboventasaño.Text = "Seleccionar";
            this.comboventasaño.SelectedIndexChanged += new System.EventHandler(this.comboventasaño_SelectedIndexChanged);
            this.comboventasaño.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboventasaño_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labnom);
            this.panel1.Controls.Add(this.labelus);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 38);
            this.panel1.TabIndex = 77;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sirukota", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(505, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 78;
            this.label3.Text = "Años";
            // 
            // butdelete
            // 
            this.butdelete.BackColor = System.Drawing.Color.Black;
            this.butdelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butdelete.Font = new System.Drawing.Font("Sirukota", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdelete.ForeColor = System.Drawing.Color.White;
            this.butdelete.Location = new System.Drawing.Point(250, 107);
            this.butdelete.Name = "butdelete";
            this.butdelete.Size = new System.Drawing.Size(98, 30);
            this.butdelete.TabIndex = 79;
            this.butdelete.Text = "Borrar";
            this.butdelete.UseVisualStyleBackColor = false;
            this.butdelete.Click += new System.EventHandler(this.butdelete_Click);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mdi5toA.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(800, 305);
            this.Controls.Add(this.butdelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboventasaño);
            this.Controls.Add(this.butvent);
            this.Controls.Add(this.comboventas);
            this.Controls.Add(this.butlimp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "FormVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butbuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butlimp;
        private System.Windows.Forms.ComboBox comboventas;
        private System.Windows.Forms.Button butvent;
        private System.Windows.Forms.ComboBox comboventasaño;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labnom;
        private System.Windows.Forms.Label labelus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butdelete;
    }
}