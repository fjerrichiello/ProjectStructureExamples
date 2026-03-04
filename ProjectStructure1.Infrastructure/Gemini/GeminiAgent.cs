using ProjectStructure1.Domain;

namespace ProjectStructure1.Infrastructure.Gemini;

public class GeminiAgent : IAiAgent
{
    public string ParseJson(string json)
    {
        return "Gemini";
    }
}