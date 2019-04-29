using System.Collections.Generic;
using System.Text;

namespace Cosmos.Business.Samples
{
    public static class StringExtensions
    {
        public static string ToListString(this IEnumerable<string> strs)
        {
            var sb = new StringBuilder();
            foreach (var str in strs)
            {
                sb.Append(str).Append(',');
            }

            return sb.Length == 0 ? string.Empty : sb.ToString(0, sb.Length - 1);
        }
    }
}