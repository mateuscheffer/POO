using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05
{
    public class PagamentoBoleto : IServicoPagamento
    {
        public void EfetuarPagamento(double valor)
        {
            Console.WriteLine($"Pagamento de R${valor.ToString("F2")} efetuado com boleto bancário.");
        }

        public void EstornarPagamento(double valor)
        {
            Console.WriteLine($"Pagamento de R${valor.ToString("F2")} estornado para o boleto bancário.");
        }
    }
}
