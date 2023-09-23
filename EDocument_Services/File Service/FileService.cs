using EDocument_Data.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var folderRootPath = Path.Combine(_rootPath, folderPath);
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

        public string UploadAttachment(string requestPath, IFormFile file)
        {

            if (!Directory.Exists(_rootPath))
            {
                Directory.CreateDirectory(_rootPath);
            }
            string filePath = Path.Combine(_rootPath, requestPath, file.FileName);

            if (!Directory.Exists(Path.Combine(_rootPath, requestPath)))
            {
                Directory.CreateDirectory(Path.Combine(_rootPath, requestPath));
            }
            using (FileStream filestream = File.Create(filePath))
            {
                file.CopyTo(filestream);
                filestream.Flush();
            }

            return filePath;
        }

        public List<Attachment> UploadAttachments(long requestId, string requestPath, List<IFormFile> files, string createdBy)
        {
            var attachments = new List<Attachment>();

            if (!Directory.Exists(_rootPath))
            {
                Directory.CreateDirectory(_rootPath);
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
                    CreatedBy = createdBy
                };
                attachments.Add(attachment);

            }
            return attachments;

        }
    }
}
