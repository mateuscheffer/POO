using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAULA10
{
    interface IPagamento
    {
        void Pagar(double valor);
    }

    class CartaoCredito : IPagamento
    {
        public void Pagar(double valor)
        {
            Console.WriteLine("Pagamento realizado com cartão de crédito no valor de R$" + valor);
        }
    }

    class Boleto : IPagamento
    {
        public void Pagar(double valor)
        {
            Console.WriteLine("Pagamento realizado com boleto bancário no valor de R$" + valor);
        }
    }
}
