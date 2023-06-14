using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace aula12_ef_test.Domain.Entities
{
    public class Compra
    {
        public int Id { get;  set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public string Fornecedor { get; set; }
        public string Data { get; set; }
    }
}