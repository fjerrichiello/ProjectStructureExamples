namespace ProjectStructure3.Gemini.ApiClient;

internal class GeminiClient : IGeminiClient
{
    public async Task<string> CallApiAsync(string apiCall)
    {
        await Task.Delay(0);
        return "Response";
    }
}