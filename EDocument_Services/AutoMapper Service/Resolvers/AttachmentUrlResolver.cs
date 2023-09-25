using AutoMapper;
using EDocument_Data.Consts;
using EDocument_Data.DTOs.Attachments;
using EDocument_Data.Models;
using Microsoft.AspNetCore.Hosting;
using System.Web;

namespace EDocument_Services.AutoMapper_Service.Resolvers
{
    public class AttachmentUrlResolver : IValueResolver<Attachment, AttachmentReadDto, string>
    {
        private readonly IWebHostEnvironment _environment;
        private readonly string _rootPath;

        public AttachmentUrlResolver(IWebHostEnvironment environment)
        {
            _environment = environment;
            _rootPath = $@"{_environment?.WebRootPath}\Attachments\";
        }

        public string Resolve(Attachment source, AttachmentReadDto destination, string destMember, ResolutionContext context)
        {
            if (System.IO.File.Exists(source.FilePath))
            {
                var fileName = source.FilePath.Replace(_rootPath, "");

                var encodedFilePath = HttpUtility.UrlEncode(fileName);

                var downloadUrl = $"{ApplicationConsts.ApiOrigin}/Download/{encodedFilePath}";
                return downloadUrl;
            }
            else
            {
                return null;
            }
        }
    }
}