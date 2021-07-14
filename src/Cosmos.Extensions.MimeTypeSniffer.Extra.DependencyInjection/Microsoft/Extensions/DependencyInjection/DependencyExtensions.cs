using System;
using Cosmos.Dependency;
using Cosmos.Sniffers.MimeTypeSniffers;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyExtensions
    {
        public static IServiceCollection AddCosmosMimeTypeSniffer(this IServiceCollection services, Action<MimeTypeSnifferOptions> configure = null)
        {
            using (var register = new MicrosoftProxyRegister(services))
            {
                register.AddMimeTypeSniffer(configure);
            }

            return services;
        }
    }
}