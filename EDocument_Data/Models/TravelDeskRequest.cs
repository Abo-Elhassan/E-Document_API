#nullable disable
using EDocument_Data.Consts;
using EDocument_Data.Consts.Enums;
using EDocument_Data.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.Models
{
    public class TravelDeskRequest : BaseRequest
    {
        public string RequestType { get; set; }
        public string BeneficiaryNationality { get; set; }
        public string CostAllocation { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public string MissionAddress { get; set; }
        public string PaymentMethod { get; set; }
        public string FlightOrigin { get; set; }
        public string FlightDestination { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string DestinationCountry { get; set; }
        public DateTime? ExpectedTravelTime { get; set; }

    }
}
