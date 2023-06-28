using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Domain.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Boolean IsAvailable = false;

        // Relacionamento: Um livro pode ter um ou mais autores
        public List<Author> Authors { get; set; }
    }
}