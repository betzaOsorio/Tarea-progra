using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using arboles.Ejercicio3.Clases;

namespace arboles.Ejercicio3.modelos
{
    public interface ICatalogo
    {
        void AgregarLibro(int codigo, string titulo);
        void BuscarLibro(int codigo);
        Libro ObtenerMinimo();
        Libro ObtenerMaximo();
        void MostrarPostOrden();
        void EliminarLibro(int codigo);
    }
}
