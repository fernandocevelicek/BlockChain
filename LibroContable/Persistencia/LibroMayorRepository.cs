using LibroContable.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroContable.Persistencia
{
    public class LibroMayorRepository
    {

        public static List<LibroMayor> lista { get; protected set; }
        
        static LibroMayorRepository()
        {
            if (lista == null)
            {
                lista = new List<LibroMayor>();
            }
        }

        public static void Guardar(LibroMayor entity)
        {
            lista.Add(entity);
        }

        public static List<LibroMayor> Consultar()
        {
            return lista;
        }
    }
}
