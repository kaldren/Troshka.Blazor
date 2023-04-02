using Troshka.Blazor.Models.Model;

namespace Troshka.Blazor.Services.Category
{
    public interface IModelService
    {
        Task<List<ModelModel>> GetAll();
        Task<List<ModelModel>> GetAll(string brandId);
    }
}
