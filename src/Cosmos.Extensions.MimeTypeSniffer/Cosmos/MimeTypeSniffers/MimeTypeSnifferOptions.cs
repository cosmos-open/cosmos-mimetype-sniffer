using System;
using System.Collections.Generic;
using Cosmos.FileTypeSniffers;
using Cosmos.MimeTypeSniffers.Core;

namespace Cosmos.MimeTypeSniffers
{
    public class MimeTypeSnifferOptions
    {
        private readonly List<IMimeTypeProvider> _providers;

        internal IReadOnlyList<IMimeTypeProvider> Providers => _providers;

        public MimeTypeSnifferOptions()
        {
            _providers = new List<IMimeTypeProvider>();
        }

        public void AddProvider<TProvider>(TProvider provider) where TProvider : class, IMimeTypeProvider
        {
            if (provider is null)
                throw new ArgumentNullException(nameof(provider));
            _providers.Add(provider);
        }

        public void AddProvider<TProvider>() where TProvider : class, IMimeTypeProvider, new()
        {
            var provider = new TProvider();
            AddProvider(provider);
        }

        public Action<FileTypeSnifferOptions> FileTypeSnifferFallbackOptions { get; set; }
    }
}