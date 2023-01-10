
namespace Mdi5toA
{
    partial class FormRegistro
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
            this.textBuser = new System.Windows.Forms.TextBox();
            this.textBpass = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.Label();
            this.labpass = new System.Windows.Forms.Label();
            this.butaceptar = new System.Windows.Forms.Button();
            this.labwelcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.picturemostracontra = new System.Windows.Forms.PictureBox();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturemostracontra)).BeginInit();
            this.SuspendLayout();
            // 
            // textBuser
            // 
            this.textBuser.Location = new System.Drawing.Point(134, 111);
            this.textBuser.Name = "textBuser";
            this.textBuser.Size = new System.Drawing.Size(121, 20);
            this.textBuser.TabIndex = 0;
            this.textBuser.TextChanged += new System.EventHandler(this.textBuser_TextChanged);
            // 
            // textBpass
            // 
            this.textBpass.Location = new System.Drawing.Point(134, 171);
            this.textBpass.Name = "textBpass";
            this.textBpass.Size = new System.Drawing.Size(121, 20);
            this.textBpass.TabIndex = 1;
            this.textBpass.UseSystemPasswordChar = true;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.Font = new System.Drawing.Font("Sirukota", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.White;
            this.User.Location = new System.Drawing.Point(134, 90);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(81, 20);
            this.User.TabIndex = 2;
            this.User.Text = "Usuario";
            // 
            // labpass
            // 
            this.labpass.AutoSize = true;
            this.labpass.BackColor = System.Drawing.Color.Transparent;
            this.labpass.Font = new System.Drawing.Font("Sirukota", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpass.ForeColor = System.Drawing.Color.White;
            this.labpass.Location = new System.Drawing.Point(134, 151);
            this.labpass.Name = "labpass";
            this.labpass.Size = new System.Drawing.Size(108, 20);
            this.labpass.TabIndex = 3;
            this.labpass.Text = "Contraseña";
            // 
            // butaceptar
            // 
            this.butaceptar.BackColor = System.Drawing.Color.PaleGreen;
            this.butaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butaceptar.Font = new System.Drawing.Font("Sirukota", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butaceptar.ForeColor = System.Drawing.Color.Black;
            this.butaceptar.Location = new System.Drawing.Point(156, 197);
            this.butaceptar.Name = "butaceptar";
            this.butaceptar.Size = new System.Drawing.Size(86, 28);
            this.butaceptar.TabIndex = 4;
            this.butaceptar.Text = "Aceptar";
            this.butaceptar.UseVisualStyleBackColor = false;
            this.butaceptar.Click += new System.EventHandler(this.butaceptar_Click);
            // 
            // labwelcome
            // 
            this.labwelcome.AutoSize = true;
            this.labwelcome.BackColor = System.Drawing.Color.Transparent;
            this.labwelcome.Font = new System.Drawing.Font("Sirukota", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labwelcome.ForeColor = System.Drawing.Color.White;
            this.labwelcome.Location = new System.Drawing.Point(23, 31);
            this.labwelcome.Name = "labwelcome";
            this.labwelcome.Size = new System.Drawing.Size(343, 34);
            this.labwelcome.TabIndex = 5;
            this.labwelcome.Text = "Bienvenido a GreenPick";
            this.labwelcome.Click += new System.EventHandler(this.labwelcome_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Sirukota", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(-1, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picturemostracontra
            // 
            this.picturemostracontra.BackColor = System.Drawing.Color.Transparent;
            this.picturemostracontra.Image = global::Mdi5toA.Properties.Resources._772420_200;
            this.picturemostracontra.Location = new System.Drawing.Point(257, 169);
            this.picturemostracontra.Name = "picturemostracontra";
            this.picturemostracontra.Size = new System.Drawing.Size(25, 24);
            this.picturemostracontra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturemostracontra.TabIndex = 7;
            this.picturemostracontra.TabStop = false;
            this.picturemostracontra.Click += new System.EventHandler(this.picturemostracontra_Click);
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.BackColor = System.Drawing.Color.Transparent;
            this.lab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.75F);
            this.lab1.ForeColor = System.Drawing.Color.Red;
            this.lab1.Location = new System.Drawing.Point(106, 170);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(25, 31);
            this.lab1.TabIndex = 8;
            this.lab1.Text = "*";
            this.lab1.Visible = false;
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.BackColor = System.Drawing.Color.Transparent;
            this.lab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.75F);
            this.lab2.ForeColor = System.Drawing.Color.Red;
            this.lab2.Location = new System.Drawing.Point(106, 111);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(25, 31);
            this.lab2.TabIndex = 9;
            this.lab2.Text = "*";
            this.lab2.Visible = false;
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.BackColor = System.Drawing.Color.Transparent;
            this.lab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab3.ForeColor = System.Drawing.Color.LightCoral;
            this.lab3.Location = new System.Drawing.Point(99, 233);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(57, 20);
            this.lab3.TabIndex = 10;
            this.lab3.Text = "label3";
            this.lab3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab3.Visible = false;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = global::Mdi5toA.Properties.Resources.menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(388, 295);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.picturemostracontra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labwelcome);
            this.Controls.Add(this.butaceptar);
            this.Controls.Add(this.labpass);
            this.Controls.Add(this.User);
            this.Controls.Add(this.textBpass);
            this.Controls.Add(this.textBuser);
            this.MaximizeBox = false;
            this.Name = "FormRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturemostracontra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label labpass;
        private System.Windows.Forms.Button butaceptar;
        private System.Windows.Forms.Label labwelcome;
        private System.Windows.Forms.TextBox textBuser;
        private System.Windows.Forms.TextBox textBpass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picturemostracontra;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab3;
    }
}