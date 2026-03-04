namespace ProjectStructure3.Application;

public interface IAiService
{
    Task<string> PromptAiAsync(string message, string model);
}