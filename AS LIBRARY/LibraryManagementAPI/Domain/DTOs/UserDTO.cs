using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Domain.DTOs
{
    public class UserDTO
    {
        public string Name { get; set; }
        public List<BookDTO> BorrowedBooks { get; set; }
    }
}