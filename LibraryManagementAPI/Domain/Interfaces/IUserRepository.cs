using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementAPI.Data.Repositories;
using LibraryManagementAPI.Domain.Models;

namespace LibraryManagementAPI.Domain.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User GetById(int id);
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
