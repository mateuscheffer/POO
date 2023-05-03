using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    internal class Elgin : IImpressoraDeCodigoDeBarras
    {
        // Configurações padrão
        private int resolucao = 300;
        private double tamanhoEtiquetaLargura = 10;
        private double tamanhoEtiquetaAltura = 5;
        private string tipoEtiqueta = "Papel adesivo";

        public void ImprimirEtiqueta(Produto produto)
        {
            // Simulação de impressão
            Console.WriteLine("Imprimindo etiqueta na impressora Elgin:");
            Console.WriteLine($"ID: {produto.Id}, Código de barras: {produto.CodBarras}, Preço: {produto.Preco}");
            Console.WriteLine($"Resolução: {resolucao}dpi, Tamanho da etiqueta: {tamanhoEtiquetaLargura}cm x {tamanhoEtiquetaAltura}cm, Tipo de etiqueta: {tipoEtiqueta}");
            Console.WriteLine("Etiqueta impressa com sucesso!");
            Console.WriteLine("---------------------------------");
        }
    }
}
