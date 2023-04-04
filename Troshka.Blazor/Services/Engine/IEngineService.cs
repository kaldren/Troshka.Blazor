using Troshka.Blazor.Models.Engine;

namespace Troshka.Blazor.Services.Engine
{
    public interface IEngineService
    {
        Task<List<EngineModel>> GetAll();
    }
}
