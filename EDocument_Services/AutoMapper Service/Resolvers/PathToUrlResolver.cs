using AutoMapper;
using EDocument_Data.Consts;
using EDocument_Data.DTOs.Attachments;
using EDocument_Services.File_Service;
using Microsoft.AspNetCore.Hosting;
using System.Web;

namespace EDocument_Services.AutoMapper_Service.Resolvers
{
    public class PathToUrlResolver : IValueResolver<string, AttachmentReadDto,string>
    {
        private readonly IFileService _fileService;

        public PathToUrlResolver(IFileService fileService )
        {
            _fileService = fileService;
        }

        public string Resolve(string source, AttachmentReadDto destination, string destMember, ResolutionContext context)
        {
            return _fileService.GetFileUrl(source);
        }
    }
}