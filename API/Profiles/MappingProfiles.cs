using API.Dtos;
using AutoMapper;
using Domain.Entities;

namespace API.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<ProductDto, Product>().ReverseMap()
        .ForMember(d => d.WarehouseName, o => o.MapFrom(s => s.Warehouse.Name));
    }
}
