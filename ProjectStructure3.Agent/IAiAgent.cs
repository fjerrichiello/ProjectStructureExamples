namespace ProjectStructure3.Agent;

public interface IAiAgent
{
    Task<string> PromptAi(string prompt);
    
    string ParseJson(string json);
}