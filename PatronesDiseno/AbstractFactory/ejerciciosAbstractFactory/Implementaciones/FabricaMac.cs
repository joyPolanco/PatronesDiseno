public class FabricaMac : FabricaUI
{
    public  IBoton CrearBoton()
    {
        return new BotonMac();
    }
     public IMenu CrearMenu()
    {
        return new MenuMac();
    }
}