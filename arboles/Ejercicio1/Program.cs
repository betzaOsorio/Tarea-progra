using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using arboles.Ejercicio1;

namespace arboles.Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Paqueteria bst = new Paqueteria();

            // Insertar paquetes [50, 20, 80, 10, 30, 25, 70, 90]
            Console.WriteLine("1. Insertando paquetes...");
            bst.Insertar(50, new Paquete("David", "Zona 13", 1.5));
            bst.Insertar(20, new Paquete("Maria", "Zona 1", 2.0));
            bst.Insertar(80, new Paquete("Juann", "Zona 25", 5.0));
            bst.Insertar(10, new Paquete("Yanina", "Zona 6", 0.5));
            bst.Insertar(30, new Paquete("Ximena", "Zona 3", 1.2));
            bst.Insertar(25, new Paquete("Betzabe", "Villa Canales", 3.0));
            bst.Insertar(70, new Paquete("Adolfo", "Huehuetenango", 2.5));
            bst.Insertar(90, new Paquete("Camila", "Zacapa", 4.0));

            Console.WriteLine("\n2. Árbol Resultante:");
            bst.ImprimirArbol(bst.Raiz, "", true);


            bst.InOrden();

            Console.WriteLine("3. Actualizando la Orden 30...");
            Nodo orden30 = bst.Buscar(30);
            if (orden30 != null)
            {
                Console.WriteLine($"   Antes: {orden30.Datos.Direccion}");
                orden30.Datos.Direccion = "NUEVA DIRECCIÓN ZONA 13";
                Console.WriteLine($"   Ahora: {orden30.Datos.Direccion}");
            }

            Console.WriteLine("\n4. Se Elimina Orden 20 y se muestra el árbol final...");
            bst.Eliminar(20);
            bst.ImprimirArbol(bst.Raiz, "", true);
        }
    }
}
