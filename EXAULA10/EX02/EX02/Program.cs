using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02;
class Program
{
    static void Main(string[] args)
    {
        IPessoa professor = new Professor { Nome = "Cassio", Idade = 42 };
        IPessoa aluno = new Aluno { Nome = "Leo", Idade = 19 };

        Escola escola = new Escola();

        escola.ApresentarPessoa(professor);
        escola.ApresentarPessoa(aluno);
    }
}