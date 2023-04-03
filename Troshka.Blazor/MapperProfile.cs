using AutoMapper;
using Troshka.Blazor.Domain.Entities;
using Troshka.Blazor.Domain.Entities.Car;
using Troshka.Blazor.Domain.Entities.Region;
using Troshka.Blazor.Models.Brand;
using Troshka.Blazor.Models.Category;
using Troshka.Blazor.Models.Coupe;
using Troshka.Blazor.Models.Model;
using Troshka.Blazor.Models.Region;

namespace Troshka.Blazor
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CategoryEntity, CategoryModel>();
            CreateMap<CarBrandEntity, BrandModel>();
            CreateMap<CarModelEntity, ModelModel>();
            CreateMap<CarCoupeEntity, CoupeModel>();

            CreateMap<RegionEntity, RegionModel>();
            CreateMap<LocationEntity, LocationModel>();
        }
    }
}
