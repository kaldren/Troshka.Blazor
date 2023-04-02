using AutoMapper;
using Troshka.Blazor.Domain.Entities;
using Troshka.Blazor.Models.Category;

namespace Troshka.Blazor
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CategoryEntity, CategoryModel>();
        }
    }
}
