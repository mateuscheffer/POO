using System;
namespace Atividade_02_Aula02
{
    public class Pessoa
    {

        public string? Nome { get; set; }
        public int Idade { get; set; }


        public void Apresentar() {
            Console.WriteLine($"Meu nome é {Nome} e eu tenho {Idade} anos.");
        }


        
    }
}