using ProjectStructure3.Agent;
using ProjectStructure3.Codex.ApiClient;

namespace ProjectStructure3.Codex;

internal class CodexAiAgent(ICodexClient codexClient) : IAiAgent
{
    public async Task<string> PromptAi(string prompt)
    {
        var result = await codexClient.CallApiAsync(prompt);

        //Parse Json

        return ParseJson(result);
    }

    public string ParseJson(string json)
    {
        return "Codex";
    }
}