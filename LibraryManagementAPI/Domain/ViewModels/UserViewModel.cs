using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Domain.ViewModels
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public List<BookViewModel> BorrowedBooks { get; set; }
    }
}