using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arboles.Ejercicio5.Modelos
{
    public class Nodo
    {
        public Producto Datos;
        public Nodo Izquierdo;
        public Nodo Derecho;

        public Nodo(Producto producto)
        {
            Datos = producto;
            Izquierdo = null;
            Derecho = null;
        }
    }
}
