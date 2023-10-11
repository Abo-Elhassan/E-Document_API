namespace EDocument_Data.Models.Shared
{
    public class JwtSettings
    {
        public required string Issuer { get; init; }
        public required string Audience { get; init; }
        public required double DurationInDays { get; init; }

    }

    
}
