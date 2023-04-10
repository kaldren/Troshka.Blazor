namespace Troshka.Blazor.Services.FileStorage
{
    public class FileStorage : IFileStorage
    {
        public async Task<bool> StoreAsync(IFormFile[] files)
        {
            return true;
        }
    }
}
