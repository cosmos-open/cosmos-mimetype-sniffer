using System;
using Cosmos.Dependency;
using Cosmos.MimeTypeSniffers;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyExtensions
    {
        public static IServiceCollection AddMimeTypeSniffer(this IServiceCollection services, Action<MimeTypeSnifferOptions> configure = null)
        {
            using (var register = new MicrosoftProxyRegister(services))
            {
                register.AddMimeTypeSniffer(configure);
            }

            return services;
        }
    }
}