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
    public class CLSInfoGeneral
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public static void VerInformacion(MetodoInfoGeneral c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cn.Open();
            Cm.CommandText = "InformacionCuenta";
            Cm.CommandType = CommandType.StoredProcedure;

            Cm.Parameters.AddWithValue("@cod_cli", c.cod_cli);
            dr = Cm.ExecuteReader();
            if (dr.HasRows == false)
            {
                throw new Exception("Error!");
            }
            while (dr.Read())
            {
                c.cod_cli = dr[0].ToString();
                c.nombres = dr[1].ToString();
                c.nro_cta = dr[2].ToString();
                c.saldo = float.Parse(dr[3].ToString());
                c.tipo_cuenta = dr[4].ToString();
                c.nombre = dr[5].ToString();
            }
            Cn.Close();

        }
    }
}
