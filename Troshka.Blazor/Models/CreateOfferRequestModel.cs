namespace Troshka.Blazor.Models
{
    public class CreateOfferRequestModel
    {
        public string CategoryId { get; set; }
        public string BrandId { get; set; }
        public string ModelId { get; set; }
        public string Year { get; set; }
        public string RegionId { get; set; }
        public string LocationId { get; set; }
        public string EngineId { get; set; }
        public string TransmissionId { get; set; }
        public int Horsepower { get; set; }
        public int Mileage { get; set; }
        public string EuroStandardId { get; set; }
        public decimal Cubics { get; set; }
        public OfferFiltersModel Filters { get; set; } = new();
    }
}
