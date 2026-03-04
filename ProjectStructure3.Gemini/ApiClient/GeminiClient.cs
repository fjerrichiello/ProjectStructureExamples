namespace ProjectStructure3.Claude.ApiClient;

public class GeminiClient : IGeminiClient
{
    public async Task<string> CallApiAsync(string apiCall)
    {
        await Task.Delay(0);
        return "Response";
    }
}