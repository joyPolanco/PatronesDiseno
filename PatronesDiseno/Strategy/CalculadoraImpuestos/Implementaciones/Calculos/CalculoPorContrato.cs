public class CalculoPorContrato : IEstrategiaImpuesto
{
    public decimal CalcularImpuesto(decimal salario)
    {
        return salario *(decimal) 0.15;
  }
}