using System;
using System.Collections.Generic;

namespace Cosmos.MimeTypeSniffer.Core
{
    public abstract class MimeTypeSnifferOptions
    {
        protected List<IMimeTypeProvider> Providers { get; set; }

        protected MimeTypeSnifferOptions()
        {
            Providers = new List<IMimeTypeProvider>();
        }

        public void AddProvider<TProvider>(TProvider provider) where TProvider : class, IMimeTypeProvider
        {
            if (provider is null)
                throw new ArgumentNullException(nameof(provider));
            Providers.Add(provider);
        }

        public void AddProvider<TProvider>() where TProvider : class, IMimeTypeProvider, new()
        {
            var provider = new TProvider();
            AddProvider(provider);
        }
    }
}
