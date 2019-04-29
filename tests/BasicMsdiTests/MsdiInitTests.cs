using System;
using Cosmos.Business.Extensions.FileTypeSniffers;
using Cosmos.Business.Extensions.MimeTypeSniffer;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace BasicMsdiTests
{
    public class MsdiInitTests
    {
        [Fact]
        public void MsdiTest()
        {
            var services = new ServiceCollection();
            services.AddFileTypeSniffer();
            services.AddMimeTypeSniffer();
            var provider = services.BuildServiceProvider();

            using (var scope = provider.CreateScope())
            {
                var sniffer = scope.ServiceProvider.GetService<IMimeSniffer>();

                Assert.NotNull(sniffer);
            }
        }
    }
}
