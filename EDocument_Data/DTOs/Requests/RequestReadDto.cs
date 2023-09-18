using EDocument_Data.Consts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.DTOs.Requests
{
    public class RequestReadDto
    {
        public required long Id { get; init; }
        public required int CurrentStage { get; init; }
        public required RequestStatus Status { get; init; }
        public required string Justification { get; init; }
        public required string CreatorId { get; init; }
        public required string DeclinedBy { get; init; }
        public required long DefinedRequestId { get; init; }
    }
}
