namespace ProjectStructure3.Codex.ApiClient;

internal class CodexClient : ICodexClient
{
    public async Task<string> CallApiAsync(string apiCall)
    {
        await Task.Delay(0);
        return "Response";
    }
}