using arboles.Ejercicio7.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using arboles.Ejercicio7.Interfaces;
using arboles.Ejercicio7;

namespace arboles.Ejercicio7
{
    public class Servidor : IMigrador
    {
        private Nodo raiz;

        public void InsertarUsuario(int id)
        {
            raiz = InsertarRec(raiz, new usuario(id));
        }

        private Nodo InsertarRec(Nodo actual, usuario user)
        {
            if (actual == null) return new Nodo(user);

            if (user.Id < actual.Usuario.Id)
                actual.Izquierdo = InsertarRec(actual.Izquierdo, user);
            else if (user.Id > actual.Usuario.Id)
                actual.Derecho = InsertarRec(actual.Derecho, user);

            return actual;
        }

        public List<usuario> ExportarDatosAscendentes()
        {
            List<usuario> listaExportacion = new List<usuario>();
            InOrdenRec(raiz, listaExportacion);
            return listaExportacion;
        }

        private void InOrdenRec(Nodo actual, List<usuario> lista)
        {
            if (actual != null)
            {
                InOrdenRec(actual.Izquierdo, lista);
                lista.Add(actual.Usuario);          
                InOrdenRec(actual.Derecho, lista);   
            }
        }

        //Eliminar nodo 900
        public void EliminarUsuario(int id)
        {
            Console.WriteLine($"\n Desactivando al usuario {id} ");
            raiz = EliminarRec(raiz, id);
        }

        private Nodo EliminarRec(Nodo actual, int id)
        {
            if (actual == null) return null;

            if (id < actual.Usuario.Id)
                actual.Izquierdo = EliminarRec(actual.Izquierdo, id);
            else if (id > actual.Usuario.Id)
                actual.Derecho = EliminarRec(actual.Derecho, id);
            else
            {
                if (actual.Izquierdo == null) return actual.Derecho;
                if (actual.Derecho == null) return actual.Izquierdo;

                Nodo sucesor = ObtenerMinimo(actual.Derecho);

                actual.Usuario = sucesor.Usuario;

                actual.Derecho = EliminarRec(actual.Derecho, sucesor.Usuario.Id);
            }
            return actual;
        }

        private Nodo ObtenerMinimo(Nodo nodo)
        {
            while (nodo.Izquierdo != null) nodo = nodo.Izquierdo;
            return nodo;
        }

        public void MostrarArbol()
        {
            Console.WriteLine("\nEstructura del Servidor:");
            DibujarRec(raiz, "", true);
        }

        private void DibujarRec(Nodo nodo, string indent, bool last)
        {
            if (nodo != null)
            {
                Console.Write(indent);
                if (last) { Console.Write("└─"); indent += "  "; }
                else { Console.Write("├─"); indent += "| "; }
                Console.WriteLine(nodo.Usuario.Id);
                DibujarRec(nodo.Izquierdo, indent, false);
                DibujarRec(nodo.Derecho, indent, true);
            }
        }
    }
}
