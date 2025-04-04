using System.Runtime.CompilerServices;

namespace QuadSpinner.Adjunct;

/// <summary>
/// Provides simple utility methods for boolean manipulation.
/// </summary>
public static class MiscHelper
{
    /// <summary>Toggles a boolean value.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool Toggle(this bool b) => !b;

    /// <summary>Converts a boolean to a byte (1 for true, 0 for false).</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static byte ToByte(this bool b) => b ? (byte)1 : (byte)0;
}