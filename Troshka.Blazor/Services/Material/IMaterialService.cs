using Troshka.Blazor.Models.Material;

namespace Troshka.Blazor.Services.Material
{
    public interface IMaterialService
    {
        Task<List<MaterialModel>> GetAll();
    }
}
