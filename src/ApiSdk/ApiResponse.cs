using System.Text.Json.Serialization;

namespace ApiSdk;

public sealed class ApiResponse<T>
{
    public int StatusCode { get; }
    public string Message { get; } = null!;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public T? Data { get; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ApiResponseError? Error { get; }

    private ApiResponse(int? statusCode = null, string? message = null, T? data = default, ApiResponseError? error = null)
    {
        StatusCode = statusCode ?? 200;
        Message = message ?? "OK";
        Data = data;
        Error = error;
    }

    public static ApiResponse<T> Ok(T? data)
    {
        return new ApiResponse<T>(200, "OK", data);
    }

    public static ApiResponse<T> Created(T? data)
    {
        return new ApiResponse<T>(201, "Created", data);
    }

    public static ApiResponse<T> BadRequest(ApiResponseError? error)
    {
        return new ApiResponse<T>(400, "Bad Request", default, error);
    }

    public static ApiResponse<T> NotFound(ApiResponseError? error)
    {
        return new ApiResponse<T>(404, "Not Found", default, error);
    }
}
