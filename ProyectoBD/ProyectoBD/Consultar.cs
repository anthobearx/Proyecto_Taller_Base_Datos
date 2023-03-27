using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD
{
    public partial class Consultar : Form
    {
        SqlConnection conn = null;
        public Consultar(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }
        private void Limpiar()
        {
            txtArtDes.Clear();
            txtArtNom.Clear();
            cmbFamilia.SelectedIndex = 0;
            CargarDatos();
        }
        private void CargarDatos()
        {
            if (rbNombre.Checked)
            {
                string nom = txtArtNom.Text;
                DataTable t = Conexion.BusquedaDNom(conn, nom);
                dgwConsulta.DataSource = t;
            }
            if (rbDes.Checked)
            {
                string des = txtArtDes.Text;
                DataTable t = Conexion.BusquedaDDes(conn, des);
                dgwConsulta.DataSource = t;
            }
            if (rbFam.Checked)
            {
                int fam = Convert.ToInt32(cmbFamilia.SelectedIndex.ToString())+1;
                DataTable t = Conexion.BusquedaFam(conn, fam);
                dgwConsulta.DataSource = t;
            }
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            lblDes.Visible = false;
            txtArtDes.Visible = false;
            lblFam.Visible = false;
            cmbFamilia.Visible = false;
            lblNombre.Visible = true;
            txtArtNom.Visible = true;
            txtArtNom.Focus();
            Limpiar();
            CargarDatos();

        }

        private void rbDes_CheckedChanged(object sender, EventArgs e)
        {
            lblNombre.Visible = false;
            txtArtNom.Visible = false;
            lblFam.Visible = false;
            cmbFamilia.Visible = false;
            lblDes.Visible = true;
            txtArtDes.Visible = true;
            txtArtDes.Focus();
            Limpiar();
            CargarDatos();
        }

        private void rbFam_CheckedChanged(object sender, EventArgs e)
        {
            lblNombre.Visible = false;
            txtArtNom.Visible = false;
            lblDes.Visible = false;
            txtArtDes.Visible = false;
            lblFam.Visible = true;
            cmbFamilia.Visible = true;
            Limpiar();
            CargarDatos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            DataTable t = Conexion.ObtenerFamilias(conn);
            cmbFamilia.DataSource = t;
            cmbFamilia.DisplayMember = "famnombre";
            txtArtNom.Focus();
            CargarDatos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtArtNom_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtArtDes_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void cmbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
