using Troshka.Blazor.Models.Category;

namespace Troshka.Blazor.Services.Category
{
    public interface IBrandService
    {
        Task<List<CategoryModel>> GetAll();
    }
}
