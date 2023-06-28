using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Domain.ViewModels
{
    public class BookViewModel
    {
        public string Title { get; set; }
        public List<AuthorViewModel> Authors { get; set; }
    }
}