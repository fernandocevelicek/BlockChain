using LibroContable.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroContable.Persistencia
{
    public class LibroDiarioRepository
    {

        public static List<LibroDiario> lista { get; protected set; }

        static LibroDiarioRepository()
        {
            if (lista == null)
            {
                lista = new List<LibroDiario>();
            }
        }
        
        public static void Guardar(LibroDiario entity)
        {
            lista.Add(entity);
        }

        public static List<LibroDiario> Consultar()
        {
            return lista;
        }
    }
}
