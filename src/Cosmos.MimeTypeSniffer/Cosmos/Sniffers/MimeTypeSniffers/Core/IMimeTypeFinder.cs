namespace Cosmos.Sniffers.MimeTypeSniffers.Core;

/// <summary>
/// Mime Type Finder Interface <br />
/// MIME 类型查找器接口
/// </summary>
public interface IMimeTypeFinder
{
    /// <summary>
    /// Get MimeType <br />
    /// 获取 MIME 类型
    /// </summary>
    /// <param name="extensionName"></param>
    /// <returns></returns>
    string GetMimeType(string extensionName);

    /// <summary>
    /// Get a set of MimeType <br />
    /// 获取一组 MIME 类型
    /// </summary>
    /// <param name="extensionNames"></param>
    /// <returns></returns>
    IEnumerable<string> GetMimeTypes(List<string> extensionNames);
}