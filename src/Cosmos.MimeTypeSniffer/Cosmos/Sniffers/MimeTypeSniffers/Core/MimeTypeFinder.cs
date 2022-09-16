namespace Cosmos.Sniffers.MimeTypeSniffers.Core;

/// <summary>
/// MimeType Finder <br />
/// 默认的 MIME 类型查找器
/// </summary>
public class MimeTypeFinder : IMimeTypeFinder
{
    private readonly MimeTypeLibrary _library;

    public MimeTypeFinder(MimeTypeLibrary library)
    {
        _library = library ?? throw new ArgumentNullException(nameof(library));
    }

    /// <inheritdoc />
    public string GetMimeType(string extensionName)
    {
        if (string.IsNullOrWhiteSpace(extensionName))
            return string.Empty;

        return _library.Search(extensionName.StartsWithDot().ToLower());
    }

    /// <inheritdoc />
    public IEnumerable<string> GetMimeTypes(List<string> extensionNames)
    {
        if (extensionNames is null || !extensionNames.Any())
            return Enumerable.Empty<string>();

        return extensionNames.Select(GetMimeType).ToList();
    }
}