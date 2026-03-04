using Microsoft.Extensions.DependencyInjection;
using ProjectStructure3.Agent;
using ProjectStructure3.Codex.ApiClient;

namespace ProjectStructure3.Codex;

public static class StartupExtensions
{
    public static IServiceCollection AddCodex(this IServiceCollection services)
    {
        services.AddKeyedScoped<IAiAgent, CodexAiAgent>("codex");

        services.AddScoped<ICodexClient, CodexClient>();

        return services;
    }
}