using Troshka.Blazor.Models.Brand;

namespace Troshka.Blazor.Services.Category
{
    public interface IBrandService
    {
        Task<List<BrandModel>> GetAll();
    }
}
