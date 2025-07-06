using CalculadoraImpuestos;

public interface IEstrategiaExportacion
{
    public string Ruta { get; }
    public void Exportar(EmpleadoDTO e);
}