public class EmpleadoMedioTiempo :Empleado
{
    public EmpleadoMedioTiempo(string nombre, decimal salario) : base(nombre, salario)
    {
        ImpuestoEstrategia = new CalculoMedioTiempo();
        Tipo = "Empleado medio tiempo";

    }


}