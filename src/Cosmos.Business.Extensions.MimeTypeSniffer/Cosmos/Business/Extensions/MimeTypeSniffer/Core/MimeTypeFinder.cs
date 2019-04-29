using System;
using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.MimeTypeSniffer.Core.Extensions;

namespace Cosmos.Business.Extensions.MimeTypeSniffer.Core
{
    public class MimeTypeFinder : IMimeTypeFinder
    {
        private readonly MimeTypeLibrary _library;

        public MimeTypeFinder(MimeTypeLibrary library)
        {
            _library = library ?? throw new ArgumentNullException(nameof(library));
        }

        public string GetMimeType(string extensionName)
        {
            if (string.IsNullOrWhiteSpace(extensionName))
                return string.Empty;

            return _library.Search(extensionName.StartsWithDot().ToLower());
        }

        public IEnumerable<string> GetMimeTypes(List<string> extensionNames)
        {
            if (extensionNames == null || !extensionNames.Any())
                return Enumerable.Empty<string>();

            var ret = new List<string>();
            foreach (var extensionName in extensionNames)
                ret.Add(GetMimeType(extensionName));
            return ret;
        }
    }
}
