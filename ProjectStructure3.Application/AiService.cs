using Microsoft.Extensions.DependencyInjection;
using ProjectStructure3.Agent;

namespace ProjectStructure3.Application;

public class AiService(IServiceScopeFactory _serviceScopeFactory) : IAiService
{
    public async Task<string> PromptAiAsync(string message, string model)
    {
        Console.WriteLine(model);

        using var scope = _serviceScopeFactory.CreateScope();

        var services = scope.ServiceProvider;

        var aiAgent = services.GetRequiredKeyedService<IAiAgent>(model);

        return await aiAgent.PromptAi(message);
    }
}