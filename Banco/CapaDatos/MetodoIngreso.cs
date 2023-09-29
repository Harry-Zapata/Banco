using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.CapaDatos
{
    public class MetodoIngreso
    {
        public int nro_mov {  get; set; }
        public string nro_cta { get; set; }
        public int nro_sucursal { get; set; }
        public string cod_banco { get; set; }
        public string tipo_mov { get; set; }
        public DateTime fecha_mov { get; set; }
        public float importe { get; set; }
    }
}
