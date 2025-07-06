using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImpuestos
{
    public class Input
    {
        public static int PedirOpcion(string mensaje,string[] opciones)
        {
            Console.WriteLine(mensaje);
            for (int i= 0; i < opciones.Length; i++)
            {
                Console.WriteLine($"{i+1} {opciones[i]}");
            }
            Console.WriteLine("Elija una opcion");
            int opcion=0;
            int.TryParse(Console.ReadLine(), out opcion);
            return opcion;
        }
        public static string PedirCadena(string mensaje)

        {
            string cadena;

            do
            {
                Console.WriteLine(mensaje);
                cadena = Console.ReadLine();
            } while (string.IsNullOrEmpty(cadena) || cadena.Length < 5);
            return cadena;
        }
        public static decimal PedirDecimal(string mensaje)

        {
            decimal dato=0;
            do
            {
                Console.WriteLine(mensaje);
                decimal.TryParse(Console.ReadLine(), out dato);
            } while (dato==0);
            return dato;
        }
    }
}
