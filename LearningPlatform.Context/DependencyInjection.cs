using LearningPlatform.Context.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LearningPlatform.Context;

public static class DependencyInjection
{
    public static IServiceCollection AddContext(this IServiceCollection services, IConfiguration configuration)
    {
        // Add Repositories here : Example Below
        //services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
    
    public static IServiceCollection AddPersistence(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.AddDbContext<LearningPlatformDbContext>(options => services.AddDbContext<LearningPlatformDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }));

        return services;
    }
}