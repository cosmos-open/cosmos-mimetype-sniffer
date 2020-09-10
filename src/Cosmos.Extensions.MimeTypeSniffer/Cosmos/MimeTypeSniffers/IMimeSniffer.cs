using System.Collections.Generic;

namespace Cosmos.MimeTypeSniffers
{
    public interface IMimeSniffer
    {
        List<string> Match(byte[] data, bool matchAll = false);

        List<string> Match(string filePath, int simpleLength, bool matchAll = false);

        string MatchSingle(byte[] data);

        string MatchSingle(string filePath, int simpleLength);

        IMimeSniffer Expect(List<string> expectedResults);

        IMimeSniffer Expect(string expectedResult);
    }
}
