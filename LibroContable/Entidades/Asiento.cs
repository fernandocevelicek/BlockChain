using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroContable.Entidades
{
    public class Asiento
    {
        public int Id { get; set; }
        public String concepto { get; set; }
        public DateTime fecha { get; set; }
        public List<MovimientoCuenta> movimientos { get; set; }
    }
}
