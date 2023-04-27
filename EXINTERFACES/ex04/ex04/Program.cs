using System;
using System.Globalization;
namespace ex04;
class Program
{
    static void Main(string[] args)
    {
        var calculadora = new Calculadora();

        Console.WriteLine("Digite dois números:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Soma: " + calculadora.Somar(a, b));
        Console.WriteLine("Subtração: " + calculadora.Subtrair(a, b));
        Console.WriteLine("Multiplicação: " + calculadora.Multiplicar(a, b));

        try
        {
            Console.WriteLine("Divisão: " + calculadora.Dividir(a, b));
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadKey();
    }
}