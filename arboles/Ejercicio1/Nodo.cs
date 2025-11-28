using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arboles.Ejercicio1
{
    public class Nodo
    {
        public int NumeroOrden; 
        public Paquete Datos;   
        public Nodo Izquierdo, Derecho;

        public Nodo(int orden, Paquete datos)
        {
            NumeroOrden = orden;
            Datos = datos;
            Izquierdo = Derecho = null;
        }
    }
}
