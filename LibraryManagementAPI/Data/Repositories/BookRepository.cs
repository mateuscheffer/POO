using System.Collections.Generic;
using System.Linq;
using LibraryManagementAPI.Data.Context;
using LibraryManagementAPI.Domain.Interfaces;
using LibraryManagementAPI.Domain.Models;

namespace LibraryManagementAPI.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _dbContext;

        public BookRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Book> GetAll()
        {
            return _dbContext.Books.ToList();
        }

        public Book GetById(int id)
        {
            return _dbContext.Books.FirstOrDefault(b => b.Id == id);
        }

        public void Add(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }

        public void Update(Book book)
        {
            _dbContext.Books.Update(book);
            _dbContext.SaveChanges();
        }

        public void Delete(Book book)
        {
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
        }
    }
}