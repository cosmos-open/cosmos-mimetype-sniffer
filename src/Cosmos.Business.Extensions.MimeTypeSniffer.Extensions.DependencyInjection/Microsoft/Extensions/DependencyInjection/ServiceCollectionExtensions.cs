using System;
using Cosmos.Business.Extensions.FileTypeSniffers;
using Cosmos.Business.Extensions.MimeTypeSniffer;
using Cosmos.Business.Extensions.MimeTypeSniffer.Core;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMimeTypeSniffer(this IServiceCollection services, Action<MsdiMimeTypeSnifferOptions> optionAction = null)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            var options = new MsdiMimeTypeSnifferOptions();
            optionAction?.Invoke(options);

            var library = new MimeTypeLibrary();
            var defaultProvider = new DefaultMimeTypeProvider();
            library.Register(defaultProvider.GetMimeTypes());

            foreach (var provider in options.AdditionalDescriptorProvider)
            {
                library.Register(provider.GetMimeTypes());
            }

            IMimeTypeFinder finder = new MimeTypeFinder(library);

            services.AddSingleton<IMimeSniffer>(p => new MimeTypeSniffer(p.GetRequiredService<IFileTypeSniffer>(), finder));

            return services;
        }
    }
}
