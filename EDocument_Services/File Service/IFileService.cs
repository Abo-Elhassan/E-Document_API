using EDocument_Data.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Services.File_Service
{
    public interface IFileService
    {
        string UploadAttachment(string requestPath, IFormFile file);
        List<Attachment> UploadAttachments(long requestId, string requestPath, List<IFormFile> files, string createdBy,string? modifiedBy=null, DateTime? modifiedAt=null);
        string GetContentType(string filePath);
        string? GetFileUrl(string filePath);
        string? GetImageHref(string filePath);
        void DeleteFile(string filePath);
        void DeleteFolder(string folderPath);
    }
}
