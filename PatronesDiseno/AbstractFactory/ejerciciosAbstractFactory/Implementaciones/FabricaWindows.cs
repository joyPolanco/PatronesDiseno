public class FabricaWindows : FabricaUI
{
    public IBoton CrearBoton()
    {
        return new BotonWindows();
    }
    public IMenu CrearMenu()
    {
        return new MenuWindows();
    }
}