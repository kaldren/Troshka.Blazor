using AutoMapper;
using Troshka.Blazor.Domain.Entities;
using Troshka.Blazor.Domain.Entities.Car;
using Troshka.Blazor.Domain.Entities.Region;
using Troshka.Blazor.Domain.Entities.User;
using Troshka.Blazor.Models.Brand;
using Troshka.Blazor.Models.Category;
using Troshka.Blazor.Models.Coupe;
using Troshka.Blazor.Models.Currency;
using Troshka.Blazor.Models.Engine;
using Troshka.Blazor.Models.EuroStandard;
using Troshka.Blazor.Models.Material;
using Troshka.Blazor.Models.Model;
using Troshka.Blazor.Models.Offer;
using Troshka.Blazor.Models.Offer.Car;
using Troshka.Blazor.Models.Region;
using Troshka.Blazor.Models.Transmission;
using Troshka.Blazor.Models.User;

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

            CreateMap<EngineEntity, EngineModel>();
            CreateMap<TransmissionEntity, TransmissionModel>();
            CreateMap<CurrencyEntity, CurrencyModel>();
            CreateMap<EuroStandardEntity, EuroStandardModel>();
            CreateMap<MaterialEntity, MaterialModel>();

            CreateMap<UserEntity, UserModel>();
            CreateMap<CreateUserModel, UserEntity>();

            CreateMap<CreateCarOfferRequestModel, CarOfferEntity>();
            CreateMap<OfferImageEntity, OfferImageModel>()
                .ForPath(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.Url));
            CreateMap<CarOfferEntity, CarOfferModel>()
                .ForPath(dest => dest.AuthorId, opt => opt.MapFrom(src => src.Author.Id))
                .ForPath(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.Name))
                .ForPath(dest => dest.AuthorEmail, opt => opt.MapFrom(src => src.Author.Email))
                .ForPath(dest => dest.AuthorPhone, opt => opt.MapFrom(src => src.Author.Phone))
                .ForPath(dest => dest.Coupe, opt => opt.MapFrom(src => src.Coupe.Name))
                .ForPath(dest => dest.Brand, opt => opt.MapFrom(src => src.Brand.Name))
                .ForPath(dest => dest.Model, opt => opt.MapFrom(src => src.Model.Name))
                .ForPath(dest => dest.Engine, opt => opt.MapFrom(src => src.Engine.Name))
                .ForPath(dest => dest.Transmission, opt => opt.MapFrom(src => src.Transmission.Name))
                .ForPath(dest => dest.Material, opt => opt.MapFrom(src => src.Material.Name))
                .ForPath(dest => dest.Region, opt => opt.MapFrom(src => src.Region.Name))
                .ForPath(dest => dest.Location, opt => opt.MapFrom(src => src.Location.Name))
                .ForPath(dest => dest.EuroStandard, opt => opt.MapFrom(src => src.EuroStandard.Name))
                .ForPath(dest => dest.Currency, opt => opt.MapFrom(src => src.Currency.Name))
                .ForPath(dest => dest.Images, opt => opt.MapFrom(src => src.Images));
        }
    }
}
