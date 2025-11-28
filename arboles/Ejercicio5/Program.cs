using System;
using arboles.Ejercicio5.Interfaces;
using arboles.Ejercicio5.Modelos;

class Program4
{
    static void Main(string[] args)
    {
        IGestor bodega = new Inventario();

        // 500, 250, 750, 125, 375, 625, 900, 100, 130, 620, 630
        Console.WriteLine("1. Inicializando inventario tras el cambio del proveedor...");
        Console.WriteLine("[500, 250, 750, 125, 375, 625, 900, 100, 130, 620, 630]");
        int[] codigos = { 500, 250, 750, 125, 375, 625, 900, 100, 130, 620, 630 };

        foreach (int c in codigos)
            bodega.RegistrarProducto(c, $"Prod-{c}", "General", 100);

        bodega.DibujarMapaBodega();

        bodega.GenerarReporteExcel();

        bodega.ActualizarStock(620, 0);

        bodega.DescontinuarProducto(375);
        bodega.DibujarMapaBodega();

        bodega.GenerarReporteExcel();
    }
}