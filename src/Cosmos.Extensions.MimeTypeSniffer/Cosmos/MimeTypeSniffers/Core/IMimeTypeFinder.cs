using System.Collections.Generic;

namespace Cosmos.MimeTypeSniffers.Core
{
    public interface IMimeTypeFinder
    {
        string GetMimeType(string extensionName);
        IEnumerable<string> GetMimeTypes(List<string> extensionNames);
    }
}
