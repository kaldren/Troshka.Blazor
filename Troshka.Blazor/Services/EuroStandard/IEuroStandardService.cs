using Troshka.Blazor.Models.EuroStandard;

namespace Troshka.Blazor.Services.EuroStandard
{
    public interface IEuroStandardService
    {
        Task<List<EuroStandardModel>> GetAll();
    }
}
