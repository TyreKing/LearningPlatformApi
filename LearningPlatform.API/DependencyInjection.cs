using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace LearningPlatform.API;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        return services;
    }
}