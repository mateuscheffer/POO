using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exinterfaces
{
    internal class formatador
    {
        public interface IFormatadorTexto
        {
            string Formatar(string texto);
        }

        public class FormatadorMaiusculo : IFormatadorTexto
        {
            public string Formatar(string texto)
            {
                return texto.ToUpper();
            }
        }

        public class FormatadorMinusculo : IFormatadorTexto
        {
            public string Formatar(string texto)
            {
                return texto.ToLower();
            }
        }

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
}
