using Cosmos.Sniffers;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

// ReSharper disable once CheckNamespace
namespace BasicMsdiTests;

public class MsdiInitTests
{
    [Fact]
    public void MsdiTest()
    {
        var services = new ServiceCollection();
        services.AddCosmosFileTypeSniffer();
        services.AddCosmosMimeTypeSniffer();
        var provider = services.BuildServiceProvider();

        using (var scope = provider.CreateScope())
        {
            var sniffer = scope.ServiceProvider.GetService<IMimeSniffer>();
            var sniffe2 = scope.ServiceProvider.GetService<IFileTypeSniffer>();

            Assert.NotNull(sniffer);
            Assert.NotNull(sniffe2);
        }
    }

    [Fact]
    public void MsdiTest_Safety()
    {
        var services = new ServiceCollection();
        services.AddCosmosMimeTypeSniffer();
        var provider = services.BuildServiceProvider();

        using (var scope = provider.CreateScope())
        {
            var sniffer = scope.ServiceProvider.GetService<IMimeSniffer>();
            var sniffe2 = scope.ServiceProvider.GetService<IFileTypeSniffer>();

            Assert.NotNull(sniffer);
            Assert.NotNull(sniffe2);
        }
    }
}