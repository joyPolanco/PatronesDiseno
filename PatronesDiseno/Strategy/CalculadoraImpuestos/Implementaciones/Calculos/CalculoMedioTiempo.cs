public class CalculoMedioTiempo : IEstrategiaImpuesto
{
    public decimal CalcularImpuesto(decimal salario)
    {
        return salario *(decimal) 0.10;
  }
}