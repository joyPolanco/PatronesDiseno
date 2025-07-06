public class EmpleadoContrato :Empleado
{
public EmpleadoContrato(string nombre ,decimal salario) :base (nombre,salario)
{
        ImpuestoEstrategia = new CalculoPorContrato();
        Tipo = "Empleado por contrato";
}
   

}