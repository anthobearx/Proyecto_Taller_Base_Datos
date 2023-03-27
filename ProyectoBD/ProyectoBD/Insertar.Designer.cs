namespace ProyectoBD
{
    partial class Insertar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insertar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbActualizar = new System.Windows.Forms.RadioButton();
            this.rbInsertar = new System.Windows.Forms.RadioButton();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArtID = new System.Windows.Forms.TextBox();
            this.cmbFamID = new System.Windows.Forms.ComboBox();
            this.txtArtDes = new System.Windows.Forms.TextBox();
            this.txtArtNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgwArticulos = new System.Windows.Forms.DataGridView();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbActualizar);
            this.groupBox1.Controls.Add(this.rbInsertar);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtArtID);
            this.groupBox1.Controls.Add(this.cmbFamID);
            this.groupBox1.Controls.Add(this.txtArtDes);
            this.groupBox1.Controls.Add(this.txtArtNom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Articulo:";
            // 
            // rbActualizar
            // 
            this.rbActualizar.AutoSize = true;
            this.rbActualizar.Location = new System.Drawing.Point(390, 18);
            this.rbActualizar.Name = "rbActualizar";
            this.rbActualizar.Size = new System.Drawing.Size(91, 21);
            this.rbActualizar.TabIndex = 10;
            this.rbActualizar.Text = "Actualizar";
            this.rbActualizar.UseVisualStyleBackColor = true;
            // 
            // rbInsertar
            // 
            this.rbInsertar.AutoSize = true;
            this.rbInsertar.Checked = true;
            this.rbInsertar.Location = new System.Drawing.Point(312, 18);
            this.rbInsertar.Name = "rbInsertar";
            this.rbInsertar.Size = new System.Drawing.Size(77, 21);
            this.rbInsertar.TabIndex = 9;
            this.rbInsertar.TabStop = true;
            this.rbInsertar.Text = "Insertar";
            this.rbInsertar.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(87, 250);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtPrecio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrecio_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Precio:";
            // 
            // txtArtID
            // 
            this.txtArtID.Enabled = false;
            this.txtArtID.Location = new System.Drawing.Point(87, 19);
            this.txtArtID.Name = "txtArtID";
            this.txtArtID.Size = new System.Drawing.Size(100, 22);
            this.txtArtID.TabIndex = 0;
            this.txtArtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArtID_KeyPress);
            this.txtArtID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtArtID_KeyUp);
            // 
            // cmbFamID
            // 
            this.cmbFamID.FormattingEnabled = true;
            this.cmbFamID.Items.AddRange(new object[] {
            "-- Seleccione --"});
            this.cmbFamID.Location = new System.Drawing.Point(87, 205);
            this.cmbFamID.Name = "cmbFamID";
            this.cmbFamID.Size = new System.Drawing.Size(121, 24);
            this.cmbFamID.TabIndex = 5;
            // 
            // txtArtDes
            // 
            this.txtArtDes.Location = new System.Drawing.Point(87, 102);
            this.txtArtDes.MaxLength = 500;
            this.txtArtDes.Multiline = true;
            this.txtArtDes.Name = "txtArtDes";
            this.txtArtDes.Size = new System.Drawing.Size(310, 97);
            this.txtArtDes.TabIndex = 2;
            // 
            // txtArtNom
            // 
            this.txtArtNom.Location = new System.Drawing.Point(87, 59);
            this.txtArtNom.MaxLength = 50;
            this.txtArtNom.Name = "txtArtNom";
            this.txtArtNom.Size = new System.Drawing.Size(310, 22);
            this.txtArtNom.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Familia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Decripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVolver);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Location = new System.Drawing.Point(513, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones:";
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver.BackgroundImage")));
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Location = new System.Drawing.Point(50, 208);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(61, 55);
            this.btnVolver.TabIndex = 34;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Location = new System.Drawing.Point(51, 144);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(60, 55);
            this.btnLimpiar.TabIndex = 33;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(50, 80);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(61, 55);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(50, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(61, 55);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgwArticulos
            // 
            this.dgwArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwArticulos.Location = new System.Drawing.Point(19, 309);
            this.dgwArticulos.Name = "dgwArticulos";
            this.dgwArticulos.ReadOnly = true;
            this.dgwArticulos.RowHeadersWidth = 51;
            this.dgwArticulos.RowTemplate.Height = 24;
            this.dgwArticulos.Size = new System.Drawing.Size(661, 221);
            this.dgwArticulos.TabIndex = 2;
            this.dgwArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwArticulos_CellDoubleClick);
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // Insertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 542);
            this.Controls.Add(this.dgwArticulos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Insertar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar";
            this.Load += new System.EventHandler(this.Insertar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArtID;
        private System.Windows.Forms.ComboBox cmbFamID;
        private System.Windows.Forms.TextBox txtArtDes;
        private System.Windows.Forms.TextBox txtArtNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btnVolver;
        internal System.Windows.Forms.Button btnLimpiar;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RadioButton rbActualizar;
        private System.Windows.Forms.RadioButton rbInsertar;
        private System.Windows.Forms.DataGridView dgwArticulos;
        private System.Windows.Forms.ErrorProvider Error;
    }
}