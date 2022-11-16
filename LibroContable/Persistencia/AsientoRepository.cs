using LibroContable.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroContable.Persistencia
{
    public class AsientoRepository
    {
        public static long currentIndex { get; set; }
        public static List<Asiento> lista { get; private set; }
        
        static AsientoRepository()
        {
            lista = new List<Asiento>();
            currentIndex = 1;
        }

        public static void Guardar(Asiento entity)
        {
            entity.Id = currentIndex;
            lista.Add(entity);
            currentIndex++;
        }

        public static List<Asiento> Consultar()
        {
            return lista;
        }

        public static void Vaciar()
        {
            currentIndex = 1;
            lista = new List<Asiento>();
        }
    }
}
