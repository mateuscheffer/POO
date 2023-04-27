using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    public class FormatadorInvertido : IFormatadorTexto
    {
        public string Formatar(string texto)
        {
            char[] chars = texto.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
