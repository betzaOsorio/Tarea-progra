using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arboles.Ejercicio5.Interfaces
{
    public interface IGestor
    {
        void RegistrarProducto(int codigo, string nombre, string categoria, int stock);
        void ActualizarStock(int codigo, int nuevoStock);
        void DescontinuarProducto(int codigo);
        void GenerarReporteExcel();
        void DibujarMapaBodega();
    }
}
