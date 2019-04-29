using System.Collections.Generic;
using Cosmos.Business.Extensions.MimeTypeSniffer.Core;

namespace Microsoft.Extensions.DependencyInjection
{
    public class MsdiMimeTypeSnifferOptions : MimeTypeSnifferOptions
    {
        internal IReadOnlyList<IMimeTypeProvider> AdditionalDescriptorProvider => Providers;
    }
}
