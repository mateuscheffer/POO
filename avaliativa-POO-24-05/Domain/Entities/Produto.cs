using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace aula12_ef_test.Domain.Entities
{
        public class Produto
    {
        public int Id { get;  set; }
        public string Nome { get;  set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }


    }
}