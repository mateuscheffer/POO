using System;

public interface IAnimal
{
    void EmitirSom();
}

public class Cachorro : IAnimal
{
    public void EmitirSom()
    {
        Console.WriteLine("Au au!");
    }
}

public class Gato : IAnimal
{
    public void EmitirSom()
    {
        Console.WriteLine("Miau!");
    }
}

public class Papagaio : IAnimal
{
    public void EmitirSom()
    {
        Console.WriteLine("Olá!");
    }
}