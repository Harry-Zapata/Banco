using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.CapaDatos;
using System.Windows.Forms;

namespace Banco.CapaLogica
{
    public class CLSCliente
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public static void AgregarCliente(MetodoCliente c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "AgregarCliente";
            Cm.CommandType = CommandType.StoredProcedure;

            Cm.Parameters.Add(new SqlParameter("@cod_cli", SqlDbType.VarChar));
            Cm.Parameters["@cod_cli"].Value = c.cod_cli;

            Cm.Parameters.Add(new SqlParameter("@dni", SqlDbType.VarChar));
            Cm.Parameters["@dni"].Value = c.dni;

            Cm.Parameters.Add(new SqlParameter("@apellidos", SqlDbType.VarChar));
            Cm.Parameters["@apellidos"].Value = c.apellidos;

            Cm.Parameters.Add(new SqlParameter("@nombres", SqlDbType.VarChar));
            Cm.Parameters["@nombres"].Value = c.nombres;

            Cm.Parameters.Add(new SqlParameter("@direccion", SqlDbType.VarChar));
            Cm.Parameters["@direccion"].Value = c.direccion;

            Cm.Parameters.Add(new SqlParameter("@ciudad", SqlDbType.VarChar));
            Cm.Parameters["@ciudad"].Value = c.ciudad;

            Cm.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar));
            Cm.Parameters["@email"].Value = c.email;

            try
            {
                Cn.Open();
                Cm.ExecuteNonQuery();
                Cn.Close();

            }
            catch (SqlException ex)
            {
                throw new Exception("Error al agregar el cliente: CodigoRepetido",ex);
            }
        }

        public static void Ingresar(MetodoCliente c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cn.Open();
            Cm.CommandText = "Ingresar";
            Cm.CommandType = CommandType.StoredProcedure;

            Cm.Parameters.Add(new SqlParameter("@dni", c.dni));
            Cm.Parameters.Add(new SqlParameter("@cod_cli", c.cod_cli));
            dr = Cm.ExecuteReader();
            if (dr.HasRows == false)
            {
                throw new Exception("No Encontrado");
            }
            while (dr.Read())
            {
                c.dni = dr[0].ToString();
                c.cod_cli = dr[1].ToString();
            }
            Cn.Close();
        }
    }
}
