using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Common.Models;
using NebraskaCodeDataLibraryDemo.Db.Models;

namespace DataAccess.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BookModel, Book>();
            CreateMap<Book, BookModel>();
            CreateMap<Book, BookModel>().ReverseMap();
        }
    }
}
