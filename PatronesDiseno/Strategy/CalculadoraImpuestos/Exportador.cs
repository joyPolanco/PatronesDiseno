using CalculadoraImpuestos.Implementaciones.Exportaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImpuestos
{
    public class Exportador
    {
        public IEstrategiaExportacion estrategiaExportacion { get; set; }

        public void Exportar(Empleado e)
        {

            try {
                var empleadoDTO = new EmpleadoDTO
                {
                    Impuesto = e.Impuesto,
                    Nombre = e.Nombre,
                    SalarioBruto = e.SalarioBruto,
                    Tipo = e.Tipo
                };
                estrategiaExportacion.Exportar(empleadoDTO);
         }
            catch 
            {
                throw;
            }
        }
        public void SetTipo(int opcion, string[] opciones)
        {
            string tipoElegido = opciones[opcion - 1];
            if (tipoElegido == opciones[0]) estrategiaExportacion=new ExportacionJson();
            else if (tipoElegido == opciones[1]) estrategiaExportacion = new ExportadorTxt();
            else if (tipoElegido == opciones[2]) estrategiaExportacion = new ExportadorCsv();
            else throw new Exception("Tipo no manejable");
        }
    }
}
