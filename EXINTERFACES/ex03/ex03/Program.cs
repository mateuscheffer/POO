using System;
namespace ex03;
class Program
{
    static void Main(string[] args)
    {
        Cachorro cachorro = new Cachorro();
        cachorro.Nome = "Bruce";
        cachorro.Dono = "Mateus";

        Gato gato = new Gato();
        gato.Nome = "Bino";
        gato.Dono = "Maria";

        Console.WriteLine("Cachorro: " + cachorro.Nome + ", Dono: " + cachorro.Dono);
        Console.WriteLine("Gato: " + gato.Nome + ", Dono: " + gato.Dono);

        Console.ReadKey();
    }
}
