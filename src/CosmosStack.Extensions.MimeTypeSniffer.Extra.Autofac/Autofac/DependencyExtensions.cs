using System;
using CosmosStack.Dependency;
using CosmosStack.Sniffers.MimeTypeSniffers;

namespace Autofac
{
    /// <summary>
    /// Dependency Extensions <br />
    /// 依赖扩展
    /// </summary>
    public static class DependencyExtensions
    {
        /// <summary>
        /// Add Cosmos Stack Mime Type Sniffer Support.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="configure"></param>
        /// <returns></returns>
        public static ContainerBuilder RegisterCosmosMimeTypeSniffer(this ContainerBuilder builder, Action<MimeTypeSnifferOptions> configure = null)
        {
            using (var register = new AutofacProxyRegister(builder))
            {
                register.AddMimeTypeSniffer(configure);
            }

            return builder;
        }
    }
}