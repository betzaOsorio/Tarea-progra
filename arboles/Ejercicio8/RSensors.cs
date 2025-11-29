using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using arboles.Ejercicio8.Interfaces;
using arboles.Ejercicio8.modelos;
using arboles.Ejercicio8;

namespace arboles.Ejercicio8
{
    public class RSensors : GestorT
    {
        private Nodo raiz;

        public void RegistrarDispositivo(int id, string nombre, string firmware)
        {
            raiz = InsertarRec(raiz, new DispositivoT(id, nombre, firmware));
        }

        private Nodo InsertarRec(Nodo actual, DispositivoT dispositivo)
        {
            if (actual == null) return new Nodo(dispositivo);

            if (dispositivo.Id < actual.Datos.Id)
                actual.Izquierdo = InsertarRec(actual.Izquierdo, dispositivo);
            else if (dispositivo.Id > actual.Datos.Id)
                actual.Derecho = InsertarRec(actual.Derecho, dispositivo);

            return actual;
        }

        public bool ExisteDispositivo(int id)
        {
            Console.WriteLine($"\n Se esta Rastreando el dispositivo {id} ");
            return BuscarRec(raiz, id) != null;
        }

        private Nodo BuscarRec(Nodo actual, int id)
        {
            if (actual == null)
            {
                Console.WriteLine("-> Fin del camino: No se encontro.");
                return null;
            }

            Console.Write($"-> Visitando Nodo {actual.Datos.Id} ");

            if (id == actual.Datos.Id)
            {
                Console.WriteLine("(¡SE HA ENCONTRADO!)");
                return actual;
            }

            if (id < actual.Datos.Id)
            {
                Console.WriteLine("(Buscando por la Izquierda)");
                return BuscarRec(actual.Izquierdo, id);
            }
            else
            {
                Console.WriteLine("(Buscando por la Derecha)");
                return BuscarRec(actual.Derecho, id);
            }
        }

        public void ActualizarFirmware(int id, string nuevoFirmware)
        {
            Console.WriteLine($"\n Actualizando IP de ID {id} ");
            Nodo nodo = ObtenerNodo(raiz, id);
            if (nodo != null)
            {
                Console.WriteLine($"Versión anterior: {nodo.Datos.Firmware}");
                nodo.Datos.Firmware = nuevoFirmware;
                Console.WriteLine($"Versión nueva: {nodo.Datos.Firmware}");
            }
        }

        private Nodo ObtenerNodo(Nodo actual, int id)
        {
            if (actual == null || actual.Datos.Id == id) return actual;
            if (id < actual.Datos.Id) return ObtenerNodo(actual.Izquierdo, id);
            return ObtenerNodo(actual.Derecho, id);
        }


        public void EliminarDispositivo(int id)
        {
            Console.WriteLine($"\n Eliminando el Dispositivo {id} ");
            raiz = EliminarRec(raiz, id);
        }

        private Nodo EliminarRec(Nodo actual, int id)
        {
            if (actual == null) return null;

            if (id < actual.Datos.Id)
                actual.Izquierdo = EliminarRec(actual.Izquierdo, id);
            else if (id > actual.Datos.Id)
                actual.Derecho = EliminarRec(actual.Derecho, id);
            else
            {
                if (actual.Izquierdo == null) return actual.Derecho;
                if (actual.Derecho == null) return actual.Izquierdo;

                Nodo sucesor = ObtenerMinimo(actual.Derecho);

                Console.WriteLine($"   * Reemplazando nodo {actual.Datos.Id} con su sucesor {sucesor.Datos.Id}");
                actual.Datos = sucesor.Datos;

                actual.Derecho = EliminarRec(actual.Derecho, sucesor.Datos.Id);
            }
            return actual;
        }

        private Nodo ObtenerMinimo(Nodo nodo)
        {
            while (nodo.Izquierdo != null) nodo = nodo.Izquierdo;
            return nodo;
        }

        public void MostrarTopologia()
        {
            Console.WriteLine("\nTopología de Red:");
            DibujarRec(raiz, "", true);
        }

        private void DibujarRec(Nodo nodo, string indent, bool last)
        {
            if (nodo != null)
            {
                Console.Write(indent);
                if (last) { Console.Write("└─"); indent += "  "; }
                else { Console.Write("├─"); indent += "| "; }
                Console.WriteLine(nodo.Datos.Id);
                DibujarRec(nodo.Izquierdo, indent, false);
                DibujarRec(nodo.Derecho, indent, true);
            }
        }
    }
}
