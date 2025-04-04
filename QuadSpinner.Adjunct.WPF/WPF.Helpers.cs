using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace QuadSpinner.Adjunct.WPF;

public static partial class WPF
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Visible(this FrameworkElement f) => f.Visibility = Visibility.Visible;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Collapse(this FrameworkElement f) => f.Visibility = Visibility.Collapsed;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Hide(this FrameworkElement f) => f.Visibility = Visibility.Hidden;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Visibility ToVisibility(this bool value) => value ? Visibility.Visible : Visibility.Collapsed;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsChecked(this CheckBox chk) => chk.IsChecked == true;

    public static bool IsChecked(this ToggleButton chk) => chk.IsChecked == true;

    public static bool IsEmpty(this string s) => string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s);

    public static bool NotEmpty(this string s) => !string.IsNullOrEmpty(s);

    public static bool Enable(this FrameworkElement f) => f.IsEnabled = true;

    public static bool Disable(this FrameworkElement f) => f.IsEnabled = false;
}