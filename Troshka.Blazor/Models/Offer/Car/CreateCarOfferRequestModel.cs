namespace Troshka.Blazor.Models.Offer.Car
{
    public class CreateCarOfferRequestModel
    {
        public string AuthorId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CoupeId { get; set; }
        public string BrandId { get; set; }
        public string ModelId { get; set; }
        public string? Modification { get; set; }
        public string EngineId { get; set; }
        public string TransmissionId { get; set; }
        public string MaterialId { get; set; }
        public string RegionId { get; set; }
        public string LocationId { get; set; }
        public string? VIN { get; set; }
        public string EuroStandardId { get; set; }
        public string? CurrencyId { get; set; }
        public string? Description { get; set; }
        public int? Horsepower { get; set; }
        public int? Mileage { get; set; }
        public int? MonthProduced { get; set; }
        public int? YearProduced { get; set; }
        public int Condition { get; set; }
        public int? Cubics { get; set; }
        public decimal? Price { get; set; }
        public bool PriceUponRequest { get; set; }
        public CarOfferFiltersModel Filters { get; set; } = new();
    }
}
