using System;
using Cosmos.Dependency;
using Cosmos.MimeTypeSniffers;

namespace AspectCore.DependencyInjection
{
    public static class DependencyExtensions
    {
        public static IServiceContext AddMimeTypeSniffer(this IServiceContext context, Action<MimeTypeSnifferOptions> configure = null)
        {
            using (var register = new AspectCoreProxyRegister(context))
            {
                register.AddMimeTypeSniffer(configure);
            }

            return context;
        }
    }
}