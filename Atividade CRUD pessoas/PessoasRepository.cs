using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_CRUD_pessoas
{
    public class PessoasRepository
    {
        private List<Pessoas> pessoasLista = new List<Pessoas>();
        public List<Pessoas> GetAll() 
        {
            return pessoasLista;
        }

        public void Add(Pessoas pessoas) 
        {
            pessoasLista.Add(pessoas);
        }

        public void Update(Pessoas pessoas) 
        {
            int index = pessoasLista.FindIndex(p => p.Id == pessoas.Id);
            if (index != -1) 
            {
                pessoasLista[index] = pessoas;
            }
        }

        public void Delete(Pessoas pessoas) 
        {
            pessoasLista.RemoveAll(p => p.Id == pessoas.Id);
        }
    }
}
