using System;
using AutoMapper;
using Tailwind.Ecommerce.Domain.Entity;
using Tailwind.Ecommerce.Application.DTO;
namespace Tailwind.Ecommerce.Transversal.Mapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Customers, CustomersDto>().ReverseMap();

            //CreateMap<Customers, CustomersDto>().ReverseMap()
            //    .ForMember(destintation => destintation.CustomerId, source => source.MapFrom(src => src.CustomerId));
        }
    }
}
