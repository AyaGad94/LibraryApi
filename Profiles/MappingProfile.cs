using AutoMapper;
using LibraryApi.DTOs;
using LibraryApi.Models;

namespace LibraryApi.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Map entity to DTO
        CreateMap<Book, BookDto>()
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));

        // Map DTO to entity
        CreateMap<BookCreateDto, Book>();
    }
}
