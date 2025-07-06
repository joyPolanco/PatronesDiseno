// See https://aka.ms/new-console-template for more information
using CalculadoraImpuestos;
class Program {
    public static void Main(string[] args)
    {
        Console.Clear();
        string[] opcionesEmpleado = { "Empleado tiempo completo", "Empleado medio tiempo", "Empleado por contrato" };
        string[] opcionesExportacion = { "Exportar JSON", "Exportar TXT", "Exportar CSV" };

        try
        {
            int opcionEmpleado = Input.PedirOpcion("Tipos de empleados: ", opcionesEmpleado);
            Empleado emp = EmpleadoFactory.GetEmpleado(opcionesEmpleado, opcionEmpleado);
            emp.ObtenerImpuesto();
            int opcionExportacion = Input.PedirOpcion("Tipos de exportacion", opcionesExportacion);
            Exportador exportador = new Exportador();
            exportador.SetTipo(opcionExportacion, opcionesExportacion);
            exportador.Exportar(emp);
            Console.Clear();
            Console.WriteLine("Exportacion realizada correctamente");
            Console.WriteLine("Presione cualquier tecla para retornar al menu");
            Console.ReadKey();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Main(args);
    }
}
