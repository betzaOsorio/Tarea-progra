using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arboles.Ejercicio6.Interfaces
{
    public interface IAnalisis
    {
        void Insertar(int key);
        int ObtenerAltura();
        int ContarComparaciones(int keyBuscada); 
        void Dibujar();
    }
}
