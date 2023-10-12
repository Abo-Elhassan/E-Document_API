#nullable disable

using EDocument_Data;

namespace EDocument_Data.DTOs.User
{
    public class LockedUserReadDto
    {
        public string Id { get; init; }
        public string UserName { get; init; }
        public string FullName { get; init; }
        public string PhoneNumber { get; init; }
        public string Email { get; init; }
        public string Position { get; init; }
        public string Company { get; init; }
        public bool HasLDAP { get; set; }
    }
}
