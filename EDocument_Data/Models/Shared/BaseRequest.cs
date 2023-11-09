#nullable disable


namespace EDocument_Data.Models.Shared
{
    public class BaseRequest : BaseEntity
    {
        public string RequestNumber { get; set; }

        public string BeneficiaryId { get; set; }

        public string BeneficiaryName { get; set; }

        public string BeneficiaryEmail { get; set; }

        public string BeneficiaryPosition { get; set; }

        public string BeneficiaryDepartment { get; set; }

        public string BeneficiaryCompany { get; set; }

        public string BeneficiaryPhoneNumber { get; set; }

        public int? BeneficiaryExtention { get; set; }

        public long RequestId { get; set; }

        public virtual Request Request { get; set; }


    }
}
