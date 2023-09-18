namespace EDocument_Data.DTOs.Section
{
    public record class SectionReadDto
    {
        public required long Id { get; init; }
        public required string SectionName { get; init; }
        public required long DepartmentId { get; init; }
    }
}