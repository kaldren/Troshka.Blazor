using Microsoft.AspNetCore.Mvc;
using Troshka.Blazor.Services.FileStorage;

namespace Troshka.Blazor.Controllers
{
    public class UploadController : Controller
    {
        private readonly IFileStorage _fileStorage;

        public UploadController(IFileStorage fileStorage)
        {
            _fileStorage = fileStorage;
        }

        [HttpPost("upload/multiple")]
        public async Task<IActionResult> Upload(IFormFile[] files)
        {
            await _fileStorage.StoreAsync(files);
            return Ok();
        }
    }
}
