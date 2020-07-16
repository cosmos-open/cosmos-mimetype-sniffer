namespace Cosmos.MimeTypeSniffer.Core.Extensions
{
    internal static class StringExtensions
    {
        public static string StartsWithDot(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return string.Empty;

            return str.StartsWith(".") ? str : $".{str}";
        }

        public static string ByDefault(this string str, string defaultValue)
        {
            return string.IsNullOrWhiteSpace(str) ? defaultValue : str;
        }
    }
}
