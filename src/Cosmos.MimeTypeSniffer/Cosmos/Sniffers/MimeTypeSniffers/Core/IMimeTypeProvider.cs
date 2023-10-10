namespace Cosmos.Sniffers.MimeTypeSniffers.Core;

/// <summary>
/// MimeType Provider Interface <br />
/// MIME 类型提供者程序接口
/// </summary>
public interface IMimeTypeProvider
{
    /// <summary>
    /// Get all MimeType <br />
    /// 获取所有 MIME 类型
    /// </summary>
    /// <returns></returns>
    IDictionary<string, string> GetMimeTypes();
}