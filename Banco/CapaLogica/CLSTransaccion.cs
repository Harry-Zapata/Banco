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
    public class CLSTransaccion
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public static void buscarUsuario(MetodoTransaccion c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cn.Open();
            Cm.CommandText = "BuscarUsuarioPorCuenta";
            Cm.CommandType = CommandType.StoredProcedure;

            Cm.Parameters.AddWithValue("@nro_cta", c.nro_cta);
            dr = Cm.ExecuteReader();
            if (dr.HasRows == false)
            {
                throw new Exception("no encontrado!");

            }
            while (dr.Read())
            {
                c.nombres = dr[1].ToString();
                c.apellidos = dr[2].ToString();
                c.cod_banco = dr[3].ToString();
                c.nombre = dr[4].ToString();
                c.nro_sucursal = int.Parse(dr[5].ToString());
                c.ciudad = dr[6].ToString();
            }
            Cn.Close();
        }
        public static void SumarImporte(MetodoTransaccion c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "SumarSaldo";
            Cm.CommandType = CommandType.StoredProcedure;

            Cm.Parameters.AddWithValue("@nro_cta", c.nro_cta);

            Cm.Parameters.AddWithValue("@saldo", c.importe);

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }
        public static void RestarSaldo(MetodoTransaccion c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "RestarSaldo";
            Cm.CommandType = CommandType.StoredProcedure;

            Cm.Parameters.AddWithValue("@nro_cta", c.nro_cta);

            Cm.Parameters.AddWithValue("@saldo", c.importe);

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        public static void ListarHistorial(MetodoTransaccion c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "ObtenerHistorial";

            da.SelectCommand.Parameters.AddWithValue("@nro_cta",c.nro_cta);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "Cargar");

            Cn.Close();
        }
    }
}
