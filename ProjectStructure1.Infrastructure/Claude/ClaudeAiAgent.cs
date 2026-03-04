using ProjectStructure1.Domain;

namespace ProjectStructure1.Infrastructure.Claude;


public class ClaudeAiAgent : IAiAgent
{
    public string ParseJson(string json)
    {
        return "Claude";
    }
}