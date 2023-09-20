using EDocument_Data.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests.Attachments
{
    public class AttachmentReadDto
    {
            public long Id { get; init; }
            public string? FilePath { get; init; }
            public long RequestId { get; init; }
        }
}
