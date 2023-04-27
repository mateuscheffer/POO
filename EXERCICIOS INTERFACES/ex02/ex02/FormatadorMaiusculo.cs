using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    public class FormatadorMaiusculo : IFormatadorTexto
    {
        public string Formatar(string texto)
        {
            return texto.ToUpper();
        }
    }
}
