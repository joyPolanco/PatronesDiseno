public class CarroElectrico : ICarro
{
    
    public void Encender() {
        Console.WriteLine("Encendiendo carro electrico");
    }

    public void Arrancar()
    {
         Console.WriteLine("arrancando carro electrico");
    }
    public void Frenar()
    {
          Console.WriteLine("Frenando carro electrico");

    }
    public void HacerDrift()
    {
        Console.WriteLine("Haciendo drift en carro electrico");

    }

}