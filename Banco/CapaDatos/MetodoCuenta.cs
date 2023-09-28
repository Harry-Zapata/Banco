using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.CapaDatos
{
    public class MetodoCuenta
    {
        public string nro_cta { get; set; }
        public string nro_sucursal { get; set; }
        public string cod_banco { get; set; }
        public string cod_cli { get; set; }
        public float saldo { get; set; }
        public DateTime fechaapertura { get; set; }
        public string tipocta { get; set; }
    }
}
