using AutoMapper;
using LibraryManagementAPI.Domain.DTOs;
using LibraryManagementAPI.Domain.Models;
using LibraryManagementAPI.Domain.ViewModels;

namespace LibraryManagementAPI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookViewModel>().ReverseMap();
            CreateMap<Author, AuthorViewModel>().ReverseMap();
            CreateMap<User, UserViewModel>().ReverseMap();

            CreateMap<BookDTO, Book>().ReverseMap();
            CreateMap<AuthorDTO, Author>().ReverseMap();
            CreateMap<UserDTO, User>().ReverseMap();
        }
    }
}
