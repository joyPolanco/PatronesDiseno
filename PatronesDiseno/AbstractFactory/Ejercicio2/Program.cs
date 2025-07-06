// See https://aka.ms/new-console-template for more information


using System.Reflection;
public class Program
{
    static int PedirOpcion(string mensaje, string[] opciones)
{
    Console.WriteLine(mensaje);
    for (int i = 0; i < opciones.Length; i++)
        Console.WriteLine($"[{i + 1}] {opciones[i]}");

    Console.Write("Elije una opción: ");
    return int.TryParse(Console.ReadLine(), out int opcion) ? opcion : 0;
}

    static void EjecutarCarro(IFabrica fabrica)
    {
        ICarro carro = fabrica.FabricarCarro();
        carro.Encender();
        carro.Arrancar();
        carro.Frenar();
        carro.HacerDrift();
    }

static void EjecutarMotocicleta(IFabrica fabrica)
{
    IMotocicleta moto = fabrica.FabricarMotocicleta();
    moto.Encender();
    moto.Arrancar();
    moto.Frenar();
    moto.Calibrar();
}
    private static void Main(string[] args)
    {
        Console.Clear();
        int opcionVehiculo = PedirOpcion("Elija el tipo de vehiculo", new string[] { "Motocicleta", "Carro" });
        int opcionCombustible = PedirOpcion("Elija el tipo de combustible", new string[] { "Gasolina", "Electrico" });
        try {
            IFabrica fabrica = FabricaManager.GetFabrica(opcionCombustible);
            if (opcionVehiculo == 1)
                EjecutarMotocicleta(fabrica);
            else if (opcionVehiculo == 2)
                EjecutarCarro(fabrica);
            else
            {
                throw new Exception("Tipo de vehiculo no manejable");

            }
            Console.ReadKey();
        } catch (Exception e) {
             Console.WriteLine(e.Message);
            Console.ReadKey(); };

        Main(args);
    }
}
