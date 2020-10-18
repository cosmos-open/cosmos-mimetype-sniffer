using System.Collections.Generic;

namespace Cosmos.Sniffers.MimeTypeSniffers.Core
{
    public interface IMimeTypeFinder
    {
        string GetMimeType(string extensionName);
        IEnumerable<string> GetMimeTypes(List<string> extensionNames);
    }
}
