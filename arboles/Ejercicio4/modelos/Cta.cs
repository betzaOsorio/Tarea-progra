using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arboles.Ejercicio4.modelos
{
    public class Cta
    {
        public int NumeroTurno { get; set; }
        public string Paciente { get; set; }
        public string Especialidad { get; set; }
        public string Hora { get; set; }

        public Cta(int turno, string paciente, string especialidad, string hora)
        {
            NumeroTurno = turno;
            Paciente = paciente;
            Especialidad = especialidad;
            Hora = hora;
        }

        public override string ToString()
        {
            return $"[Turno {NumeroTurno}] {Paciente} ({Especialidad} - {Hora})";
        }
    }
}
