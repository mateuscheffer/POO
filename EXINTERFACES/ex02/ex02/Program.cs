using ex02;
using static ex02.IFormatadorTexto;

class Program
{
    static void Main(string[] args)
    {
        string texto1 = "Ola tudo bem?";
        string texto2 = "ESTOU BEM";
        string texto3 = "111111111111";

        var formatadorMaiusculo = new FormatadorMaiusculo();
        var formatadorMinusculo = new FormatadorMinusculo();
        var formatadorInvertido = new FormatadorInvertido();

        Console.WriteLine("Texto 1:");
        Console.WriteLine("Original: " + texto1);
        Console.WriteLine("Maiúsculo: " + formatadorMaiusculo.Formatar(texto1));
        Console.WriteLine("Minúsculo: " + formatadorMinusculo.Formatar(texto1));
        Console.WriteLine("Invertido: " + formatadorInvertido.Formatar(texto1));

        Console.WriteLine("\nTexto 2:");
        Console.WriteLine("Original: " + texto2);
        Console.WriteLine("Maiúsculo: " + formatadorMaiusculo.Formatar(texto2));
        Console.WriteLine("Minúsculo: " + formatadorMinusculo.Formatar(texto2));
        Console.WriteLine("Invertido: " + formatadorInvertido.Formatar(texto2));

        Console.WriteLine("\nTexto 3:");
        Console.WriteLine("Original: " + texto3);
        Console.WriteLine("Maiúsculo: " + formatadorMaiusculo.Formatar(texto3));
        Console.WriteLine("Minúsculo: " + formatadorMinusculo.Formatar(texto3));
        Console.WriteLine("Invertido: " + formatadorInvertido.Formatar(texto3));

        Console.ReadKey();
    }
}
