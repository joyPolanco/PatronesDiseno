using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImpuestos
{
    public class EmpleadoDTO
    {
        public string Nombre { get; set; }
        public decimal SalarioBruto { get; set; }
        public string Tipo { get; set; }
        public decimal Impuesto { get;  set; }
    }
}
