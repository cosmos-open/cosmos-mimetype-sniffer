using System;
using System.Collections.Generic;
using Cosmos.MimeTypeSniffer.Core;

namespace Autofac
{
    public class AutofacMimeTypeSnifferOptions : MimeTypeSnifferOptions
    {
        internal IReadOnlyList<IMimeTypeProvider> AdditionalDescriptorProvider => Providers;

        public Action<AutofacFileTypeSnifferOptions> FileTypeSnifferFallbackOptions { get; set; }
    }
}
