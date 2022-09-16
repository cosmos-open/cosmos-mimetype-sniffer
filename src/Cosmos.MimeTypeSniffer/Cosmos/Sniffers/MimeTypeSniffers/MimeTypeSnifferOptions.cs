using Cosmos.Sniffers.FileTypeSniffers;
using Cosmos.Sniffers.MimeTypeSniffers.Core;

namespace Cosmos.Sniffers.MimeTypeSniffers;

/// <summary>
/// MimeType Sniffer Options <br />
/// MIME 类型嗅探器选项
/// </summary>
public class MimeTypeSnifferOptions
{
    private readonly List<IMimeTypeProvider> _providers;

    internal IReadOnlyList<IMimeTypeProvider> Providers => _providers;

    public MimeTypeSnifferOptions()
    {
        _providers = new List<IMimeTypeProvider>();
    }

    /// <summary>
    /// Add Provider <br />
    /// 添加提供者程序
    /// </summary>
    /// <param name="provider"></param>
    /// <typeparam name="TProvider"></typeparam>
    /// <exception cref="ArgumentNullException"></exception>
    public void AddProvider<TProvider>(TProvider provider) where TProvider : class, IMimeTypeProvider
    {
        if (provider is null)
            throw new ArgumentNullException(nameof(provider));
        _providers.Add(provider);
    }

    /// <summary>
    /// Add Provider <br />
    /// 添加提供者程序
    /// </summary>
    /// <typeparam name="TProvider"></typeparam>
    public void AddProvider<TProvider>() where TProvider : class, IMimeTypeProvider, new()
    {
        var provider = new TProvider();
        AddProvider(provider);
    }

    public Action<FileTypeSnifferOptions> FileTypeSnifferFallbackOptions { get; set; }
}