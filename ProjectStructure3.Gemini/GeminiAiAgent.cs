using ProjectStructure3.Agent;
using ProjectStructure3.Gemini.ApiClient;

namespace ProjectStructure3.Gemini;

internal class GeminiAiAgent(IGeminiClient geminiClient) : IAiAgent
{
    public async Task<string> PromptAi(string prompt)
    {
        var result = await geminiClient.CallApiAsync(prompt);

        //Parse Json

        return ParseJson(result);
    }

    public string ParseJson(string json)
    {
        return "Gemini";
    }
}