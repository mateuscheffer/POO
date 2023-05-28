using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aula12_ef_test.Domain.Entities
{
public class Estoque
    {
        public int Id { get; set; }

        public string Produto { get; set; }

        public int Quantidade { get; set; }
      

    }
}