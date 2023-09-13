using Microsoft.AspNetCore.Http;
using System.Net;
using System.Text.Json;

namespace EDocument_API.Responses
{
    public record class ApiResponse<T> where T : class
    {
        public required int StatusCode { get; set; }
        public  string? Message { get; set; }
        public T? Details { get; set; }

        public ApiResponse()
        {
            
        }

        public ApiResponse(int statusCode,  T details,string? message =null)
        {
            StatusCode = statusCode;
            Message = message ?? GetMessage(statusCode);
            Details = details;
        }
        public  string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
        private string GetMessage(int statusCode)
        {
           return statusCode switch
            {
                200=> HttpStatusCode.OK.ToString(),
                400=> HttpStatusCode.BadRequest.ToString(),
                401=> HttpStatusCode.Unauthorized.ToString(),
                403 => HttpStatusCode.Forbidden.ToString(),
                404 => HttpStatusCode.NotFound.ToString(),
                500 => HttpStatusCode.InternalServerError.ToString(),
                _ =>""
            };
        }
    }
}
