using arboles.Ejercicio7.Modelos;
using arboles.Ejercicio7.Interfaces;
using arboles.Ejercicio7;

class Program6
{
    static void Main(string[] args)
    {
        IMigrador servidorViejo = new Servidor();


        int[] ids = { 1000, 900, 1100, 850, 950, 1050, 1200, 930, 960 };
        foreach (int id in ids) servidorViejo.InsertarUsuario(id);

        servidorViejo.MostrarArbol();

        Console.WriteLine("\n INICIANDO MIGRACIÓN ");
        List<usuario> datosExportados = servidorViejo.ExportarDatosAscendentes();

        Console.WriteLine("Datos (Orden exacto):");
        Console.WriteLine(string.Join(" -> ", datosExportados));

        servidorViejo.EliminarUsuario(900);
        servidorViejo.MostrarArbol();
    }
}