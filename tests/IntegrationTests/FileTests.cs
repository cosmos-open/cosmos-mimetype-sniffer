using System;
using System.IO;
using Cosmos.MimeTypeSniffers;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace IntegrationTests
{
    public class FileTests
    {
        private IMimeSniffer Sniffer { get; set; }
        private string Local { get; set; }

        public FileTests()
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
            var bytes = LoadBytes("sniffer.7z", 20);
            var results = Sniffer.Match(bytes, true);
            Assert.Contains("application/x-7z-compressed", results);
        }

        private byte[] LoadBytes(string fileName, int length)
        {
            var path = Path.Combine(Local, fileName);
            byte[] array = new byte[length];
            using (var file = File.Open(path, FileMode.Open))
            {
                file.Read(array, 0, array.Length);
            }

            return array;
        }
    }
}
