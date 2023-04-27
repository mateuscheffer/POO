using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02
{
    interface IPessoa
    {
        string Nome { get; set; }
        int Idade { get; set; }
        void Falar();
    }
    class Professor : IPessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Falar()
        {
            Console.WriteLine("Bom dia, eu sou o professor " + Nome + " e tenho " + Idade + " anos.");
        }
    }
    class Aluno : IPessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Falar()
        {
            Console.WriteLine("Oi, eu sou o aluno " + Nome + " e tenho " + Idade + " anos.");
        }
    }
}
