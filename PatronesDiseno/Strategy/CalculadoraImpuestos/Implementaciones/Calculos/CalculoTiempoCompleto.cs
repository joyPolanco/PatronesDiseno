public class CalculoTiempoCompleto : IEstrategiaImpuesto
{
    public decimal CalcularImpuesto(decimal salario) {
        return salario *(decimal) 0.25;
    }

}