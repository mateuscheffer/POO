using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_ef_continuacao.Domain.Interfaces;
using aula12_ef_test.Data;
using aula12_ef_test.Domain.Entities;

namespace aula12_ef_continuacao.Data.Repositories
{   
        public class FornecedorRepository : IFornecedorRepository 
    {
        private readonly DataContext context;
        public FornecedorRepository()
        {
            this.context = new DataContext();
        }
        public IList<Fornecedor> GetAll()
        {
            return context.Fornecedores.ToList();
        }
        public void Save(Fornecedor entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }
        public bool Delete(int entityId)
        {
            var fornecedor = GetById(entityId);
            context.Remove(fornecedor);
            context.SaveChanges();
            return true;
        }

        public Fornecedor GetById(int entityId)
        {
            return context.Fornecedores.SingleOrDefault(x=>x.Id == entityId);
        }

        public void Update(Fornecedor entity)
        {
            context.Fornecedores.Update(entity);
            context.SaveChanges();
        }

    }
}