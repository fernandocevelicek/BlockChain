using LibroContable.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroContable.Persistencia
{
    public class BaseRepository<T>
    {
        public static List<T> lista { get; set; }
        public static void Guardar(T entity)
        {
            lista.Add(entity);
        }

        public static List<T> Consultar()
        {
            return lista;
        }
    }
}
