namespace ProjectStructure3.Claude.ApiClient;

public interface IClaudeClient
{
    Task<string> CallApiAsync(string apiCall);
}