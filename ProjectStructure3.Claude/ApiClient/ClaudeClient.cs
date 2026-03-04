namespace ProjectStructure3.Claude.ApiClient;

public class ClaudeClient : IClaudeClient
{
    public async Task<string> CallApiAsync(string apiCall)
    {
        await Task.Delay(0);
        return "Response";
    }
}