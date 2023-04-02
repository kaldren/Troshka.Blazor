using Troshka.Blazor.Models;
using Troshka.Blazor.Models.Offer;

namespace Troshka.Blazor.Services.Offer
{
    public interface IOfferService
    {
        ResultModel<OfferModel> Post(CreateOfferRequestModel model);
    }
}
