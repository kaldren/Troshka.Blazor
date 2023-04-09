using Microsoft.AspNetCore.Mvc;

namespace Troshka.Blazor.Controllers
{
    public class UploadController : Controller
    {
        [HttpPost("upload/multiple")]
        public IActionResult Upload(IFormFile[] files)
        {
            return Ok();
        }
    }
}
