using System.Collections.Generic;

namespace Cosmos.MimeTypeSniffer.Core
{
    public interface IMimeTypeProvider
    {
        Dictionary<string, string> GetMimeTypes();
    }
}
