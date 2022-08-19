using Autofac;
using CosmosStack.Sniffers;
using Xunit;

// ReSharper disable once CheckNamespace
namespace BasicAutofacTest
{
    public class AutofacInitTests
    {
        [Fact]
        public void AutofacTest()
        {
            var builder = new ContainerBuilder();
            builder.RegisterCosmosFileTypeSniffer();
            builder.RegisterCosmosMimeTypeSniffer();
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
            builder.RegisterCosmosMimeTypeSniffer();
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

    public interface IMimeSniffer { }
}