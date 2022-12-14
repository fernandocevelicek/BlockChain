using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroContable.Entidades
{
    [Serializable]
    public class Cuenta
    {
        public int Codigo { get; set; }
        public String Denominacion { get; set; }

        public override string ToString()
        {
            return Codigo + " : " + Denominacion;
        }
    }
}
