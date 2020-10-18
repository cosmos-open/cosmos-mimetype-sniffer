using System;
using Cosmos.Sniffers;
using Cosmos.Sniffers.MimeTypeSniffers;
using Cosmos.Sniffers.MimeTypeSniffers.Core;
using Cosmos.Sniffers.MimeTypeSniffers.Providers;

namespace Cosmos.Dependency
{
    public static class DependencyExtensions
    {
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