using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cosmos.MimeTypeSniffers;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace IntegrationTests
{
    public class FilePathTests
    {
        private IMimeSniffer Sniffer { get; set; }
        private string Local { get; set; }

        public FilePathTests()
        {
            var services = new ServiceCollection();
            services.AddFileTypeSniffer();
            services.AddMimeTypeSniffer();
            var provider = services.BuildServiceProvider();

            Sniffer = provider.GetRequiredService<IMimeSniffer>();
            Local = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "samples");
        }

        [Fact]
        public void Zip7z()
        {
            var path = Path.Combine(Local, "sniffer.7z");
            var results = Sniffer.Match(path, 20, true);
            Assert.Contains("application/x-7z-compressed", results);
        }
    }
}
