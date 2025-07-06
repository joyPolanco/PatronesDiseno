public class EmpleadoTiempoCompleto :Empleado
{
    public EmpleadoTiempoCompleto(string nombre, decimal salario) : base(nombre,  salario)
    {
        ImpuestoEstrategia = new CalculoTiempoCompleto();
        Tipo = "Empleado tiempo completo";


    }

}