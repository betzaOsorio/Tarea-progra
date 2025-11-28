using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arboles.Ejercicio5.Modelos
{
    public class Producto
    {
        public int Codigo { get; set; } 
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public int Existencia { get; set; } 

        public Producto(int codigo, string nombre, string categoria, int existencia)
        {
            Codigo = codigo;
            Nombre = nombre;
            Categoria = categoria;
            Existencia = existencia;
        }

        public override string ToString()
        {
            return $"[Código: {Codigo}] {Nombre} | Stock: {Existencia}";
        }
    }
}
