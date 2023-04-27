using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    public class FormatadorMinusculo : IFormatadorTexto
    {
        public string Formatar(string texto)
        {
            return texto.ToLower();
        }
    }
}
