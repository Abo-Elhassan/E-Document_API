using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Attachments
{
    public class AttachmentReadDto
    {
        public string FileName { get; set; }
        public string FileUrl{ get; set; }
        public string FileHref { get; set; }
    }
}
