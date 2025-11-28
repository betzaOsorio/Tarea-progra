using arboles.Ejercicio2;
using System;

namespace arboles.Ejercicio1
{
    class Program1
    {
        static void Main(string[] args)
        {
            ArbolUniversitario system = new ArbolUniversitario();

            //Carga inicial de datos [1050, 1020, 1100, 1010, 1030, 1080, 1150]
            Console.WriteLine("--- Inicializando El Sistema Universitario ---");
            system.Insertar(1050, "Mia (Root");
            system.Insertar(1020, "Juana");
            system.Insertar(1100, "Raquel");
            system.Insertar(1010, "Barbara");
            system.Insertar(1030, "Johana");
            system.Insertar(1080, "Gustavo");
            system.Insertar(1150, "Chealse");

            system.ImprimirArbol(system.Raiz, "", true);

            Console.WriteLine("\n1. Verificando existencia de estudiantes:");
            Console.WriteLine($"   - ¿Existe 1020? {system.Contiene(1020)}");
            Console.WriteLine($"   - ¿Existe 1050? {system.Contiene(1050)}");
            Console.WriteLine($"   - ¿Existe 1100? {system.Contiene(1100)}");

            Console.WriteLine("\n2. Eliminando carnet 1050 ");
            system.Eliminar(1050);

            Console.WriteLine("   Árbol resultante:");
            system.ImprimirArbol(system.Raiz, "", true);

            int altura = system.ObtenerAltura();
            Console.WriteLine($"\n3. Altura del árbol actual: {altura}");
        }
    }
}