using System;
namespace ex;
class Program
{
    static void Main(string[] args)
    {
        List<IImpressoraDeCodigoDeBarras> impressoras = new List<IImpressoraDeCodigoDeBarras>() {
         new Elgin(),
         new Zebra()
      };

        Console.WriteLine("Digite o código de barras a ser impresso:");
        string codBarras = Console.ReadLine();

        Produto produto = new Produto()
        {
            Id = 1,
            CodBarras = codBarras,
            Preco = 9.99m
        };

        bool sucesso = true;

        foreach (IImpressoraDeCodigoDeBarras impressora in impressoras)
        {
            try
            {
                impressora.ImprimirEtiqueta(produto);
            }
            catch
            {
                sucesso = false;
            }
        }

        if (sucesso)
        {
            Console.WriteLine("Todas as etiquetas foram impressas com sucesso!");
        }
        else
        {
            Console.WriteLine("Ocorreu um erro ao imprimir as etiquetas.");
        }

        Console.ReadKey();
    }
}