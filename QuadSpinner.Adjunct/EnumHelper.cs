using System.Runtime.CompilerServices;

namespace QuadSpinner.Adjunct;

/// <summary>
/// Provides utility methods for working with enums.
/// </summary>
public static class EnumHelper
{
    /// <summary>Parses a string into an enum value (case-insensitive).</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static T ParseEnum<T>(string value) where T : Enum => (T)Enum.Parse(typeof(T), value, true);

    /// <summary>Converts an integer into the corresponding enum value.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static T ParseEnum<T>(int value) where T : Enum => (T)Enum.ToObject(typeof(T), value);

    /// <summary>Converts an enum value to its integer representation.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int ToInt<T>(T value) where T : Enum => Convert.ToInt32(value);

    /// <summary>Converts an enum value to its string representation.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static string ToString<T>(T value) where T : Enum => value.ToString();

    /// <summary>Returns an array of enum names as strings.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static string[] GetEnumStrings<T>() where T : Enum => Enum.GetNames(typeof(T));

    /// <summary>Returns a dictionary mapping enum names to enum values.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Dictionary<string, T> GetEnumMap<T>() where T : Enum => Enum.GetValues(typeof(T)).Cast<T>().ToDictionary(e => e.ToString(), e => e);

    /// <summary>Returns the enum values sorted in descending order of their integer representation.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static T[] GetEnumNames<T>() where T : Enum => Enum.GetValues(typeof(T)).Cast<T>().OrderByDescending(e => Convert.ToInt32(e)).ToArray();
}