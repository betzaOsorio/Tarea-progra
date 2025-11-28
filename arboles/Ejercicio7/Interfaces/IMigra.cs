using arboles.Ejercicio7.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    

namespace arboles.Ejercicio7.Interfaces
{
    public interface IMigrador
    {
        void InsertarUsuario(int id);
        void EliminarUsuario(int id);
        List<usuario> ExportarDatosAscendentes();
        void MostrarArbol();
    }
}
