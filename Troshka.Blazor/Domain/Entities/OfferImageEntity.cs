using Troshka.Blazor.Domain.Entities.Car;

namespace Troshka.Blazor.Domain.Entities
{
    public class OfferImageEntity : BaseEntity
    {
        public string Url { get; set; }

        public string OfferId { get; set; }
        public virtual CarOfferEntity CarOffer { get; set; }
    }
}
