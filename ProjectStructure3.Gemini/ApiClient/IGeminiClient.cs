namespace ProjectStructure3.Claude.ApiClient;

public interface IGeminiClient
{
    Task<string> CallApiAsync(string apiCall);
}