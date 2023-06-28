using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Relacionamento: Um usuário pode emprestar vários livros
        public List<Book> BorrowedBooks { get; set; }
    }
}