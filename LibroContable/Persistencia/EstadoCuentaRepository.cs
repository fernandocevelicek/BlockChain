using LibroContable.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroContable.Persistencia
{
    public class EstadoCuentaRepository
    {

        public static List<EstadoCuenta> lista { get; protected set; }

        static EstadoCuentaRepository()
        {
            if (lista == null)
            {
                lista = new List<EstadoCuenta>();
            }
        }
        
        public static void Guardar(EstadoCuenta entity)
        {
            lista.Add(entity);
        }

        public static List<EstadoCuenta> Consultar()
        {
            return lista;
        }
    }
}
