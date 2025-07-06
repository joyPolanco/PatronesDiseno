using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CalculadoraImpuestos.Implementaciones.Exportaciones
{
    public class ExportacionJson : IEstrategiaExportacion
    {

        public string Ruta => "datajson.json";

        public void Exportar(EmpleadoDTO empleado)
        {
            List<EmpleadoDTO> empleados= new List<EmpleadoDTO>();
            if (File.Exists(Ruta))
            {
                var FileContent = File.ReadAllText(Ruta);
                var empleadosAgregados = JsonSerializer.Deserialize<List<EmpleadoDTO>>(FileContent);
                empleadosAgregados.ForEach(d => empleados.Add(d));
            }
            empleados.Add(empleado);
            using (StreamWriter st = new StreamWriter(Ruta, false))
            {
                var data = JsonSerializer.Serialize(empleados, new JsonSerializerOptions { WriteIndented=true});
                st.Write(data);

            }
        }
    }
}
