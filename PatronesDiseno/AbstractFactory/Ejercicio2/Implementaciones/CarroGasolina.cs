public class CarroGasolina : ICarro
{
    
    public void Encender() {
        Console.WriteLine("Encendiendo carro gasolina");
    }

    public void Arrancar()
    {
         Console.WriteLine("arrancando carro gasolina");
    }
    public void Frenar()
    {
          Console.WriteLine("Frenando carro gasolina");

    }
    public void HacerDrift()
    {
        Console.WriteLine("Haciendo drift en carro gasolina");

    }

}