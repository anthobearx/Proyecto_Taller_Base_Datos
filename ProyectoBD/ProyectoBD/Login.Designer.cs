namespace ProyectoBD
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtBD = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Location = new System.Drawing.Point(96, 403);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(66, 64);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Visible = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.BackgroundImage")));
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultar.Location = new System.Drawing.Point(24, 403);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(66, 64);
            this.btnConsultar.TabIndex = 18;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Visible = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Location = new System.Drawing.Point(127, 241);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(66, 64);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Visible = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConectar.BackgroundImage")));
            this.btnConectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConectar.Location = new System.Drawing.Point(43, 241);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(66, 64);
            this.btnConectar.TabIndex = 16;
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(161, 172);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(206, 22);
            this.txtContraseña.TabIndex = 15;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(161, 118);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(206, 22);
            this.txtUsuario.TabIndex = 14;
            // 
            // txtBD
            // 
            this.txtBD.Location = new System.Drawing.Point(161, 72);
            this.txtBD.Name = "txtBD";
            this.txtBD.Size = new System.Drawing.Size(206, 22);
            this.txtBD.TabIndex = 13;
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(161, 34);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(206, 22);
            this.txtServidor.TabIndex = 11;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(40, 175);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(85, 17);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Contraseña:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(40, 123);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(61, 17);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Usuario:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(40, 75);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(105, 17);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Base de Datos:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(40, 34);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(69, 17);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Servidor: ";
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 504);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtBD);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.Button btnConsultar;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnConectar;
        internal System.Windows.Forms.TextBox txtContraseña;
        internal System.Windows.Forms.TextBox txtUsuario;
        internal System.Windows.Forms.TextBox txtBD;
        internal System.Windows.Forms.TextBox txtServidor;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ErrorProvider Error;
    }
}

