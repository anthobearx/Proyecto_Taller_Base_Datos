using System;
using System.Collections;
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
    public partial class Insertar : Form
    {
        private SqlConnection conn;
        public Insertar(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void Limpiar()
        {
            txtArtID.Text = Conexion.ObtenerID(conn);
            txtArtNom.Clear();
            txtArtDes.Clear();
            txtPrecio.Clear();
            cmbFamID.SelectedIndex = 0;
            rbInsertar.Checked = true;
            Error.SetError(txtArtNom, "");
            Error.SetError(txtArtDes, "");
            Error.SetError(txtPrecio, "");
        }
        private bool Validar()
        {
            if (txtArtNom.Text == String.Empty)
            {
                Error.SetError(txtArtNom, "No se Permiten Campos Vacios");
                txtArtNom.Focus();
                txtArtNom.SelectAll();
                return false;
            }
            else
            {
                Error.SetError(txtArtNom, "");
            }
            if (txtArtDes.Text == String.Empty)
            {
                Error.SetError(txtArtDes, "No se Permiten Campos Vacios");
                txtArtDes.Focus();
                txtArtDes.SelectAll();
                return false;
            }
            else
            {
                Error.SetError(txtArtDes, "");
            }
            if (txtPrecio.Text == String.Empty)
            {
                Error.SetError(txtPrecio, "No se Permiten Campos Vacios");
                txtPrecio.Focus();
                txtPrecio.SelectAll();
                return false;
            }
            else
            {
                Error.SetError(txtPrecio, "");
            }

            return true;
        }

        private void ValidarNum(double dato,Control c)
        {
            if (dato < 1)
            {
                Error.SetError(c, "No se permiten valores menores a 1");
                txtPrecio.SelectAll();
                txtPrecio.Focus();
            }
            else
            {
                Error.SetError(txtPrecio,"");
            }
        }

        private void cargarDatos()
        {
            DataTable t = Conexion.CatalogoArt(conn);
            dgwArticulos.DataSource = t;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Insertar_Load(object sender, EventArgs e)
        {
            cargarDatos();
            DataTable t = Conexion.ObtenerFamilias(conn);
            cmbFamID.DataSource = t;
            cmbFamID.DisplayMember = "famnombre";
            txtArtID.Text = Conexion.ObtenerID(conn);
            cmbFamID.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (rbInsertar.Checked)
                {
                    int id = Convert.ToInt32(txtArtID.Text);
                    string nom = txtArtNom.Text;
                    string des = txtArtDes.Text;
                    double precio = Convert.ToDouble(txtPrecio.Text);
                    int famid = Convert.ToInt32(cmbFamID.SelectedIndex.ToString()) + 1;
                    Articulo A = new Articulo(id, nom, des, precio, famid);
                    try
                    {
                        string res = Conexion.InsertarArticulo(conn, A);
                        MessageBox.Show("Articulo Agregado Exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        txtArtID.Text = res;
                        cargarDatos();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Limpiar();
                    }
                }
                if (rbActualizar.Checked)
                {
                    int id = Convert.ToInt32(txtArtID.Text);
                    string nom = txtArtNom.Text;
                    string des = txtArtDes.Text;
                    double precio = Convert.ToDouble(txtPrecio.Text);
                    int famid = Convert.ToInt32(cmbFamID.SelectedIndex.ToString()) + 1;
                    Articulo A = new Articulo(id, nom, des, precio, famid);
                    try
                    {
                        string res = Conexion.InsertarArticulo(conn, A);
                        MessageBox.Show("Articulo Actualizado Exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        txtArtID.Text = res;
                        cargarDatos();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Limpiar();
                    }
                }
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && !(char.IsDigit(e.KeyChar)))
            {
                Error.SetError(txtPrecio, "Solo se permiten numeros");
                e.Handled = true;
            }
            else
            {
                Error.SetError(txtPrecio, "");
            }
        }

        private void txtPrecio_KeyUp(object sender, KeyEventArgs e)
        {
            if (!(txtPrecio.Text == String.Empty))
            {
               ValidarNum(Convert.ToDouble(txtPrecio.Text),txtPrecio);
            }
        }

        private void txtArtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && !(char.IsDigit(e.KeyChar)))
            {
                Error.SetError(txtArtID, "Solo se permiten numeros");
                e.Handled = true;
            }
            else
            {
                Error.SetError(txtArtID, "");
            }
        }

        private void txtArtID_KeyUp(object sender, KeyEventArgs e)
        {
            if (!(txtArtID.Text == String.Empty))
            {
                ValidarNum(Convert.ToInt32(txtArtID.Text), txtArtID);
            }
        }

        private void dgwArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rbActualizar.Checked)
            {
                DialogResult Result = MessageBox.Show("¿Seleccionar este Articulo?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result.Equals(DialogResult.Yes))
                {
                    txtArtID.Text = Convert.ToString(dgwArticulos.CurrentRow.Cells[0].Value);
                    txtArtNom.Text = Convert.ToString(dgwArticulos.CurrentRow.Cells[1].Value);
                    txtArtDes.Text = Convert.ToString(dgwArticulos.CurrentRow.Cells[2].Value);
                    txtPrecio.Text = Convert.ToString(dgwArticulos.CurrentRow.Cells[3].Value);
                    cmbFamID.SelectedIndex = Convert.ToInt32(dgwArticulos.CurrentRow.Cells[4].Value);
                }
                else
                {
                    if (Result.Equals(DialogResult.No))
                    {
                        return;
                    }
                }
            }
            else
            {
                DialogResult Result = MessageBox.Show("¿Seleccionar este Articulo?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result.Equals(DialogResult.Yes))
                {
                    txtArtID.Text = Convert.ToString(dgwArticulos.CurrentRow.Cells[0].Value);
                    txtArtNom.Text = Convert.ToString(dgwArticulos.CurrentRow.Cells[1].Value);
                }
                else
                {
                    if (Result.Equals(DialogResult.No))
                    {
                        return;
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtArtID.Text);
                string res = Conexion.Eliminar(conn, id);
                if (res.Equals("1"))
                {
                    MessageBox.Show("Articulo Eliminado Exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatos();
                    Limpiar();
                }
                if (res.Equals("0"))
                {
                    MessageBox.Show("No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }
    }
}
