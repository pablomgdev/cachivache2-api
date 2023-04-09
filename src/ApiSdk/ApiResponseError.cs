namespace ApiSdk;

public sealed class ApiResponseError
{
    public List<string>? List { get; set; }
    public Dictionary<string, string>? InvalidProperties { get; set; }
}
