using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.CapaDatos
{
    public class CLSConexion
    {
        public static String cnCadena()
        {
            String Str = "SERVER=ZAPATA\\SQLEXPRESS;DataBase=BANCO;UID=sa;PWD=Contraseña";
            return Str;
        }
    }
}
