using arboles.Ejercicio7.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arboles.Ejercicio7
{
    public class Nodo
    {
        public usuario Usuario;
        public Nodo Izquierdo;
        public Nodo Derecho;

        public Nodo(usuario usuario)
        {
            Usuario = usuario;
            Izquierdo = null;
            Derecho = null;
        }
    }
}
