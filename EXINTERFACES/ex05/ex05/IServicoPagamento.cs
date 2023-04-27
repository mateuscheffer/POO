using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05
{
    public interface IServicoPagamento
    {
        void EfetuarPagamento(double valor);
        void EstornarPagamento(double valor);
    }
}
