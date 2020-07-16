using System.Collections.Generic;

namespace Cosmos.MimeTypeSniffer.Core
{
    public interface IMimeTypeFinder
    {
        string GetMimeType(string extensionName);
        IEnumerable<string> GetMimeTypes(List<string> extensionNames);
    }
}
