using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAULA10
{
    class Cliente
    {
        private IPagamento pagamento;

        public Cliente(IPagamento pagamento)
        {
            this.pagamento = pagamento;
        }

        public void Comprar(double valor)
        {
            pagamento.Pagar(valor);
        }
    }
}
