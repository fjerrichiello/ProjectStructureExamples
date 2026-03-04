using ProjectStructure3.Agent;
using ProjectStructure3.Claude.ApiClient;

namespace ProjectStructure3.Claude;

public class ClaudeAiAgent(IClaudeClient claudeClient) : IAiAgent
{
    public async Task<string> PromptAi(string prompt)
    {
        var result = await claudeClient.CallApiAsync(prompt);

        //Parse Json

        return ParseJson(result);
    }

    public string ParseJson(string json)
    {
        return "Claude";
    }
}