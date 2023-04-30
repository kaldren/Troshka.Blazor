using Troshka.Blazor.Models;

namespace Troshka.Blazor.Services.FileStorage
{
    public interface IFileStorage
    {
        Task<ResultModel<bool>> StoreAsync(IFormFile[] files);
    }
}
