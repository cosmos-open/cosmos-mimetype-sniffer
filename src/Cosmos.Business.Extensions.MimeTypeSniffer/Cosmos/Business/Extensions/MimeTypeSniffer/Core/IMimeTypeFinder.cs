using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos.Business.Extensions.MimeTypeSniffer.Core
{
    public interface IMimeTypeFinder
    {
        string GetMimeType(string extensionName);
        IEnumerable<string> GetMimeTypes(List<string> extensionNames);
    }
}
