namespace EDocument_API.Shared
{
    public class ApiResponse<T> 
    {
        public required int StatusCode { get; set; }
        public required string Message { get; set; }
        public T? Content { get; set; }
    }
}
