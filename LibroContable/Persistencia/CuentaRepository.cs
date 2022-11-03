using LibroContable.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroContable.Persistencia
{
    public class CuentaRepository
    {

        public static List<Cuenta> lista { get; protected set; }
        
        static CuentaRepository()
        {
            if(lista == null)
            {
                lista = new List<Cuenta>();
            }
        }

        public static void Guardar(Cuenta entity)
        {
            lista.Add(entity);
        }

        public static List<Cuenta> Consultar()
        {
            return lista;
        }
    }
}
