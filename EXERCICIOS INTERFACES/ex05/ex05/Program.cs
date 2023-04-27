using System;
namespace ex05;

public class Program
{
    static void Main(string[] args)
    {
        IServicoPagamento servicoPagamento;

        
        servicoPagamento = new PagamentoCartao();
        servicoPagamento.EfetuarPagamento(100.50);
        servicoPagamento.EstornarPagamento(50.25);

        
        servicoPagamento = new PagamentoBoleto();
        servicoPagamento.EfetuarPagamento(75.00);
        servicoPagamento.EstornarPagamento(37.50);

       
        servicoPagamento = new PagamentoPaypal();
        servicoPagamento.EfetuarPagamento(200.00);
        servicoPagamento.EstornarPagamento(100.00);

        Console.ReadKey();
    }
}