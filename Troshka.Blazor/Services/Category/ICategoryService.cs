using Troshka.Blazor.Models.Category;

namespace Troshka.Blazor.Services.Category
{
    public interface ICategoryService
    {
        Task<List<CategoryModel>> GetAllAsync();
        Task<CategoryModel> GetByOfferIdAsync(string offerId);
    }
}
