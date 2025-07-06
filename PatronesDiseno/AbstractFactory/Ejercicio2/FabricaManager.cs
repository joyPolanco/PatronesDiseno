using System.Reflection.Metadata.Ecma335;

public class FabricaManager
{
    public static IFabrica GetFabrica(int opcionCombustible)
    {
        if (opcionCombustible == 1) return new FabricaGasolina();
        else if (opcionCombustible == 2) return new FabricaElectrica();
        else throw new Exception("Tipo de combustible no manejable");
    }
}