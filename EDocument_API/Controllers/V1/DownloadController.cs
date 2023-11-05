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
        private readonly IWebHostEnvironment _environment;
        private readonly string _rootPath;

        public DownloadController(IWebHostEnvironment environment)
        {
            _environment = environment;
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

        /// <summary>
        /// View Image
        /// </summary>
        /// <param name="imageName">image name</param>
        /// <remarks>
        ///
        /// </remarks>
        /// <returns>targeted image</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<PhysicalFileResult>))]
        [HttpGet("/Image/{imageName}")]
        public IActionResult GetSignature(string imageName)
        {
            var decodedFileName = HttpUtility.UrlDecode(imageName);
            string imagePath = Path.Combine(_rootPath, decodedFileName);

            if (System.IO.File.Exists(imagePath))
            {
                var imageStream = System.IO.File.OpenRead(imagePath);
                return File(imageStream, "image/jpg");
              
            }
            else
            {
                return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "File not found" });
            }

        }
        // Serve the image as a file



        //public DownloadController()
        //{

        //}
        ///// <summary>
        ///// Download File 
        ///// </summary>
        ///// <param name="fileName">file name</param>
        ///// <remarks>
        /////
        ///// </remarks>
        ///// <returns>targeted file</returns>

        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<PhysicalFileResult>))]
        //[HttpGet("{fileName}")]
        //public IActionResult Download(string fileName)
        //{
        //    var decodedFileName = HttpUtility.UrlDecode(fileName);
        //    string filePath = Path.Combine(ApplicationConsts.MappedDrivePath, decodedFileName);

        //    if (System.IO.File.Exists(filePath))
        //    {
        //        return PhysicalFile(filePath, "application/octet-stream");
        //    }
        //    else
        //    {
        //        return NotFound(new ApiResponse<string> { StatusCode = (int)HttpStatusCode.NotFound, Details = "File not found" });
        //    }

        //}



    }
}
