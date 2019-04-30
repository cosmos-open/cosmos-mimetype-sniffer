using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cosmos.Business.Extensions.FileTypeSniffers;
using Cosmos.Business.Extensions.MimeTypeSniffer.Core;

namespace Cosmos.Business.Extensions.MimeTypeSniffer
{
    public class MimeTypeSniffer : IMimeSniffer
    {
        private readonly IFileTypeSniffer _innerSniffer;
        private readonly IMimeTypeFinder _finder;

        public MimeTypeSniffer(IFileTypeSniffer sniffer, IMimeTypeFinder finder)
        {
            _innerSniffer = sniffer ?? throw new ArgumentNullException(nameof(sniffer));
            _finder = finder ?? throw new ArgumentNullException(nameof(finder));
        }

        public List<string> Match(byte[] data, bool matchAll = false)
        {
            var extensionNames = _innerSniffer.Match(data, matchAll);
            return _finder.GetMimeTypes(extensionNames).ToList();
        }

        public List<string> Match(string filePath, int simpleLength, bool matchAll = false)
        {
            var extensionNames = _innerSniffer.Match(filePath, simpleLength, matchAll);
            return _finder.GetMimeTypes(extensionNames).ToList();
        }

        public string MatchSingle(byte[] data)
        {
            var extensionName = _innerSniffer.MatchSingle(data);
            return _finder.GetMimeType(extensionName);
        }


        public string MatchSingle(string filePath, int simpleLength)
        {
            var extensionName = _innerSniffer.MatchSingle(filePath, simpleLength);
            return _finder.GetMimeType(extensionName);
        }

        public IMimeSniffer Expect(List<string> expectedResults) => new ExpectedMimeTypeSniffer(_innerSniffer, _finder, expectedResults);

        public IMimeSniffer Expect(string expectedResult) => new ExpectedMimeTypeSniffer(_innerSniffer, _finder, expectedResult);
    }
}
