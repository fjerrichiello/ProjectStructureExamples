namespace ProjectStructure3.Codex.ApiClient;

internal interface ICodexClient
{
    Task<string> CallApiAsync(string apiCall);
}