namespace ProjectStructure3.Gemini.ApiClient;

internal interface IGeminiClient
{
    Task<string> CallApiAsync(string apiCall);
}