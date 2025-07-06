using CsvHelper.Configuration.Attributes;
using System.Text.Json.Serialization;

public abstract class Empleado
{
    public string Nombre { get; set; }
    public decimal SalarioBruto { get; set; }
    protected IEstrategiaImpuesto ImpuestoEstrategia { get; set; }
    public string Tipo;
    public decimal Impuesto { get; protected set; }
  

    protected Empleado(string nombre, decimal salarioBruto)
    {
        Nombre = nombre;
        SalarioBruto = salarioBruto;
    }

    public void ObtenerImpuesto()
    {
   
     if (ImpuestoEstrategia == null)
            throw new InvalidOperationException("Estrategia de impuestos no definida");
        Impuesto =ImpuestoEstrategia.CalcularImpuesto(SalarioBruto);
      
    }
  
   
}