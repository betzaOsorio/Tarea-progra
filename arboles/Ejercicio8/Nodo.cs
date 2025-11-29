using arboles.Ejercicio8.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arboles.Ejercicio8
{
    public class Nodo
    {
        public DispositivoT Datos;
        public Nodo Izquierdo;
        public Nodo Derecho;

        public Nodo(DispositivoT dispositivo)
        {
            Datos = dispositivo;
            Izquierdo = null;
            Derecho = null;
        }
    }
}
