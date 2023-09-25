using AutoMapper;
using EDocument_Data.Consts;
using EDocument_Data.DTOs.Attachments;
using Microsoft.AspNetCore.Hosting;
using System.Web;

namespace EDocument_Services.AutoMapper_Service.Resolvers
{
    public class PathToUrlResolver : IValueResolver<string, AttachmentReadDto,string>
    {
        private readonly IWebHostEnvironment _environment;
        private readonly string _rootPath;

        public PathToUrlResolver(IWebHostEnvironment environment)
        {
            _environment = environment;
            _rootPath = $@"{_environment?.WebRootPath}\Attachments\";
        }

        public string Resolve(string source, AttachmentReadDto destination, string destMember, ResolutionContext context)
        {
            if (System.IO.File.Exists(source))
            {
                var fileName = source.Replace(_rootPath, "");

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