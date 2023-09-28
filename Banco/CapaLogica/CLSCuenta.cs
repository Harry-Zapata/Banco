using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.CapaDatos;

namespace Banco.CapaLogica
{
    public class CLSCuenta
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public static void LLenarComboxBanco()
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "llenarBanco";

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            da.Fill(dt);

            Cn.Close();
        }

        public static void LLenarComboxSucursal(string id)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "llenarSucursal";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@cod_banco", id);

            dt = new DataTable();
            da.Fill(dt);

            Cn.Close();
        }

        public static void GenerarCuenta(MetodoCuenta c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "GenerarCuenta";
            Cm.CommandType = CommandType.StoredProcedure;

            Cm.Parameters.Add(new SqlParameter("@nro_sucursal", SqlDbType.Int));
            Cm.Parameters["@nro_sucursal"].Value = c.nro_sucursal;

            Cm.Parameters.Add(new SqlParameter("@cod_banco", SqlDbType.VarChar));
            Cm.Parameters["@cod_banco"].Value = c.cod_banco;

            Cm.Parameters.Add(new SqlParameter("@cod_cli", SqlDbType.VarChar));
            Cm.Parameters["@cod_cli"].Value = c.cod_cli;

            Cm.Parameters.Add(new SqlParameter("@saldo", SqlDbType.Float));
            Cm.Parameters["@saldo"].Value = c.saldo;

            Cm.Parameters.Add(new SqlParameter("@fechaapertura", SqlDbType.Date));
            Cm.Parameters["@fechaapertura"].Value = c.fechaapertura;

            Cm.Parameters.Add(new SqlParameter("@tipocta", SqlDbType.VarChar));
            Cm.Parameters["@tipocta"].Value = c.tipocta;


            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        public static void VerCuenta(MetodoCuenta c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cn.Open();
            Cm.CommandText = "buscarNroCuenta";
            Cm.CommandType = CommandType.StoredProcedure;

            Cm.Parameters.AddWithValue("@cod_cli", c.cod_cli);
            dr = Cm.ExecuteReader();
            if (dr.HasRows == false)
            {
                throw new Exception("Cuenta no encontrada!");
            }
            while (dr.Read())
            {
                c.cod_cli = dr[0].ToString();
                c.nro_cta = dr[1].ToString();
            }
            Cn.Close();

        }
    }
}
