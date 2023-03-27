using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Data;

namespace ProyectoBD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private SqlConnection conn = null;
        private bool Validar()
        {
            if (txtServidor.Text == String.Empty)
            {
                Error.SetError(txtServidor, "No se Permiten Campos Vacios");
                txtServidor.Focus();
                txtServidor.SelectAll();
                return false;
            }
            else
            {
                Error.SetError(txtServidor,"");
            }
            if (txtBD.Text == String.Empty)
            {
                Error.SetError(txtBD, "No se Permiten Campos Vacios");
                txtBD.Focus();
                txtBD.SelectAll();
                return false;
            }
            else
            {
                Error.SetError(txtBD, "");
            }
            if (txtUsuario.Text == String.Empty)
            {
                Error.SetError(txtUsuario, "No se Permiten Campos Vacios");
                txtUsuario.Focus();
                txtUsuario.SelectAll();
                return false;
            }
            else
            {
               Error.SetError(txtUsuario, "");
            }
            if (txtContraseña.Text == String.Empty)
            {
                Error.SetError(txtContraseña, "No se Permiten Campos Vacios");
                txtContraseña.Focus();
                txtContraseña.SelectAll();
                return false;
            }
            else
            {
                Error.SetError(txtContraseña, "");
            }
            return true;
        }
        private void Bloqueo()
        {
            txtServidor.Enabled = false;
            txtBD.Enabled = false;
            txtUsuario.Enabled = false;
            txtContraseña.Enabled = false;
            btnConectar.Enabled = false;
        }
        private void Desbloqueo()
        {
            txtServidor.Enabled = true;
            txtBD.Enabled = true;
            txtUsuario.Enabled = true;
            txtContraseña.Enabled = true;
            btnConectar.Enabled = true;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Insertar I = new Insertar(conn);
            I.ShowDialog();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                try
                {
                    string con = "Data Source=" + txtServidor.Text + ";Initial Catalog=" + txtBD.Text + ";User ID=" + txtUsuario.Text + ";Password=" + txtContraseña.Text;
                    conn = Conexion.Conectar(con);
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        btnSalir.Visible = true;
                        btnAgregar.Visible = true;
                        btnConsultar.Visible = true;
                        Bloqueo();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContraseña.Focus();
                    txtContraseña.SelectAll();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Desbloqueo();
            btnSalir.Visible = false;
            btnAgregar.Visible = false;
            btnConsultar.Visible = false;
            txtContraseña.Clear();
            txtContraseña.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar C = new Consultar(conn);
            C.ShowDialog();
        }
    }
}
