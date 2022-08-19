using System;
using CosmosStack.Sniffers;
using CosmosStack.Sniffers.MimeTypeSniffers;
using CosmosStack.Sniffers.MimeTypeSniffers.Core;
using CosmosStack.Sniffers.MimeTypeSniffers.Providers;

namespace CosmosStack.Dependency
{
    /// <summary>
    /// Dependency Extensions <br />
    /// 依赖扩展
    /// </summary>
    public static class DependencyExtensions
    {
        /// <summary>
        /// Add MimeType Sniffer Support
        /// </summary>
        /// <param name="register"></param>
        /// <param name="configure"></param>
        /// <typeparam name="TRegister"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static TRegister AddMimeTypeSniffer<TRegister>(this TRegister register, Action<MimeTypeSnifferOptions> configure = null)
            where TRegister : DependencyProxyRegister
        {
            if (register is null)
                throw new ArgumentNullException(nameof(register));

            var options = new MimeTypeSnifferOptions();
            configure?.Invoke(options);
            
            var library = new MimeTypeLibrary();
            var defaultProvider = new DefaultMimeTypeProvider();
            library.Register(defaultProvider.GetMimeTypes());

            foreach (var provider in options.Providers)
            {
                library.Register(provider.GetMimeTypes());
            }

            IMimeTypeFinder finder = new MimeTypeFinder(library);
            
            register.AddFileTypeSnifferInternalSafety(options);
            register.AddSingleton<IMimeSniffer>(p => new MimeTypeSniffer(p.RequiredResolve<IFileTypeSniffer>(), finder));

            return register;
        }
        
        private static void AddFileTypeSnifferInternalSafety<TRegister>(this TRegister register, MimeTypeSnifferOptions options)
            where TRegister : DependencyProxyRegister
        {
            if (!register.IsRegistered(typeof(IFileTypeSniffer)))
                register.AddFileTypeSniffer(options.FileTypeSnifferFallbackOptions);
        }
    }
}