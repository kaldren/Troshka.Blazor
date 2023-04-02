using Troshka.Blazor.Models.Category;

namespace Troshka.Blazor.Services.Category
{
    public interface IModelService
    {
        Task<List<CategoryModel>> GetAll();
    }
}
