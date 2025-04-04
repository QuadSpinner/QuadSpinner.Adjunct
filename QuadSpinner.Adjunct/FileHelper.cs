using System.Runtime.CompilerServices;

namespace QuadSpinner.Adjunct;

/// <summary>
/// Provides utility methods for file and path handling.
/// </summary>
public static class FileHelper
{
    /// <summary>Checks if the path points to an existing file.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsFile(this string path) => File.Exists(path);

    /// <summary>Checks if the path points to an existing directory.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsDirectory(this string path) => Directory.Exists(path);

    /// <summary>Changes the extension of the given path to the specified new extension.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static string WithExtension(this string path, string newExt) => Path.ChangeExtension(path, newExt);

    /// <summary>Checks if the path is null, empty, or does not point to an existing directory.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsEmptyOrDoesNotExist(string path) => string.IsNullOrEmpty(path) || !Directory.Exists(path);

    /// <summary>Returns the default path if the given path is null, empty, or does not exist.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static string AssignIfEmpty(this string path, string defaultPath) => IsEmptyOrDoesNotExist(path) ? defaultPath : path;

    /// <summary>Removes the extension from the filename and returns only the file name without extension.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static string StripExt(this string filename) => Path.GetFileNameWithoutExtension(filename);
}