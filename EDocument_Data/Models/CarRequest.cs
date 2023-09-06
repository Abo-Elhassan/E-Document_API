#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDocument_Data.Consts.Enums;
using EDocument_Data.Models.Shared;

namespace EDocument_Data.Models
{
    public class CarRequest : BaseRequest
    {
        public Governorate DepartureAddress { get; set; }

        public Governorate DestinationAddress { get; set; }

        public DateTime DepartureDate { get; set; }

        public DateTime RetrunDate { get; set; }

        public string LuggageDescription { get; set; }

        public VehicleType VehicleType { get; set; }


    }
}
