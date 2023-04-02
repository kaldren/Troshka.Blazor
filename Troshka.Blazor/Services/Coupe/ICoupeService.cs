using Troshka.Blazor.Models.Coupe;

namespace Troshka.Blazor.Services.Coupe
{
    public interface ICoupeService
    {
        Task<List<CoupeModel>> GetAll();
    }
}
