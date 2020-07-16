using System;
using System.Collections.Generic;
using Cosmos.MimeTypeSniffer.Core;

namespace Microsoft.Extensions.DependencyInjection
{
    public class MsdiMimeTypeSnifferOptions : MimeTypeSnifferOptions
    {
        internal IReadOnlyList<IMimeTypeProvider> AdditionalDescriptorProvider => Providers;

        public Action<MSDIFileTypeSnifferOptions> FileTypeSnifferFallbackOptions { get; set; }
    }
}
