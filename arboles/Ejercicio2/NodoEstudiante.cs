using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arboles.Ejercicio2
{
    public class NodoEstudiante
    {
        public int Carnet;       
        public string Nombre;   
        public NodoEstudiante Izquierdo, Derecho;

        public NodoEstudiante(int carnet, string nombre)
        {
            Carnet = carnet;
            Nombre = nombre;
            Izquierdo = Derecho = null;
        }
    }
}
