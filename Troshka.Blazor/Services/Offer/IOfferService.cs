using Troshka.Blazor.Models;
using Troshka.Blazor.Models.Offer.Car;

namespace Troshka.Blazor.Services.Offer
{
    public interface IOfferService
    {
        Task<ResultModel<CarOfferModel>> CreateCarOfferAsync(CreateCarOfferRequestModel model);
    }
}
