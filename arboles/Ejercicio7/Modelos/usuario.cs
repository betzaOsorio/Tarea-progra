using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arboles.Ejercicio7.Modelos
{
    public class usuario
    {
        public int Id { get; set; } 
        public string Datos { get; set; } 

        public usuario(int id)
        {
            Id = id;
            Datos = $"DatosUser_{id}";
        }

        public override string ToString()
        {
            return $"[ID: {Id}]";
        }
    }
}
