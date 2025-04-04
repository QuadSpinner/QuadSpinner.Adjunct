using System.Runtime.CompilerServices;

namespace QuadSpinner.Adjunct;

/// <summary>
/// Provides extension methods for string manipulation and inspection.
/// </summary>
public static class StringHelper
{
    /// <summary>Truncates the string to the specified maximum length.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static string Truncate(this string s, int maxLength) => s.Length <= maxLength ? s : s[..maxLength];

    /// <summary>Splits a string into lines, recognizing all common newline patterns.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static string[] ToLines(this string s) => s.Split(["\r\n", "\r", "\n"], StringSplitOptions.None);

    /// <summary>Removes all digits from the string.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static string WithoutDigits(this string s) => new string(s.Where(c => !char.IsDigit(c)).ToArray());

    /// <summary>Extracts only the digits from the string.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static string OnlyDigits(this string s) => new string(s.Where(char.IsDigit).ToArray());

    /// <summary>Checks if the string is null, empty, or whitespace.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsEmpty(this string s) => string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s);

    /// <summary>Checks if the string is not null or empty.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool NotEmpty(this string s) => !string.IsNullOrEmpty(s);

    /// <summary>Combines an array of strings into a single string with line breaks.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static string ToLines(this string[] lines) => string.Join(Environment.NewLine, lines.Select(line => line));

    /// <summary>Removes all occurrences of a substring from the string.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static string Strip(this string s, string toStrip) => s.Replace(toStrip, string.Empty);

    /// <summary>Checks if the string contains the given substring, ignoring case.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool ContainsIgnoreCase(this string s, string criteria) => s.IndexOf(criteria, StringComparison.CurrentCultureIgnoreCase) > -1;

    /// <summary>Checks if the string equals the given value, ignoring case.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool EqualsIgnoreCase(this string s, string criteria) => string.Equals(s, criteria, StringComparison.CurrentCultureIgnoreCase);
}