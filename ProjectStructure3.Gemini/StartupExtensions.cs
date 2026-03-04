using Microsoft.Extensions.DependencyInjection;
using ProjectStructure3.Agent;
using ProjectStructure3.Gemini.ApiClient;

namespace ProjectStructure3.Gemini;

public static class StartupExtensions
{
    public static IServiceCollection AddGemini(this IServiceCollection services)
    {
        services.AddKeyedScoped<IAiAgent, GeminiAiAgent>("gemini");

        services.AddScoped<IGeminiClient, GeminiClient>();

        return services;
    }
}