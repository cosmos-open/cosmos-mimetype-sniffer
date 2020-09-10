using System.Collections.Generic;
using System.Linq;

namespace Cosmos.MimeTypeSniffers.Core
{
    public class MimeTypeLibrary
    {
        private readonly Dictionary<string, string> _mimeTypes;
        private readonly object _lockObj = new object();
        private readonly IEqualityComparer<string> OrdinalIgnoreCase = new OptimizedOrdinalIgnoreCaseComparer();

        public const string DEFAULT_MIME_TYPE = "application/octet-stream";

        public MimeTypeLibrary()
        {
            _mimeTypes = new Dictionary<string, string>(OrdinalIgnoreCase);
        }

        public void Register(string extensionName, string mimeType)
        {
            if (string.IsNullOrWhiteSpace(extensionName))
                return;

            extensionName = extensionName.StartsWithDot().ToLower();

            if (!_mimeTypes.ContainsKey(extensionName))
            {
                lock (_lockObj)
                {
                    if (!_mimeTypes.ContainsKey(extensionName))
                    {
                        _mimeTypes.Add(extensionName, mimeType.ByDefault(DEFAULT_MIME_TYPE));
                    }
                }
            }
        }

        public void Register(Dictionary<string, string> dict)
        {
            if (dict == null || !dict.Any())
                return;

            lock (_lockObj)
            {
                foreach (var kvp in dict)
                {
                    var extensionName = kvp.Key.StartsWithDot().ToLower();
                    if (!_mimeTypes.ContainsKey(extensionName))
                    {
                        _mimeTypes.Add(extensionName, kvp.Value.ByDefault(DEFAULT_MIME_TYPE));
                    }
                }
            }
        }

        public string Search(string extensionName)
        {
            _mimeTypes.TryGetValue(extensionName.StartsWithDot().ToLower(), out var mimeType);
            return mimeType.ByDefault(DEFAULT_MIME_TYPE);
        }
    }
}
