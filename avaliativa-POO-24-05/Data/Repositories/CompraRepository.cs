using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_ef_continuacao.Domain.Interfaces;
using aula12_ef_test.Data;
using aula12_ef_test.Domain.Entities;

namespace aula12_ef_continuacao.Data.Repositories
{
    public class CompraRepository : ICompraRepository, IBaseRepository<Compra> 
    {
        private readonly DataContext context;
        public CompraRepository(DataContext context)
        {
            this.context = context;
        }
        public IList<Compra> GetAll()
        {
            return context.Compras.ToList();
        }
        public void Save(Compra entity)
        {
            context.Compras.Add(entity);
            context.SaveChanges();
        }

        public bool Delete(int entityId)
        {
            var person = GetById(entityId);
            context.Remove(person);
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

        internal object GetComprasPorEstoque(Estoque estoque2)
        {
            throw new NotImplementedException();
        }
    }
}