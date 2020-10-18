using System.Collections.Generic;

namespace Cosmos.Sniffers.MimeTypeSniffers.Core
{
    public interface IMimeTypeProvider
    {
        Dictionary<string, string> GetMimeTypes();
    }
}
