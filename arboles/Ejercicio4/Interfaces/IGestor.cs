using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arboles.Ejercicio4.Interfaces
{
    public interface IGestor
    {
        void AgendarCita(int turno, string paciente, string especialidad, string hora);
        void CancelarCita(int turno);
        void MostrarPreorden();
        void DibujarArbol();
    }
}
