using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_ef_continuacao.Domain.Interfaces;
using aula12_ef_test.Data;
using aula12_ef_test.Domain.Entities;

namespace aula12_ef_continuacao.Data.Repositories
{
        public class EstoqueRepository : IEstoqueRepository
    {
        private readonly DataContext context;
        public EstoqueRepository()
        {
            this.context = new DataContext();
        }
        public IList<Estoque> GetAll()
        {
            return context.Estoques.ToList();
        }
        public void Save(Estoque entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }
        public bool Delete(int entityId)
        {
            var estoque = GetById(entityId);
            context.Remove(estoque);
            context.SaveChanges();
            return true;
        }

        public Estoque GetById(int entityId)
        {
            return context.Estoques.SingleOrDefault(x=>x.Id == entityId);
        }

        public void Update(Estoque entity)
        {
            context.Estoques.Update(entity);
            context.SaveChanges();
        }

    }
}
