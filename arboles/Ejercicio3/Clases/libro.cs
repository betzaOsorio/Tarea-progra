using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arboles.Ejercicio3.Clases
{
    public class Libro
    {
        public int Codigo { get; set; } 
        public string Titulo { get; set; } 

        public Libro(int codigo, string titulo)
        {
            Codigo = codigo;
            Titulo = titulo;
        }

        public override string ToString()
        {
            return $"[{Codigo}] {Titulo}";
        }
    }
}
