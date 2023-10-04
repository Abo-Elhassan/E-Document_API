using EDocument_Services.File_Service;
using EDocument_Data.Models.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using EDocument_Data.Consts;
using System.Web;
using EDocument_Data.Models;
using Azure.Core;
using EDocument_Services.Mail_Service;
using System.Net.Mail;
using EDocument_EF;
using Microsoft.EntityFrameworkCore;

namespace EDocument_API.Controllers.V1
{

    [ApiController]
    [Route("api/[controller]")]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<string>))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ApiResponse<string>))]
    public class DownloadController : ControllerBase
    {
        private readonly IFileService _fileService;
        private readonly IWebHostEnvironment _environment;
        private readonly IMailService _mailService;
        private readonly ApplicationDbContext _context;
        private readonly string _rootPath;

        public DownloadController(IFileService fileService, IWebHostEnvironment environment, IMailService mailService, ApplicationDbContext context)
        {
            _fileService = fileService;
            _environment = environment;
            _mailService = mailService;
            _context = context;
            _rootPath = $@"{_environment?.WebRootPath}\Attachments\";
        }
        /// <summary>
        /// Download File 
        /// </summary>
        /// <param name="fileName">file name</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>targeted file</returns>

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<PhysicalFileResult>))]
        [HttpGet("{fileName}")]
        [Authorize]
        public IActionResult Download(string fileName)
        {


            var decodedFileName = HttpUtility.UrlDecode(fileName);
            string filePath = Path.Combine(_rootPath, decodedFileName);

            if (System.IO.File.Exists(filePath))
            {
                return PhysicalFile(filePath, "application/octet-stream");
            }
            else
            {
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "File not found" });
            }

        }


                      
    }
}
