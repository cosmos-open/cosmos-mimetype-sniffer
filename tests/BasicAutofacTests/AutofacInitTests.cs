using System;
using Autofac;
using Cosmos.Business.Extensions.FileTypeSniffers;
using Cosmos.Business.Extensions.MimeTypeSniffer;
using Xunit;

namespace BasicAutofacTest
{
    public class AutofacInitTests
    {
        [Fact]
        public void AutofacTest()
        {
            var builder = new ContainerBuilder();
            builder.RegisterFileTypeSniffer();
            builder.RegisterMimeTypeSniffer();
            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var sniffer = scope.Resolve<IMimeSniffer>();

                Assert.NotNull(sniffer);
            }
        }
    }
}
