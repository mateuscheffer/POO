using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula12_ef_test.Domain.Entities
{
    public class Fornecedor
    {
        public int Id { get;  set; }
        public string Nome { get;  set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }

        public static implicit operator string(Fornecedor v)
        {
            throw new NotImplementedException();
        }
    }
}