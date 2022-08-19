using System;
using CosmosStack.Dependency;
using CosmosStack.Sniffers.MimeTypeSniffers;

namespace AspectCore.DependencyInjection
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
        /// <param name="context"></param>
        /// <param name="configure"></param>
        /// <returns></returns>
        public static IServiceContext AddCosmosMimeTypeSniffer(this IServiceContext context, Action<MimeTypeSnifferOptions> configure = null)
        {
            using (var register = new AspectCoreProxyRegister(context))
            {
                register.AddMimeTypeSniffer(configure);
            }

            return context;
        }
    }
}