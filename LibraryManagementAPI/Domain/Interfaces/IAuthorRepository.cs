using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementAPI.Data.Repositories;
using LibraryManagementAPI.Domain.Models;

namespace LibraryManagementAPI.Domain.Interfaces
{
    public interface IAuthorRepository
    {
        List<Author> GetAll();
        Author GetById(int id);
        void Add(Author author);
        void Update(Author author);
        void Delete(Author author);
    }
}
