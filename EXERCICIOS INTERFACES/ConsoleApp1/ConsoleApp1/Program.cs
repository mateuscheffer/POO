using ConsoleApp1;
using System;
class Program
{
    static void Main(string[] args)
    {
        var cachorro = new Cachorro();
        var gato = new Gato();
        var papagaio = new Papagaio();

        cachorro.EmitirSom();
        gato.EmitirSom();
        papagaio.EmitirSom();

        Console.ReadKey();
    }
}
