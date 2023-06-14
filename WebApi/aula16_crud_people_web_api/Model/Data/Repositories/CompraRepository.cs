using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_ef_continuacao.Domain.Interfaces;
using aula12_ef_test.Data;
using aula12_ef_test.Domain.Entities;

namespace aula12_ef_continuacao.Data.Repositories
{
    public class CompraRepository : ICompraRepository
    {
        private readonly DataContext context;
        public CompraRepository()
        {
            this.context = new DataContext();
        }
        public IList<Compra> GetAll()
        {
            return context.Compras.ToList();
        }
        public void Save(Compra entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }
        public bool Delete(int entityId)
        {
            var compra = GetById(entityId);
            context.Remove(compra);
            context.SaveChanges();
            return true;
        }

        public Compra GetById(int entityId)
        {
            return context.Compras.SingleOrDefault(x=>x.Id == entityId);
        }

        public void Update(Compra entity)
        {
            context.Compras.Update(entity);
            context.SaveChanges();
        }

    }
}