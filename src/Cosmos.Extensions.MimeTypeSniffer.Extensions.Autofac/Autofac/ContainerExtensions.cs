using System;
using Autofac.Core;
using Autofac.Core.Registration;
using Cosmos.FileTypeSniffers;
using Cosmos.MimeTypeSniffer;
using Cosmos.MimeTypeSniffer.Core;

namespace Autofac
{
    public static class ContainerExtensions
    {
        public static ContainerBuilder RegisterMimeTypeSniffer(this ContainerBuilder builder, Action<AutofacMimeTypeSnifferOptions> optionAction = null)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            var options = new AutofacMimeTypeSnifferOptions();
            optionAction?.Invoke(options);

            var library = new MimeTypeLibrary();
            var defaultProvider = new DefaultMimeTypeProvider();
            library.Register(defaultProvider.GetMimeTypes());

            foreach (var provider in options.AdditionalDescriptorProvider)
            {
                library.Register(provider.GetMimeTypes());
            }

            IMimeTypeFinder finder = new MimeTypeFinder(library);
            builder.RegisterFileTypeSnifferInternalSafety(options);
            builder.Register(c => new MimeTypeSniffer(c.Resolve<IFileTypeSniffer>(), finder)).As<IMimeSniffer>().SingleInstance();

            return builder;
        }

        private static void RegisterFileTypeSnifferInternalSafety(this ContainerBuilder builder, AutofacMimeTypeSnifferOptions options)
        {
            if (builder.ComponentRegistryBuilder.IsRegistered(new TypedService(typeof(FileTypeSniffer))))
                builder.RegisterFileTypeSniffer(options.FileTypeSnifferFallbackOptions);
        }
    }
}
