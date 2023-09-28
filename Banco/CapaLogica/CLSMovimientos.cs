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
    public class CLSMovimientos
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public static void AgregarMovimiento(MetodoMovimiento c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "AgregarMovimiento";
            Cm.CommandType = CommandType.StoredProcedure;

            Cm.Parameters.Add(new SqlParameter("@nro_cta_origen", SqlDbType.VarChar));
            Cm.Parameters["@nro_cta_origen"].Value = c.nro_cta_origen;

            Cm.Parameters.Add(new SqlParameter("@nro_cta_destino", SqlDbType.VarChar));
            Cm.Parameters["@nro_cta_destino"].Value = c.nro_cta_destino;

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

            try
            {
                Cn.Open();
                Cm.ExecuteNonQuery();
                Cn.Close();

            }
            catch (SqlException ex)
            {
                throw new Exception("Error al agregar el cliente: CodigoRepetido", ex);
            }
        }
    }
}
