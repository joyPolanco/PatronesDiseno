using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImpuestos.Implementaciones.Exportaciones
{
    internal class ExportadorTxt : IEstrategiaExportacion
    {
        public string Ruta => "datatxt.txt";

        public void Exportar(EmpleadoDTO empleado)
        {
            if (!File.Exists(Ruta))
            {
                using (StreamWriter sr = new StreamWriter(Ruta, true))
                {
                    sr.WriteLine("{0,-20} {1,-20} {2,-15} {3,-10}",
                                 "Nombre", "Tipo", "Salario", "Impuesto");
                }
            }
           using (StreamWriter R = new StreamWriter(Ruta, true))
            {
                R.WriteLine("{0,-20} {1,-20} {2,-15} {3,-10}",
                    empleado.Nombre, empleado.Tipo, empleado.SalarioBruto.ToString(), empleado.Impuesto.ToString());
            }
        }
    }
}
