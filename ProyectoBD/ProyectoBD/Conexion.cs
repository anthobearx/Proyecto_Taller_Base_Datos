using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace ProyectoBD
{
    public class Conexion
    {
        public static SqlConnection Conectar(string con)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(con);
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn = null;
                throw ex;
            }   
            return conn;
        }
        public static DataTable CatalogoArt(SqlConnection con)
        {
            SqlDataReader Lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = con;
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("sp_ConsultaArticulos", conn);
                comando.CommandType = CommandType.StoredProcedure;
                Lector = comando.ExecuteReader();
                tabla.Load(Lector);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public static string InsertarArticulo(SqlConnection con,Articulo A)
        {
            SqlConnection conn = con;
            string Rpta = "";
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("sp_InsertarArt", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@artid", SqlDbType.Int).Value = A.pId;
                comando.Parameters.Add("@artnombre", SqlDbType.VarChar).Value = A.pNombre;
                comando.Parameters.Add("@artdes", SqlDbType.VarChar).Value = A.pDes;
                comando.Parameters.Add("@artprecio", SqlDbType.Int).Value = A.pPrecio;
                comando.Parameters.Add("@famid", SqlDbType.Int).Value = A.pFamid;
                SqlParameter res = new SqlParameter();
                res.ParameterName = "@res";
                res.SqlDbType = SqlDbType.Int;
                res.Direction = ParameterDirection.Output;
                comando.Parameters.Add(res);
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(res.Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return Rpta;
        }
        public static string ObtenerID(SqlConnection con)
        {
            SqlConnection conn = con;
            string Rpta = "";
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("sp_ObtenerArtID", conn);
                comando.CommandType = CommandType.StoredProcedure;
                SqlParameter res = new SqlParameter();
                res.ParameterName = "@res";
                res.SqlDbType = SqlDbType.Int;
                res.Direction = ParameterDirection.Output;
                comando.Parameters.Add(res);
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(res.Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return Rpta;
        }
        public static DataTable ObtenerFamilias(SqlConnection con)
        {
            SqlDataReader Lector = null;
            SqlConnection conn = con;
            DataTable Tabla = new DataTable();
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand("select famnombre from familias", conn);
                Lector = comando.ExecuteReader();
                Tabla.Load(Lector);

                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static string Eliminar(SqlConnection con,int id)
        {
            SqlConnection conn = con;
            string Rpta = "";
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("sp_Eliminar", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlParameter res = new SqlParameter();
                res.ParameterName = "@res";
                res.SqlDbType = SqlDbType.Int;
                res.Direction = ParameterDirection.Output;
                comando.Parameters.Add(res);
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(res.Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return Rpta;
        }
        public static DataTable BusquedaDNom(SqlConnection con, string nom)
        {
            SqlDataReader Lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = con;
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("sp_ConsultaDimNom", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nom", SqlDbType.VarChar).Value = nom;
                Lector = comando.ExecuteReader();
                tabla.Load(Lector);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        internal static DataTable BusquedaFam(SqlConnection con, int fam)
        {
            SqlDataReader Lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = con;
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("sp_ConsultaFam", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@fam", SqlDbType.Int).Value = fam;
                Lector = comando.ExecuteReader();
                tabla.Load(Lector);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        internal static DataTable BusquedaDDes(SqlConnection con, string des)
        {
            SqlDataReader Lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = con;
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("sp_ConsultaDimDes", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@des", SqlDbType.VarChar).Value = des;
                Lector = comando.ExecuteReader();
                tabla.Load(Lector);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
