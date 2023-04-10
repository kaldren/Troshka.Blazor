namespace Troshka.Blazor.Services.FileStorage
{
    public interface IFileStorage
    {
        Task<bool> StoreAsync(IFormFile[] files);
    }
}
