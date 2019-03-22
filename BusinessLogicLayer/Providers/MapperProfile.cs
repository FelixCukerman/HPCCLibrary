using AutoMapper;
using BusinessLogicLayer.ViewModels;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Providers
{
    public class MapperProfile : Profile
    {
        public MapperProfile() : base()
        {
            CreateMap<CreateBookViewModel, Book>()
            .ForMember(x => x.Author, x => x.MapFrom(m => m.Author))
            .ForMember(x => x.Genre, x => x.Ignore())
            .ForMember(x => x.GenreId, x => x.Ignore())
            .ForMember(x => x.Language, x => x.MapFrom(m => m.Language))
            .ForMember(x => x.Publisher, x => x.MapFrom(m => m.Publisher))
            .ForMember(x => x.Title, x => x.MapFrom(m => m.Title))
            .ForMember(x => x.Year, x => x.MapFrom(m => m.Year));
        }
    }
}
