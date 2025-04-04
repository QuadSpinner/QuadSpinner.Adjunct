using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace QuadSpinner.Adjunct.WPF;

internal static partial class WPF
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static void Visible(this FrameworkElement f) => f.Visibility = Visibility.Visible;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static void Collapse(this FrameworkElement f) => f.Visibility = Visibility.Collapsed;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static void Hide(this FrameworkElement f) => f.Visibility = Visibility.Hidden;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static Visibility ToVisibility(this bool value) => value ? Visibility.Visible : Visibility.Collapsed;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static bool IsChecked(this CheckBox chk) => chk.IsChecked == true;

    internal static bool IsChecked(this ToggleButton chk) => chk.IsChecked == true;

    internal static bool IsEmpty(this string s) => string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s);

    internal static bool NotEmpty(this string s) => !string.IsNullOrEmpty(s);

    internal static bool Enable(this FrameworkElement f) => f.IsEnabled = true;

    internal static bool Disable(this FrameworkElement f) => f.IsEnabled = false;
}