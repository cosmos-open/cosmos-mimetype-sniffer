namespace Cosmos.Sniffers;

/// <summary>
/// MimeSniffer Interface <br />
/// MIME 嗅探器接口
/// </summary>
public interface IMimeSniffer
{
    /// <summary>
    /// Match <br />
    /// 匹配对应的文件类型
    /// </summary>
    /// <param name="data"></param>
    /// <param name="matchAll"></param>
    /// <returns></returns>
    List<string> Match(byte[] data, bool matchAll = false);

    /// <summary>
    /// Match <br />
    /// 匹配对应的文件类型
    /// </summary>
    /// <param name="filePath"></param>
    /// <param name="simpleLength"></param>
    /// <param name="matchAll"></param>
    /// <returns></returns>
    List<string> Match(string filePath, int simpleLength, bool matchAll = false);

    /// <summary>
    /// Match Single <br />
    /// 匹配单个对应的文件类型
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    string MatchSingle(byte[] data);

    /// <summary>
    /// Match Single <br />
    /// 匹配单个对应的文件类型
    /// </summary>
    /// <param name="filePath"></param>
    /// <param name="simpleLength"></param>
    /// <returns></returns>
    string MatchSingle(string filePath, int simpleLength);

    /// <summary>
    /// Expect <br />
    /// 期待
    /// </summary>
    /// <param name="expectedResults"></param>
    /// <returns></returns>
    IMimeSniffer Expect(List<string> expectedResults);

    /// <summary>
    /// Expect <br />
    /// 期待
    /// </summary>
    /// <param name="expectedResult"></param>
    /// <returns></returns>
    IMimeSniffer Expect(string expectedResult);
}