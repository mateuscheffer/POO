using System.Collections.Generic;
using System.Linq;
using LibraryManagementAPI.Data.Context;
using LibraryManagementAPI.Domain.Interfaces;
using LibraryManagementAPI.Domain.Models;

namespace LibraryManagementAPI.Data.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly DataContext _dbContext;

        public AuthorRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Author> GetAll()
        {
            return _dbContext.Authors.ToList();
        }

        public Author GetById(int id)
        {
            return _dbContext.Authors.FirstOrDefault(a => a.Id == id);
        }

        public void Add(Author author)
        {
            _dbContext.Authors.Add(author);
            _dbContext.SaveChanges();
        }

        public void Update(Author author)
        {
            _dbContext.Authors.Update(author);
            _dbContext.SaveChanges();
        }

        public void Delete(Author author)
        {
            _dbContext.Authors.Remove(author);
            _dbContext.SaveChanges();
        }
    }
}