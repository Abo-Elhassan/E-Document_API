namespace EDocument_Data.DTOs.Section
{
    public record struct SectionReadDto
    {
        public required string SectionId { get; init; }
        public required string SectionName { get; init; }
        public required int DepartmentId { get; init; }
    }
}