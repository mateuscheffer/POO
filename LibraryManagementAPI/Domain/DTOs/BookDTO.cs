using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementAPI.Domain.Models;

namespace LibraryManagementAPI.Domain.DTOs
{
    public class BookDTO
    {
        public string Title { get; set; }
        public bool IsAvailable { get; set; }
        public List<AuthorDTO> Authors { get; set; }
    }
}