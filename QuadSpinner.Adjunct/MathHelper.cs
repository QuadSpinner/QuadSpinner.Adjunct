using System.Numerics;
using System.Runtime.CompilerServices;

namespace QuadSpinner.Adjunct
{
    /// <summary>
    /// Provides mathematical extension methods for quick calculations.
    /// </summary>
    public static class MathHelper
    {
        /// <summary>Returns the square root of the given integer.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int SquareRoot(this int value) => (int)Math.Sqrt(value);

        /// <summary>Returns the square of the given integer.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Square(this int value) => value * value;

        /// <summary>Returns the square of the given float, cast to int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Square(this float value) => (int)(value * value);

        /// <summary>Returns half of the integer value, using float division and rounding down.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int HalfInt(this int value) => (int)(value / 2f);

        /// <summary>Returns half of the integer as a float.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static float Half(this int value) => value / 2f;

        /// <summary>Returns 1 minus the float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static float Invert(this float value) => 1f - value;

        /// <summary>Returns half of the double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Half(this double value) => value * 0.5;

        /// <summary>Returns half of the float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static float Half(this float value) => value * 0.5f;

        /// <summary>Returns one third of the float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static float Third(this float value) => value * 0.333333333f;

        /// <summary>Returns one third of the integer value using integer division.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Third(this int value) => value / 3;

        /// <summary>Returns one fourth of the float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static float Quarter(this float value) => value * 0.25f;

        /// <summary>Creates a vector filled with the given float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector<float> ToVector(this float value) => new Vector<float>(value);

        /// <summary>Returns one tenth of the float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static float Tenth(this float value) => value * 0.1f;

        /// <summary>Clamps the float value between 0 and 1.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static float Clamp01(this float value) => Math.Clamp(value, 0f, 1f);

        /// <summary>Clamps the integer value between a minimum and maximum.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Clamp(this int value, int min, int max) => Math.Clamp(value, min, max);

        /// <summary>Remaps the float value from one range to another.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static float Remap(this float value, float inMin, float inMax, float outMin, float outMax) => outMin + ((value - inMin) / (inMax - inMin)) * (outMax - outMin);

        /// <summary>Checks if an integer is within a specified inclusive range.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool Between(this int value, int min, int max) => value >= min && value <= max;

        /// <summary>Checks if a float is within a specified inclusive range.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool Between(this float value, float min, float max) => value >= min && value <= max;

        /// <summary>Checks if an integer is even.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsEven(this int value) => (value & 1) == 0;

        /// <summary>Checks if an integer is odd.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsOdd(this int value) => (value & 1) != 0;
    }
}