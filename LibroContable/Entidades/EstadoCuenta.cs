using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroContable.Entidades
{
    public class EstadoCuenta
    {
        public DateTime fecha { get; set; }
        public Cuenta cuenta { get; set; }
        public Double balanceFinal { get; set; }
    }
}
