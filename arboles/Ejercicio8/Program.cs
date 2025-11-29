using System;
using arboles.Ejercicio8.Interfaces;
using arboles.Ejercicio8;


class Program
{
    static void Main(string[] args)
    {
        GestorT red = new RSensors();

        // Insertar claves: 40, 10, 20, 5, 50, 45, 60, 42
        Console.WriteLine("1. Configurando sensores de red...");
        int[] ids = { 40, 10, 20, 5, 50, 45, 60, 42 };
        foreach (int id in ids)
            red.RegistrarDispositivo(id, $"Sensor-{id}", "1.0");

        red.MostrarTopologia();

        bool existe = red.ExisteDispositivo(42);

        // Actualizar IP del 10
        red.ActualizarFirmware(10, "2.5-BETA");

        // Eliminar dispositivo 40 (Raíz)
        red.EliminarDispositivo(40);
        red.MostrarTopologia();
    }
}