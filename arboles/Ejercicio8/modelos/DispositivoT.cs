using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arboles.Ejercicio8.modelos
{
    public class DispositivoT
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public string Firmware { get; set; }

        public DispositivoT(int id, string nombre, string firmware)
        {
            Id = id;
            Nombre = nombre;
            Firmware = firmware;
        }

        public override string ToString()
        {
            return $"[ID: {Id}] {Nombre} (v.{Firmware})";
        }
    }
}
