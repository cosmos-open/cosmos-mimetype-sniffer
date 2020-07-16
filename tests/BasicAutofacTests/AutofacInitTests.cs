using Autofac;
using Cosmos.FileTypeSniffers;
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
                var sniffe2 = scope.Resolve<IFileTypeSniffer>();

                Assert.NotNull(sniffer);
                Assert.NotNull(sniffe2);
            }
        }

        [Fact]
        public void AutofacTest_Safety()
        {
            var builder = new ContainerBuilder();
            builder.RegisterMimeTypeSniffer();
            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var sniffer = scope.Resolve<IMimeSniffer>();
                var sniffe2 = scope.Resolve<IFileTypeSniffer>();

                Assert.NotNull(sniffer);
                Assert.NotNull(sniffe2);
            }
        }
    }

    public interface IMimeSniffer
    {
    }
}
