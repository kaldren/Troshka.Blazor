using Troshka.Blazor.Models.Category;

namespace Troshka.Blazor.Services.Category
{
    public interface ICategoryService
    {
        Task<List<CategoryModel>> GetAll();
    }
}
