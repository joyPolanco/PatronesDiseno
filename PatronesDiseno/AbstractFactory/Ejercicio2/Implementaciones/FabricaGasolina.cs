public class FabricaGasolina :IFabrica
{
    public ICarro FabricarCarro() => new CarroGasolina();

    public IMotocicleta FabricarMotocicleta() => new MotocicletaGasolina();

}