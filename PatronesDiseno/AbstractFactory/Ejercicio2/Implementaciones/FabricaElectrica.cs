using System.Runtime.ConstrainedExecution;

public class FabricaElectrica :IFabrica
{
    public ICarro FabricarCarro() => new CarroElectrico();

    public IMotocicleta FabricarMotocicleta() => new MotocicletaElectrica();

}