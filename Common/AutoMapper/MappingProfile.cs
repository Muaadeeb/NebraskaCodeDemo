using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Common.Models;
using ModelDTOs;
using NebraskaCodeDataLibraryDemo.Db.Models;

namespace Common.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BookDTO, Book>().ReverseMap();
            CreateMap<Book, BookModel>().ReverseMap();
        }
    }
}
