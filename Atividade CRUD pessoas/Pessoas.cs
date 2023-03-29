using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_CRUD_pessoas
{
    public class Pessoas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }


        public Pessoas(int id, string nome, string telefone) 
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
        }
    }
}
