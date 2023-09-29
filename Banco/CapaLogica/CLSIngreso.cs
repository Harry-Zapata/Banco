using Banco.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.CapaLogica
{
    public class CLSIngreso
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public static void AgregarIngreso(MetodoIngreso c)
        {
            
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cn.Open();
            Cm.CommandText = "AgregarIngresosPrueva";
            Cm.CommandType = CommandType.StoredProcedure;

            Cm.Parameters.Add(new SqlParameter("@nro_cta", SqlDbType.VarChar));
            Cm.Parameters["@nro_cta"].Value = c.nro_cta;

            Cm.Parameters.Add(new SqlParameter("@nro_sucursal", SqlDbType.Int));
            Cm.Parameters["@nro_sucursal"].Value = c.nro_sucursal;

            Cm.Parameters.Add(new SqlParameter("@cod_banco", SqlDbType.VarChar));
            Cm.Parameters["@cod_banco"].Value = c.cod_banco;

            Cm.Parameters.Add(new SqlParameter("@tipo_mov", SqlDbType.VarChar));
            Cm.Parameters["@tipo_mov"].Value = c.tipo_mov;

            Cm.Parameters.Add(new SqlParameter("@fecha_mov", SqlDbType.DateTime));
            Cm.Parameters["@fecha_mov"].Value = c.fecha_mov;

            Cm.Parameters.Add(new SqlParameter("@importe", SqlDbType.Float));
            Cm.Parameters["@importe"].Value = c.importe;
            dr = Cm.ExecuteReader();
            if (dr.HasRows == false)
            {
                throw new Exception("no encontrado!");

            }
            while (dr.Read())
            {
   
                c.nro_mov = int.Parse(dr[0].ToString());
                c.nro_cta = dr[1].ToString();
                c.nro_sucursal = int.Parse(dr[2].ToString());
                c.cod_banco = dr[3].ToString();
                c.tipo_mov = dr[4].ToString();
                c.fecha_mov = DateTime.Parse(dr[5].ToString());
                c.importe = float.Parse(dr[6].ToString());
            }
            Cn.Close();
        }
        public static void ObtenerData(MetodoIngreso c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cn.Open();
            Cm.CommandText = "DataIngreso";
            Cm.CommandType = CommandType.StoredProcedure;

            Cm.Parameters.AddWithValue("@nro_cta", c.nro_cta);
            dr = Cm.ExecuteReader();
            if (dr.HasRows == false)
            {
                throw new Exception("no encontrado!");

            }
            while (dr.Read())
            {
                c.nro_sucursal = int.Parse(dr[1].ToString());
                c.cod_banco = dr[2].ToString();
            }
            Cn.Close();
        }
    }
}
