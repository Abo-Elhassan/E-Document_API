using EDocument_Data.Consts;
using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EDocument_Services.File_Service
{
    public class FileService : IFileService
    {

        private readonly IWebHostEnvironment _environment;
        private readonly string _rootPath;

        public FileService(IWebHostEnvironment environment)
        {
            _environment = environment;
            _rootPath = $@"{_environment?.WebRootPath}\Attachments\";
        }

        public void DeleteFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);

            }
        }

        public void DeleteFolder(string folderPath)
        {
            var folderRootPath = Path.Combine(ApplicationConsts.ClientOrigin, folderPath);
            if (Directory.Exists(folderRootPath))
            {

                //Delete a Directory
                Directory.Delete(folderRootPath, true);
            }
        }

        public string GetContentType(string filePath)
        {
            string contentType = "application/unknown";
            string fileExtension = Path.GetExtension(filePath);
            var regKey = Registry.ClassesRoot.OpenSubKey(fileExtension);

            if (regKey != null && regKey.GetValue("Content Type") != null)
                contentType = regKey.GetValue("Content Type").ToString();

            return contentType;
        }

        public string? GetFileUrl(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                var fileName = filePath.Replace(_rootPath, "");

                var encodedFilePath = HttpUtility.UrlEncode(fileName);

                encodedFilePath = encodedFilePath.Replace("+", "%20");

                var downloadUrl = $"{ApplicationConsts.ApiOrigin}/Download/{encodedFilePath}";
                return downloadUrl;
            }
            else
            {
                return null;
            }

        }

        public string? GetImageHref(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                var fileName = filePath.Replace(_rootPath, "");

                var encodedFilePath = HttpUtility.UrlEncode(fileName);

                encodedFilePath = encodedFilePath.Replace("+", "%20");

                var downloadUrl = $"{ApplicationConsts.ApiOrigin}/Image/{encodedFilePath}";
                return downloadUrl;
            }
            else
            {
                return null;
            }

        }
        public string UploadAttachment(string requestPath, IFormFile file)
        {

            if (!Directory.Exists(Path.Combine(_rootPath, requestPath)))
            {
                Directory.CreateDirectory(Path.Combine(_rootPath, requestPath));
            }
            string filePath = Path.Combine(_rootPath, requestPath, file.FileName);


            using (FileStream filestream = File.Create(filePath))
            {
                file.CopyTo(filestream);
                filestream.Flush();
            }

            return filePath;
        }

        public string UploadImage(string requestPath, IFormFile file)
        {

            if (!Directory.Exists(Path.Combine(_rootPath, requestPath)))
            {
                Directory.CreateDirectory(Path.Combine(_rootPath, requestPath));
            }
            string filePath = Path.Combine(_rootPath, requestPath, file.FileName);


            using (FileStream filestream = File.Create(filePath))
            {
                file.CopyTo(filestream);
                filestream.Flush();
            }

            return filePath;
        }

        public List<Attachment> UploadAttachments(long requestId, string requestPath, List<IFormFile> files, string createdBy, string? modifiedBy = null, DateTime? modifiedAt = null)
        {
            var attachments = new List<Attachment>();

            if (!Directory.Exists(Path.Combine(_rootPath, requestPath)))
            {
                Directory.CreateDirectory(Path.Combine(_rootPath, requestPath));
            }

            foreach (var file in files)
            {
                string filePath = Path.Combine(_rootPath, requestPath, file.FileName);
                using (FileStream filestream = File.Create(filePath))
                {
                    file.CopyTo(filestream);
                    filestream.Flush();
                }
                var attachment = new Attachment
                {
                    RequestId = requestId,
                    FilePath = filePath,
                    CreatedBy = createdBy,
                    ModifiedAt = modifiedAt,
                    ModifiedBy = modifiedBy,
                };
                attachments.Add(attachment);

            }
            return attachments;

        }
    }
}


//using EDocument_Data.Consts;
//using EDocument_Data.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.Win32;

//using System.Web;

//namespace EDocument_Services.File_Service
//{
//    public class FileService : IFileService
//    {

//        public void DeleteFile(string filePath)
//        {
//            if (File.Exists(filePath))
//            {
//                File.Delete(filePath);

//            }
//        }

//        public void DeleteFolder(string folderPath)
//        {
//            var folderRootPath = Path.Combine(ApplicationConsts.ClientOrigin, folderPath);
//            if (Directory.Exists(folderRootPath))
//            {

//                //Delete a Directory
//                Directory.Delete(folderRootPath, true);
//            }
//        }

//        public string GetContentType(string filePath)
//        {
//            string contentType = "application/unknown";
//            string fileExtension = Path.GetExtension(filePath);
//            var regKey = Registry.ClassesRoot.OpenSubKey(fileExtension);

//            if (regKey != null && regKey.GetValue("Content Type") != null)
//                contentType = regKey.GetValue("Content Type").ToString();

//            return contentType;
//        }

//        public string? GetFileUrl(string filePath)
//        {
//            if (System.IO.File.Exists(filePath))
//            {
//                var fileName = filePath.Replace(ApplicationConsts.MappedDrivePath, "");

//                var encodedFilePath = HttpUtility.UrlEncode(fileName);

//                encodedFilePath = encodedFilePath.Replace("+", "%20");

//                var downloadUrl = $"{ApplicationConsts.ApiOrigin}/Download/{encodedFilePath}";
//                return downloadUrl;
//            }
//            else
//            {
//                return null;
//            }

//        }

//        public string UploadAttachment(string requestPath, IFormFile file)
//        {

//            if (!Directory.Exists(Path.Combine(ApplicationConsts.MappedDrivePath, requestPath)))
//            {
//                Directory.CreateDirectory(Path.Combine(ApplicationConsts.MappedDrivePath, requestPath));
//            }
//            string filePath = Path.Combine(ApplicationConsts.MappedDrivePath, requestPath, file.FileName);


//            using (FileStream filestream = File.Create(filePath))
//            {
//                file.CopyTo(filestream);
//                filestream.Flush();
//            }

//            return filePath;
//        }

//        public List<Attachment> UploadAttachments(long requestId, string requestPath, List<IFormFile> files, string createdBy)
//        {
//            var attachments = new List<Attachment>();

//            if (!Directory.Exists(Path.Combine(ApplicationConsts.MappedDrivePath, requestPath)))
//            {
//                Directory.CreateDirectory(Path.Combine(ApplicationConsts.MappedDrivePath, requestPath));
//            }

//            foreach (var file in files)
//            {
//                string filePath = Path.Combine(ApplicationConsts.MappedDrivePath, requestPath, file.FileName);
//                using (FileStream filestream = File.Create(filePath))
//                {
//                    file.CopyTo(filestream);
//                    filestream.Flush();
//                }
//                var attachment = new Attachment
//                {
//                    RequestId = requestId,
//                    FilePath = filePath,
//                    CreatedBy = createdBy
//                };
//                attachments.Add(attachment);

//            }
//            return attachments;

//        }
//    }
//}