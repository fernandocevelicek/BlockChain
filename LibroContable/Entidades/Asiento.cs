using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroContable.Entidades
{
    [Serializable]
    public class Asiento
    {
        public long Id { get; set; }
        public String Concepto { get; set; }
        public DateTime Fecha { get; set; }
        public List<MovimientoCuenta> Movimientos { get; set; }
    }
}
