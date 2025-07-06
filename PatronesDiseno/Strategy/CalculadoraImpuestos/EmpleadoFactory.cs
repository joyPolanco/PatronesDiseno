using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImpuestos
{
    public class EmpleadoFactory
    {
        public static Empleado GetEmpleado(string[] opciones, int opcion)
        {
            string tipoElegido = opciones[opcion - 1];
            string nombre = Input.PedirCadena("Ingrese el nombre");
            decimal salario = Input.PedirDecimal("Ingrese el salario");
            if (tipoElegido == opciones[0]) return new EmpleadoTiempoCompleto(nombre,salario);
            else if (tipoElegido == opciones[1]) return new EmpleadoMedioTiempo(nombre,salario);
            else if (tipoElegido == opciones[2]) return new EmpleadoContrato(nombre,salario);
            else throw new Exception("Tipo no manejable");
            
        }
    }
}
