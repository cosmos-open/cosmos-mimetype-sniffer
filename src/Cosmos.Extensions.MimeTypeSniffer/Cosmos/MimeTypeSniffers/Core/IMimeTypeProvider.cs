using System.Collections.Generic;

namespace Cosmos.MimeTypeSniffers.Core
{
    public interface IMimeTypeProvider
    {
        Dictionary<string, string> GetMimeTypes();
    }
}
