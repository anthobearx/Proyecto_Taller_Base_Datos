namespace ProyectoBD
{
    partial class Consultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFam = new System.Windows.Forms.RadioButton();
            this.rbDes = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.dgwConsulta = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtArtNom = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblDes = new System.Windows.Forms.Label();
            this.txtArtDes = new System.Windows.Forms.TextBox();
            this.lblFam = new System.Windows.Forms.Label();
            this.cmbFamilia = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFam);
            this.groupBox1.Controls.Add(this.rbDes);
            this.groupBox1.Controls.Add(this.rbNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcion:";
            // 
            // rbFam
            // 
            this.rbFam.AutoSize = true;
            this.rbFam.Location = new System.Drawing.Point(197, 22);
            this.rbFam.Name = "rbFam";
            this.rbFam.Size = new System.Drawing.Size(73, 21);
            this.rbFam.TabIndex = 2;
            this.rbFam.TabStop = true;
            this.rbFam.Text = "Familia";
            this.rbFam.UseVisualStyleBackColor = true;
            this.rbFam.CheckedChanged += new System.EventHandler(this.rbFam_CheckedChanged);
            // 
            // rbDes
            // 
            this.rbDes.AutoSize = true;
            this.rbDes.Location = new System.Drawing.Point(90, 22);
            this.rbDes.Name = "rbDes";
            this.rbDes.Size = new System.Drawing.Size(103, 21);
            this.rbDes.TabIndex = 1;
            this.rbDes.TabStop = true;
            this.rbDes.Text = "Descripcion";
            this.rbDes.UseVisualStyleBackColor = true;
            this.rbDes.CheckedChanged += new System.EventHandler(this.rbDes_CheckedChanged);
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Checked = true;
            this.rbNombre.Location = new System.Drawing.Point(7, 22);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(79, 21);
            this.rbNombre.TabIndex = 0;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            this.rbNombre.CheckedChanged += new System.EventHandler(this.rbNombre_CheckedChanged);
            // 
            // dgwConsulta
            // 
            this.dgwConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwConsulta.Location = new System.Drawing.Point(336, 12);
            this.dgwConsulta.Name = "dgwConsulta";
            this.dgwConsulta.RowHeadersWidth = 51;
            this.dgwConsulta.RowTemplate.Height = 24;
            this.dgwConsulta.Size = new System.Drawing.Size(452, 426);
            this.dgwConsulta.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtArtNom
            // 
            this.txtArtNom.Location = new System.Drawing.Point(100, 94);
            this.txtArtNom.MaxLength = 50;
            this.txtArtNom.Name = "txtArtNom";
            this.txtArtNom.Size = new System.Drawing.Size(230, 22);
            this.txtArtNom.TabIndex = 3;
            this.txtArtNom.TextChanged += new System.EventHandler(this.txtArtNom_TextChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver.BackgroundImage")));
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Location = new System.Drawing.Point(12, 383);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(61, 55);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(12, 151);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(86, 17);
            this.lblDes.TabIndex = 2;
            this.lblDes.Text = "Descripcion:";
            this.lblDes.Visible = false;
            // 
            // txtArtDes
            // 
            this.txtArtDes.Location = new System.Drawing.Point(100, 148);
            this.txtArtDes.MaxLength = 500;
            this.txtArtDes.Multiline = true;
            this.txtArtDes.Name = "txtArtDes";
            this.txtArtDes.Size = new System.Drawing.Size(230, 151);
            this.txtArtDes.TabIndex = 3;
            this.txtArtDes.Visible = false;
            this.txtArtDes.TextChanged += new System.EventHandler(this.txtArtDes_TextChanged);
            // 
            // lblFam
            // 
            this.lblFam.AutoSize = true;
            this.lblFam.Location = new System.Drawing.Point(35, 325);
            this.lblFam.Name = "lblFam";
            this.lblFam.Size = new System.Drawing.Size(56, 17);
            this.lblFam.TabIndex = 5;
            this.lblFam.Text = "Familia:";
            this.lblFam.Visible = false;
            // 
            // cmbFamilia
            // 
            this.cmbFamilia.FormattingEnabled = true;
            this.cmbFamilia.Location = new System.Drawing.Point(100, 322);
            this.cmbFamilia.Name = "cmbFamilia";
            this.cmbFamilia.Size = new System.Drawing.Size(230, 24);
            this.cmbFamilia.TabIndex = 6;
            this.cmbFamilia.Visible = false;
            this.cmbFamilia.SelectedIndexChanged += new System.EventHandler(this.cmbFamilia_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Location = new System.Drawing.Point(270, 383);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(60, 55);
            this.btnLimpiar.TabIndex = 33;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbFamilia);
            this.Controls.Add(this.lblFam);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtArtDes);
            this.Controls.Add(this.txtArtNom);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgwConsulta);
            this.Controls.Add(this.groupBox1);
            this.Name = "Consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFam;
        private System.Windows.Forms.RadioButton rbDes;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.DataGridView dgwConsulta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtArtNom;
        internal System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.TextBox txtArtDes;
        private System.Windows.Forms.Label lblFam;
        private System.Windows.Forms.ComboBox cmbFamilia;
        internal System.Windows.Forms.Button btnLimpiar;
    }
}