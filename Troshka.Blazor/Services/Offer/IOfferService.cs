using Troshka.Blazor.Models;
using Troshka.Blazor.Models.Offer;
using Troshka.Blazor.Models.Offer.Car;

namespace Troshka.Blazor.Services.Offer
{
    public interface IOfferService
    {
        ResultModel<OfferModel> Post(CreateCarOfferRequestModel model);
    }
}
