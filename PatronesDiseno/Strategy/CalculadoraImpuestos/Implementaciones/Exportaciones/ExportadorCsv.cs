using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraImpuestos.Implementaciones.Exportaciones
{
    public class ExportadorCsv : IEstrategiaExportacion
    {

        public string Ruta => "dataExcel.csv";

        public void Exportar(EmpleadoDTO e)
        {
            bool archivoExiste = File.Exists(Ruta);
            using (StreamWriter sw = new StreamWriter(Ruta, true))
            {
                using (CsvWriter csvHelper= new CsvWriter(sw, CultureInfo.InvariantCulture))
                {
                    if (!archivoExiste) 
                    { csvHelper.WriteHeader<EmpleadoDTO>();
                        csvHelper.NextRecord();
                    
                    }
                   
                      csvHelper.WriteRecord<EmpleadoDTO>(e);
                    csvHelper.NextRecord();
                }
            }
        }
    }
}
