using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    internal class Zebra : IImpressoraDeCodigoDeBarras
    {
        // Configurações padrão
        private int resolucao = 600;
        private double tamanhoEtiquetaLargura = 15;
        private double tamanhoEtiquetaAltura = 7;
        private string tipoEtiqueta = "Poliéster";

        public void ImprimirEtiqueta(Produto produto)
        {
            // Simulação de impressão
            Console.WriteLine("Imprimindo etiqueta na impressora Zebra:");
            Console.WriteLine($"ID: {produto.Id}, Código de barras: {produto.CodBarras}, Preço: {produto.Preco}");
            Console.WriteLine($"Resolução: {resolucao}dpi, Tamanho da etiqueta: {tamanhoEtiquetaLargura}cm x {tamanhoEtiquetaAltura}cm, Tipo de etiqueta: {tipoEtiqueta}");
            Console.WriteLine("Etiqueta impressa com sucesso!");
            Console.WriteLine("---------------------------------");
        }
    }
}
