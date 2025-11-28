using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arboles.Ejercicio4.modelos
{
    public class Nodo
    {
        public Cta Datos;
        public Nodo Izquierdo;
        public Nodo Derecho;

        public Nodo(Cta cita)
        {
            Datos = cita;
            Izquierdo = null;
            Derecho = null;
        }
    }
}
