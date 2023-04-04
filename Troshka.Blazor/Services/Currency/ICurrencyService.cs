using Troshka.Blazor.Models.Currency;

namespace Troshka.Blazor.Services.Currency
{
    public interface ICurrencyService
    {
        Task<List<CurrencyModel>> GetAll();
    }
}
