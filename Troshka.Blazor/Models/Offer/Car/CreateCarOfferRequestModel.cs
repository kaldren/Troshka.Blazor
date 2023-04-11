using System.ComponentModel.DataAnnotations;

namespace Troshka.Blazor.Models.Offer.Car
{
    public class CreateCarOfferRequestModel
    {
        [Required]
        public string AuthorId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required]
        public string CoupeId { get; set; }
        [Required]
        public string BrandId { get; set; }
        [Required]
        public string ModelId { get; set; }
        public string Modification { get; set; }
        [Required]
        public string EngineId { get; set; }
        [Required]
        public string TransmissionId { get; set; }
        [Required]
        public string MaterialId { get; set; }
        [Required]
        public string RegionId { get; set; }
        [Required]
        public string LocationId { get; set; }
        public string VIN { get; set; }
        [Required]
        public string EuroStandardId { get; set; }
        public string CurrencyId { get; set; }
        public string Description { get; set; }
        [Required]
        public int? Horsepower { get; set; }
        [Required]
        public int? Mileage { get; set; }
        [Required]
        public int? MonthProduced { get; set; }
        [Required]
        public int? YearProduced { get; set; }
        [Required]
        public int Condition { get; set; }
        [Required]
        public int? Cubics { get; set; }
        public decimal? Price { get; set; }
        public bool PriceUponRequest { get; set; }
        public CarOfferFiltersModel Filters { get; set; } = new();
    }
}
