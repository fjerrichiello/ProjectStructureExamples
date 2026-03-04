using Microsoft.Extensions.DependencyInjection;
using ProjectStructure3.Agent;
using ProjectStructure3.Claude.ApiClient;

namespace ProjectStructure3.Claude;

public static class StartupExtensions
{
    public static IServiceCollection AddClaude(this IServiceCollection services)
    {
        services.AddKeyedScoped<IAiAgent, ClaudeAiAgent>("claude");

        services.AddScoped<IClaudeClient, ClaudeClient>();

        return services;
    }
}