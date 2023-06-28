using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Domain.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Relacionamento: Um autor pode ter escrito vários livros
        public List<Book> Books { get; set; }
    }
}