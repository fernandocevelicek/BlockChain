using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroContable.Entidades
{
    [Serializable]
    public class LibroDiario
    {
        public DateTime fecha { get; set; }
        public List<Asiento> asientos { get; set; }
    }
}
