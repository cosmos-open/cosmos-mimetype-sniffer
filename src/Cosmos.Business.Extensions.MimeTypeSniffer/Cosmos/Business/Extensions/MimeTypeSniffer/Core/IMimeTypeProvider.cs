using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos.Business.Extensions.MimeTypeSniffer.Core
{
    public interface IMimeTypeProvider
    {
        Dictionary<string, string> GetMimeTypes();
    }
}
