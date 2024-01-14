using Common.Abstractions;
using Common.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Common;

/// <summary>
/// ProviderRegister
/// </summary>
public static class CommonRegister
{
    /// <summary>
    /// AddProviderServices
    /// </summary>
    /// <param name="services"></param>
    public static void RegisterProviders(this IServiceCollection services)
    {
        services.AddTransient<IConfigProvider, ConfigProvider>();
        services.AddTransient<ICookieProvider, CookieProvider>();
        services.AddTransient<IHashProvider, HashProvider>();
        services.AddTransient<IStringProvider, StringProvider>();
        services.AddTransient<IMemCacheProvider, MemCacheProvider>();
    }
}
