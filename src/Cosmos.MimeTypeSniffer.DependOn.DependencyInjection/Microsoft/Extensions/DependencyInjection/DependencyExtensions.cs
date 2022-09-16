using Cosmos.Dependency;
using Cosmos.Sniffers.MimeTypeSniffers;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Dependency Extensions <br />
/// 依赖扩展
/// </summary>
public static class DependencyExtensions
{
    /// <summary>
    /// Add Cosmos Stack Mime Type Sniffer Support.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configure"></param>
    /// <returns></returns>
    public static IServiceCollection AddCosmosMimeTypeSniffer(this IServiceCollection services, Action<MimeTypeSnifferOptions> configure = null)
    {
        using (var register = new MicrosoftProxyRegister(services))
        {
            register.RegisterMimeTypeSniffer(configure);
        }

        return services;
    }
}