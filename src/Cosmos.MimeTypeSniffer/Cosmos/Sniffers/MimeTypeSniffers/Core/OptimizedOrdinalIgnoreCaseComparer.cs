﻿using System.Runtime.CompilerServices;

namespace Cosmos.Sniffers.MimeTypeSniffers.Core;

/// <summary>
/// An optimized version of StringComparer.OrdinalIgnoreCase.
/// </summary>
/// <remarks>
/// An optimized version of <see cref="StringComparer.OrdinalIgnoreCase">StringComparer.OrdinalIgnoreCase</see>.
/// </remarks>
internal sealed class OptimizedOrdinalIgnoreCaseComparer : IEqualityComparer<string>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static int ToUpper(int c)
    {
        // check if the char is within the lowercase range
        if ((uint)(c - 'a') <= 'z' - 'a')
            return c - 0x20;

        return c;
    }

    /// <summary>
    /// Compare the input strings for equality.
    /// </summary>
    /// <remarks>
    /// Compares the input strings for equality.
    /// </remarks>
    /// <returns><c>true</c>if <paramref name="x"/> and <paramref name="y"/> refer to the same object,
    /// or <paramref name="x"/> and <paramref name="y"/> are equal,
    /// or <paramref name="x"/> and <paramref name="y"/> are <c>null</c>;
    /// otherwise, <c>false</c>.</returns>
    /// <param name="x">A string to compare to <paramref name="y"/>.</param>
    /// <param name="y">A string to compare to <paramref name="x"/>.</param>
    public bool Equals(string x, string y)
    {
        if (x == null && y == null)
            return true;

        if (x == null || y == null)
            return false;

        if (x.Length != y.Length)
            return false;

        var length = x.Length;
        for (var i = 0; i < length; i++)
        {
            if (ToUpper(x[i]) != ToUpper(y[i]))
                return false;
        }

        return true;
    }

    /// <summary>
    /// Get the hash code for the specified string.
    /// </summary>
    /// <remarks>
    /// Get the hash code for the specified string.
    /// </remarks>
    /// <returns>A 32-bit signed hash code calculated from the value of the <paramref name="obj"/> parameter.</returns>
    /// <param name="obj">The string.</param>
    /// <exception cref="System.ArgumentNullException">
    /// <paramref name="obj"/> is <c>null</c>.
    /// </exception>
    public int GetHashCode(string obj)
    {
        obj.Require();

        unsafe
        {
            unchecked
            {
                fixed (char* src = obj)
                {
                    int hash1 = 5381;
                    int hash2 = hash1;
                    char* s = src;
                    int c;

                    while ((c = s[0]) != 0)
                    {
                        hash1 = ((hash1 << 5) + hash1) ^ ToUpper(c);

                        if ((c = s[1]) == 0)
                            break;

                        hash2 = ((hash2 << 5) + hash2) ^ ToUpper(c);
                        s += 2;
                    }

                    return hash1 + (hash2 * 1566083941);
                }
            }
        }
    }
}