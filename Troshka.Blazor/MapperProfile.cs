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

            CreateMap<CreateCarOfferRequestModel, CarOfferEntity>()
                .ForPath(dest => dest.IsRegistered, opt => opt.MapFrom(src => src.Filters.IsRegistered))
                .ForPath(dest => dest.HasABS, opt => opt.MapFrom(src => src.Filters.HasABS))
                .ForPath(dest => dest.HasESP, opt => opt.MapFrom(src => src.Filters.HasESP))
                .ForPath(dest => dest.HasASR, opt => opt.MapFrom(src => src.Filters.HasASR))
                .ForPath(dest => dest.HasHillStartAssist, opt => opt.MapFrom(src => src.Filters.HasHillStartAssist))
                .ForPath(dest => dest.HasFatigueWarningSystem, opt => opt.MapFrom(src => src.Filters.HasFatigueWarningSystem))
                .ForPath(dest => dest.HasLaneChangeAssist, opt => opt.MapFrom(src => src.Filters.HasLaneChangeAssist))
                .ForPath(dest => dest.HasBlindSpotAssist, opt => opt.MapFrom(src => src.Filters.HasBlindSpotAssist))
                .ForPath(dest => dest.HasNightVisionAssist, opt => opt.MapFrom(src => src.Filters.HasNightVisionAssist))
                .ForPath(dest => dest.HasEmergencyBrakeAssist, opt => opt.MapFrom(src => src.Filters.HasEmergencyBrakeAssist))
                .ForPath(dest => dest.HasEmergencyCallSystem, opt => opt.MapFrom(src => src.Filters.HasEmergencyCallSystem))
                .ForPath(dest => dest.HasTrafficSignRecognition, opt => opt.MapFrom(src => src.Filters.HasTrafficSignRecognition))
                .ForPath(dest => dest.HasCruiseControl, opt => opt.MapFrom(src => src.Filters.HasCruiseControl))
                .ForPath(dest => dest.HasAdaptiveCruiseControl, opt => opt.MapFrom(src => src.Filters.HasAdaptiveCruiseControl))
                .ForPath(dest => dest.HasSpeedLimitControlSystem, opt => opt.MapFrom(src => src.Filters.HasSpeedLimitControlSystem))
                .ForPath(dest => dest.HasDistanceWarningSystem, opt => opt.MapFrom(src => src.Filters.HasDistanceWarningSystem))
                .ForPath(dest => dest.HasDriverAirbag, opt => opt.MapFrom(src => src.Filters.HasDriverAirbag))
                .ForPath(dest => dest.HasFrontAirbags, opt => opt.MapFrom(src => src.Filters.HasFrontAirbags))
                .ForPath(dest => dest.HasFrontAndSideAirbags, opt => opt.MapFrom(src => src.Filters.HasFrontAndSideAirbags))
                .ForPath(dest => dest.HasFrontAndSideAndMoreAirbags, opt => opt.MapFrom(src => src.Filters.HasFrontAndSideAndMoreAirbags))
                .ForPath(dest => dest.HasIsofix, opt => opt.MapFrom(src => src.Filters.HasIsofix))
                .ForPath(dest => dest.HasBiXenonHeadlights, opt => opt.MapFrom(src => src.Filters.HasBiXenonHeadlights))
                .ForPath(dest => dest.HasLaserHeadlights, opt => opt.MapFrom(src => src.Filters.HasLaserHeadlights))
                .ForPath(dest => dest.HasLedHeadlights, opt => opt.MapFrom(src => src.Filters.HasLedHeadlights))
                .ForPath(dest => dest.HasXenonHeadlights, opt => opt.MapFrom(src => src.Filters.HasXenonHeadlights))
                .ForPath(dest => dest.HasHeadlightWasherSystem, opt => opt.MapFrom(src => src.Filters.HasHeadlightWasherSystem))
                .ForPath(dest => dest.HasGlareFreeHighBeamHeadlights, opt => opt.MapFrom(src => src.Filters.HasGlareFreeHighBeamHeadlights))
                .ForPath(dest => dest.HasHighBeamAssist, opt => opt.MapFrom(src => src.Filters.HasHighBeamAssist))
                .ForPath(dest => dest.HasAdaptiveCorneringLights, opt => opt.MapFrom(src => src.Filters.HasAdaptiveCorneringLights))
                .ForPath(dest => dest.HasAdaptiveLighting, opt => opt.MapFrom(src => src.Filters.HasAdaptiveLighting))
                .ForPath(dest => dest.HasFogLamps, opt => opt.MapFrom(src => src.Filters.HasFogLamps))
                .ForPath(dest => dest.HasAlarm, opt => opt.MapFrom(src => src.Filters.HasAlarm))
                .ForPath(dest => dest.HasEngineImobilizer, opt => opt.MapFrom(src => src.Filters.HasEngineImobilizer))
                .ForPath(dest => dest.HasAirConditioner, opt => opt.MapFrom(src => src.Filters.HasAirConditioner))
                .ForPath(dest => dest.HasClimateControl, opt => opt.MapFrom(src => src.Filters.HasClimateControl))
                .ForPath(dest => dest.HasHeatedWindshield, opt => opt.MapFrom(src => src.Filters.HasHeatedWindshield))
                .ForPath(dest => dest.HasHeatedSteeringWheel, opt => opt.MapFrom(src => src.Filters.HasHeatedSteeringWheel))
                .ForPath(dest => dest.HasSelfSteeringSystems, opt => opt.MapFrom(src => src.Filters.HasSelfSteeringSystems))
                .ForPath(dest => dest.HasFrontParkAssistant, opt => opt.MapFrom(src => src.Filters.HasFrontParkAssistant))
                .ForPath(dest => dest.HasRearParkAssistant, opt => opt.MapFrom(src => src.Filters.HasRearParkAssistant))
                .ForPath(dest => dest.HasCameraAssistant, opt => opt.MapFrom(src => src.Filters.HasCameraAssistant))
                .ForPath(dest => dest.Has360DegreeCameraAssistant, opt => opt.MapFrom(src => src.Filters.Has360DegreeCameraAssistant))
                .ForPath(dest => dest.HasFrontHeatedSeats, opt => opt.MapFrom(src => src.Filters.HasFrontHeatedSeats))
                .ForPath(dest => dest.HasBackHeatedSeats, opt => opt.MapFrom(src => src.Filters.HasBackHeatedSeats))
                .ForPath(dest => dest.HasFrontAdjustableSeats, opt => opt.MapFrom(src => src.Filters.HasFrontAdjustableSeats))
                .ForPath(dest => dest.HasBackAdjustableSeats, opt => opt.MapFrom(src => src.Filters.HasBackAdjustableSeats))
                .ForPath(dest => dest.HasSportSeats, opt => opt.MapFrom(src => src.Filters.HasSportSeats))
                .ForPath(dest => dest.HasArmRest, opt => opt.MapFrom(src => src.Filters.HasArmRest))
                .ForPath(dest => dest.HasMassageSeats, opt => opt.MapFrom(src => src.Filters.HasMassageSeats))
                .ForPath(dest => dest.HasSeatVentilation, opt => opt.MapFrom(src => src.Filters.HasSeatVentilation))
                .ForPath(dest => dest.HasElectricWindows, opt => opt.MapFrom(src => src.Filters.HasElectricWindows))
                .ForPath(dest => dest.HasElectricSideMirror, opt => opt.MapFrom(src => src.Filters.HasElectricSideMirror))
                .ForPath(dest => dest.HasElectricTailgate, opt => opt.MapFrom(src => src.Filters.HasElectricTailgate))
                .ForPath(dest => dest.HasCentralLocking, opt => opt.MapFrom(src => src.Filters.HasCentralLocking))
                .ForPath(dest => dest.HasKeylessCentralLocking, opt => opt.MapFrom(src => src.Filters.HasKeylessCentralLocking))
                .ForPath(dest => dest.HasLightSensor, opt => opt.MapFrom(src => src.Filters.HasLightSensor))
                .ForPath(dest => dest.HasRainSensor, opt => opt.MapFrom(src => src.Filters.HasRainSensor))
                .ForPath(dest => dest.HasPowerAssistedSteering, opt => opt.MapFrom(src => src.Filters.HasPowerAssistedSteering))
                .ForPath(dest => dest.HasAmbientLighting, opt => opt.MapFrom(src => src.Filters.HasAmbientLighting))
                .ForPath(dest => dest.HasLeatherSteeringWheel, opt => opt.MapFrom(src => src.Filters.HasLeatherSteeringWheel))
                .ForPath(dest => dest.HasRadio, opt => opt.MapFrom(src => src.Filters.HasRadio))
                .ForPath(dest => dest.HasCDPlayer, opt => opt.MapFrom(src => src.Filters.HasCDPlayer))
                .ForPath(dest => dest.HasTV, opt => opt.MapFrom(src => src.Filters.HasTV))
                .ForPath(dest => dest.HasNavigationSystem, opt => opt.MapFrom(src => src.Filters.HasNavigationSystem))
                .ForPath(dest => dest.HasSoundSystem, opt => opt.MapFrom(src => src.Filters.HasSoundSystem))
                .ForPath(dest => dest.HasTouchScreen, opt => opt.MapFrom(src => src.Filters.HasTouchScreen))
                .ForPath(dest => dest.HasVoiceControl, opt => opt.MapFrom(src => src.Filters.HasVoiceControl))
                .ForPath(dest => dest.HasMultifunctionSteeringWheel, opt => opt.MapFrom(src => src.Filters.HasMultifunctionSteeringWheel))
                .ForPath(dest => dest.HasHandsfreeKit, opt => opt.MapFrom(src => src.Filters.HasHandsfreeKit))
                .ForPath(dest => dest.HasUSBPort, opt => opt.MapFrom(src => src.Filters.HasUSBPort))
                .ForPath(dest => dest.HasBluetooth, opt => opt.MapFrom(src => src.Filters.HasBluetooth))
                .ForPath(dest => dest.HasAppleCarPlay, opt => opt.MapFrom(src => src.Filters.HasAppleCarPlay))
                .ForPath(dest => dest.HasAndroidAuto, opt => opt.MapFrom(src => src.Filters.HasAndroidAuto))
                .ForPath(dest => dest.HasOnboardComputer, opt => opt.MapFrom(src => src.Filters.HasOnboardComputer))
                .ForPath(dest => dest.HasHeadupDisplay, opt => opt.MapFrom(src => src.Filters.HasHeadupDisplay))
                .ForPath(dest => dest.HasDigitalCockpit, opt => opt.MapFrom(src => src.Filters.HasDigitalCockpit))
                .ForPath(dest => dest.HasSummerTires, opt => opt.MapFrom(src => src.Filters.HasSummerTires))
                .ForPath(dest => dest.HasWinterTires, opt => opt.MapFrom(src => src.Filters.HasWinterTires))
                .ForPath(dest => dest.HasAllSeasonTires, opt => opt.MapFrom(src => src.Filters.HasAllSeasonTires))
                .ForPath(dest => dest.HasEmergencyTire, opt => opt.MapFrom(src => src.Filters.HasEmergencyTire))
                .ForPath(dest => dest.HasEmergencyTireKit, opt => opt.MapFrom(src => src.Filters.HasEmergencyTireKit))
                .ForPath(dest => dest.HasPanoramicRoof, opt => opt.MapFrom(src => src.Filters.HasPanoramicRoof));

            CreateMap<CarOfferModel, CreateCarOfferRequestModel>();

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
