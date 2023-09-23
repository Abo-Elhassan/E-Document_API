using EDocument_Services.File_Service;
using EDocument_Data.Models.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.AspNetCore.Authorization;

namespace EDocument_API.Controllers.V1
{

    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<string>))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<string>))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ApiResponse<string>))]
    public class DownloadController : ControllerBase
    {
        private readonly IFileService _fileService;
        

        public DownloadController(IFileService fileService)
        {
            _fileService = fileService;
         
        }
        /// <summary>
        /// Download File 
        /// </summary>
        /// <param name="filePath">file path</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>targeted file</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FileStreamResult>))]
        [HttpGet("{filePath}")]
        [Authorize]
        public ActionResult DownloadFile(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
  
                var fileName = Path.GetFileName(filePath);
                var contentType = _fileService.GetContentType(filePath);

                return File(new FileStream(filePath, FileMode.Open, FileAccess.Read), contentType, fileName);
            }
            else
            {
             
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "File not found" });

            }
        }


      
    }
}
