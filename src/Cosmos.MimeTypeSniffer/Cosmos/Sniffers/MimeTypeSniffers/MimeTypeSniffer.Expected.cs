﻿using Cosmos.Sniffers.MimeTypeSniffers.Core;

namespace Cosmos.Sniffers.MimeTypeSniffers;

/// <summary>
/// Expected Mime Type Sniffer <br />
/// 具有期待值的 MIME 类型嗅探器
/// </summary>
public class ExpectedMimeTypeSniffer : IMimeSniffer
{
    private readonly IFileTypeSniffer _innerSniffer;
    private readonly List<string> _expectedResults;
    private readonly string _expectedResult;
    private readonly IMimeTypeFinder _finder;

    public ExpectedMimeTypeSniffer(IFileTypeSniffer instance, IMimeTypeFinder finder, List<string> expectedResults)
    {
        _innerSniffer = instance ?? throw new ArgumentNullException(nameof(instance));
        _expectedResults = expectedResults ?? throw new ArgumentNullException(nameof(expectedResults));
        _expectedResult = string.Empty;
        _finder = finder ?? throw new ArgumentNullException(nameof(finder));
    }

    public ExpectedMimeTypeSniffer(IFileTypeSniffer instance, IMimeTypeFinder finder, string expectedResult)
    {
        _innerSniffer = instance ?? throw new ArgumentNullException(nameof(instance));
        _expectedResults = null;
        _expectedResult = expectedResult;
        _finder = finder ?? throw new ArgumentNullException(nameof(finder));
    }

    /// <inheritdoc />
    public List<string> Match(byte[] data, bool matchAll = false)
    {
        var extensionNames = _innerSniffer.Expect(_expectedResults).Match(data);
        return _finder.GetMimeTypes(extensionNames).ToList();
    }

    /// <inheritdoc />
    public List<string> Match(string filePath, int simpleLength, bool matchAll = false)
    {
        var extensionNames = _innerSniffer.Expect(_expectedResults).Match(filePath, simpleLength);
        return _finder.GetMimeTypes(extensionNames).ToList();
    }

    /// <inheritdoc />
    public string MatchSingle(byte[] data)
    {
        var extensionName = _innerSniffer.Expect(_expectedResult).MatchSingle(data);
        return _finder.GetMimeType(extensionName);
    }

    /// <inheritdoc />
    public string MatchSingle(string filePath, int simpleLength)
    {
        var extensionName = _innerSniffer.Expect(_expectedResult).MatchSingle(filePath, simpleLength);
        return _finder.GetMimeType(extensionName);
    }

    /// <inheritdoc />
    public IMimeSniffer Expect(List<string> expectedResults) => new ExpectedMimeTypeSniffer(_innerSniffer, _finder, expectedResults);

    /// <inheritdoc />
    public IMimeSniffer Expect(string expectedResult) => new ExpectedMimeTypeSniffer(_innerSniffer, _finder, expectedResult);
}