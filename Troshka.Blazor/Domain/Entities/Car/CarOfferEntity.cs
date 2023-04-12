using Troshka.Blazor.Domain.Entities.Region;
using Troshka.Blazor.Domain.Entities.User;
using Troshka.Blazor.Enums;

namespace Troshka.Blazor.Domain.Entities.Car
{
    public class CarOfferEntity : BaseEntity
    {
        public string CoupeId { get; set; }
        public virtual CarCoupeEntity Coupe { get; set; }
        public string BrandId { get; set; }
        public virtual CarBrandEntity Brand { get; set; }
        public string ModelId { get; set; }
        public virtual CarModelEntity Model { get; set; }
        public string EngineId { get; set; }
        public virtual EngineEntity Engine { get; set; }
        public string TransmissionId { get; set; }
        public virtual TransmissionEntity Transmission { get; set; }
        public string MaterialId { get; set; }
        public virtual MaterialEntity Material { get; set; }
        public string RegionId { get; set; }
        public virtual RegionEntity Region { get; set; }
        public string LocationId { get; set; }
        public virtual LocationEntity Location { get; set; }
        public string EuroStandardId { get; set; }
        public virtual EuroStandardEntity EuroStandard { get; set; }
        public string? CurrencyId { get; set; }
        public virtual CurrencyEntity? Currency { get; set; }
        public virtual ICollection<OfferImageEntity>? Images { get; set; }
        public string AuthorId { get; set; }
        public virtual UserEntity Author { get; set; }
        public string CategoryId { get; set; }
        public virtual CategoryEntity Category { get; set; } = new CategoryEntity { Name = CategoryTypeConstants.Cars };
        public string? Description { get; set; }
        public string? VIN { get; set; }
        public int Horsepower { get; set; }
        public int Mileage { get; set; }
        public int MonthProduced { get; set; }
        public int YearProduced { get; set; }
        public int Condition { get; set; }
        public int Cubics { get; set; }
        public decimal? Price { get; set; }
        public bool PriceUponRequest { get; set; }
        public bool IsRegistered { get; set; }
        public bool HasABS { get; set; }
        public bool HasESP { get; set; }
        public bool HasASR { get; set; }
        public bool HasHillStartAssist { get; set; }
        public bool HasFatigueWarningSystem { get; set; }
        public bool HasLaneChangeAssist { get; set; }
        public bool HasBlindSpotAssist { get; set; }
        public bool HasNightVisionAssist { get; set; }
        public bool HasEmergencyBrakeAssist { get; set; }
        public bool HasEmergencyCallSystem { get; set; }
        public bool HasTrafficSignRecognition { get; set; }
        public bool HasCruiseControl { get; set; }
        public bool HasAdaptiveCruiseControl { get; set; }
        public bool HasSpeedLimitControlSystem { get; set; }
        public bool HasDistanceWarningSystem { get; set; }
        public bool HasDriverAirbag { get; set; }
        public bool HasFrontAirbags { get; set; }
        public bool HasFrontAndSideAirbags { get; set; }
        public bool HasFrontAndSideAndMoreAirbags { get; set; }
        public bool HasIsofix { get; set; }
        public bool HasBiXenonHeadlights { get; set; }
        public bool HasLaserHeadlights { get; set; }
        public bool HasLedHeadlights { get; set; }
        public bool HasXenonHeadlights { get; set; }
        public bool HasHeadlightWasherSystem { get; set; }
        public bool HasGlareFreeHighBeamHeadlights { get; set; }
        public bool HasHighBeamAssist { get; set; }
        public bool HasAdaptiveCorneringLights { get; set; }
        public bool HasAdaptiveLighting { get; set; }
        public bool HasFogLamps { get; set; }
        public bool HasAlarm { get; set; }
        public bool HasEngineImobilizer { get; set; }

        // Comfort
        public bool HasAirConditioner { get; set; }
        public bool HasClimateControl { get; set; }
        public bool HasHeatedWindshield { get; set; }
        public bool HasHeatedSteeringWheel { get; set; }
        public bool HasSelfSteeringSystems { get; set; }
        public bool HasFrontParkAssistant { get; set; }
        public bool HasRearParkAssistant { get; set; }
        public bool HasCameraAssistant { get; set; }
        public bool Has360DegreeCameraAssistant { get; set; }
        public bool HasFrontHeatedSeats { get; set; }
        public bool HasBackHeatedSeats { get; set; }
        public bool HasFrontAdjustableSeats { get; set; }
        public bool HasBackAdjustableSeats { get; set; }
        public bool HasSportSeats { get; set; }
        public bool HasArmRest { get; set; }
        public bool HasMassageSeats { get; set; }
        public bool HasSeatVentilation { get; set; }
        public bool HasElectricWindows { get; set; }
        public bool HasElectricSideMirror { get; set; }
        public bool HasElectricTailgate { get; set; }
        public bool HasCentralLocking { get; set; }
        public bool HasKeylessCentralLocking { get; set; }
        public bool HasLightSensor { get; set; }
        public bool HasRainSensor { get; set; }
        public bool HasPowerAssistedSteering { get; set; }
        public bool HasAmbientLighting { get; set; }
        public bool HasLeatherSteeringWheel { get; set; }

        // Devices
        public bool HasRadio { get; set; }
        public bool HasCDPlayer { get; set; }
        public bool HasTV { get; set; }
        public bool HasNavigationSystem { get; set; }
        public bool HasSoundSystem { get; set; }
        public bool HasTouchScreen { get; set; }
        public bool HasVoiceControl { get; set; }
        public bool HasMultifunctionSteeringWheel { get; set; }
        public bool HasHandsfreeKit { get; set; }
        public bool HasUSBPort { get; set; }
        public bool HasBluetooth { get; set; }
        public bool HasAppleCarPlay { get; set; }
        public bool HasAndroidAuto { get; set; }
        public bool HasOnboardComputer { get; set; }
        public bool HasHeadupDisplay { get; set; }
        public bool HasDigitalCockpit { get; set; }

        // Other
        public bool HasSummerTires { get; set; }
        public bool HasWinterTires { get; set; }
        public bool HasAllSeasonTires { get; set; }
        public bool HasEmergencyTire { get; set; }
        public bool HasEmergencyTireKit { get; set; }
        public bool HasPanoramicRoof { get; set; }
    }
}
