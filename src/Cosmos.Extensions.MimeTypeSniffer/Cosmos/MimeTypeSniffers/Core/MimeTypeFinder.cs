using System;
using System.Collections.Generic;
using System.Linq;

namespace Cosmos.MimeTypeSniffers.Core
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
            if (extensionNames is null || !extensionNames.Any())
                return Enumerable.Empty<string>();

            return extensionNames.Select(GetMimeType).ToList();
        }
    }
}