using Microsoft.Extensions.DependencyInjection;
using PhotoStore.Core.Abstractions;
using PhotoStore.Infrastructure.Repositories;

namespace PhotoStore.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IAlbumRepository, InMemoryAlbumRepository>();
        services.AddScoped<IPhotoRepository, InMemoryPhotoRepository>();
        return services;
    }
}