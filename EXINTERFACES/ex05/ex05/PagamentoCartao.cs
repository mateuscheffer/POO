using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05
{
    public class PagamentoCartao : IServicoPagamento
    {
        public void EfetuarPagamento(double valor)
        {
            Console.WriteLine($"Pagamento de R${valor.ToString("F2")} efetuado com cartão de crédito.");
        }

        public void EstornarPagamento(double valor)
        {
            Console.WriteLine($"Pagamento de R${valor.ToString("F2")} estornado para o cartão de crédito.");
        }
    }
}
