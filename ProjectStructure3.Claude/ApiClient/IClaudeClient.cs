namespace ProjectStructure3.Claude.ApiClient;

internal interface IClaudeClient
{
    Task<string> CallApiAsync(string apiCall);
}