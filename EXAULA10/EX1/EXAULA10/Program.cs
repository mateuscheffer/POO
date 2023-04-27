using EXAULA10;
using System;
using System.Globalization;
namespace EXAULA10
{
    class Program
    {
        static void Main(string[] args)
        {
            IPagamento cartaoCredito = new CartaoCredito();
            IPagamento boleto = new Boleto();

            Cliente cliente1 = new Cliente(cartaoCredito);
            cliente1.Comprar(1500.0);

            Cliente cliente2 = new Cliente(boleto);
            cliente2.Comprar(550.0);
        }
    }

}
