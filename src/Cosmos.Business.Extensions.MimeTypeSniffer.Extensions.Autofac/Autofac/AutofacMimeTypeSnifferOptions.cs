using System.Collections.Generic;
using Cosmos.Business.Extensions.MimeTypeSniffer.Core;

namespace Autofac
{
    public class AutofacMimeTypeSnifferOptions : MimeTypeSnifferOptions
    {
        internal IReadOnlyList<IMimeTypeProvider> AdditionalDescriptorProvider => Providers;
    }
}
