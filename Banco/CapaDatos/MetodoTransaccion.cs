using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.CapaDatos
{
    public class MetodoTransaccion
    {
        public string nro_cta {  get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int nro_sucursal {  get; set; }
        public string ciudad {  get; set; }
        public string cod_banco {  get; set; }
        public string nombre {  get; set; }
        public string cod_cli {  get; set; }
        public float saldo {  get; set; }
        public DateTime fechaapertura {  get; set; }
        public string tipocta {  get; set; }
        public float importe { get; set; }
    }
}
