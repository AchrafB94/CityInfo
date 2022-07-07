using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/files")]
    public class FileController : Controller
    {
        private readonly FileExtensionContentTypeProvider _fileExtensionContentTypeProvider;

        public FileController(FileExtensionContentTypeProvider fileExtensionContentTypeProvider)
        {
            _fileExtensionContentTypeProvider = fileExtensionContentTypeProvider ?? throw new ArgumentNullException(nameof(fileExtensionContentTypeProvider));
        }
        [HttpGet]
        public ActionResult GetFile(string fileId)
        {
            var filepath = "test.pdf";

            if (!System.IO.File.Exists(filepath))
            {
                return NotFound();
            }

            var bytes = System.IO.File.ReadAllBytes(filepath);

            if(!_fileExtensionContentTypeProvider.TryGetContentType(filepath, out var contentType))
            {
                contentType = "application/octet-stream";
            }

            return File(bytes, contentType, Path.GetFileName(filepath));
        }
    }
}
