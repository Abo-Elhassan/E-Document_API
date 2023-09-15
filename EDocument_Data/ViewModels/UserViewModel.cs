#nullable disable

namespace EDocument_Data.ViewModels
{
    public class UserViewModel
    {
        public  string Id { get; init; }
        public  string UserName { get; init; }
        public  string FullName { get; init; }
        public  string PhoneNumber { get; init; }
        public string Position { get; init; }
        public string Department { get; init; }
        public string Section { get; init; }
        public string Company { get; init; }
        public bool IsEmployee { get; set; }
    }
}
