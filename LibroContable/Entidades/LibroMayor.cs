using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroContable.Entidades
{
    public class LibroMayor
    {
        public DateTime fecha { get; set; }
        public LibroDiario libroDiario { get; set; }
        public List<EstadoCuenta> estadosCuentas { get; set; }
    }
}
