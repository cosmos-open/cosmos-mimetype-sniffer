using System;
using Cosmos.Dependency;
using Cosmos.MimeTypeSniffers;

namespace Autofac
{
    public static class DependencyExtensions
    {
        public static ContainerBuilder RegisterMimeTypeSniffer(this ContainerBuilder builder, Action<MimeTypeSnifferOptions> configure = null)
        {
            using (var register = new AutofacProxyRegister(builder))
            {
                register.AddMimeTypeSniffer(configure);
            }

            return builder;
        }
    }
}