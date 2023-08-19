#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models
{
    public class CarRequest : BaseRequest
    {
        public string DepartureAddress { get; set; }

        public string DestinationAddress { get; set; }

        public DateTime DepartureDate { get; set; }

        public DateTime RetrunDate { get; set; }

        public DateTime LuggageDescription { get; set; }

        public string CarType { get; set; }

        public string AttachmentPath { get; set; }


    }
}
