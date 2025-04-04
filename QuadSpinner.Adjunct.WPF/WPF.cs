using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Application = System.Windows.Application;
using Brush = System.Windows.Media.Brush;
using ListBox = System.Windows.Controls.ListBox;

namespace QuadSpinner.Adjunct.WPF
{
    public enum AlertType
    {
        None,
        Information,
        Warning,
        Error,
        Success
    }

    public enum BrushName
    {
        Accent, Primary, Secondary, Blue, Purple, Green, Yellow, Teal, Orange, Red, Magenta, Gray, Bright
    }

    public enum BrushSet
    {
        Standard, Muted, Strong, Transparent
    }

    internal static partial class WPF
    {
        internal static void OpenLink(string url)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", url);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        internal static BitmapImage LoadBitmap(string filename)
        {
            try
            {
                MemoryStream ms = new();
                BitmapImage bi = new();
                byte[] bytArray = File.ReadAllBytes(filename);
                ms.Write(bytArray, 0, bytArray.Length);
                ms.Position = 0;
                bi.BeginInit();
                bi.StreamSource = ms;
                bi.EndInit();
                return bi;
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal static ListBox GetParentListBox(this ListBoxItem listBoxItem)
        {
            return ItemsControl.ItemsControlFromItemContainer(listBoxItem) as ListBox;
        }

        internal static void PositionWindowOnMonitor(this Window window, int monitorIndex)
        {
            var screens = Screen.AllScreens;
            Screen screen;

            if (monitorIndex == -1)
            {
                screen = screens.First(x => x.Primary);
            }
            else if (monitorIndex >= screens.Length)
            {
                monitorIndex = 0; // Fallback to primary monitor if index is out of range
                screen = screens[monitorIndex];
            }
            else
            {
                screen = screens[monitorIndex];
            }

            window.WindowStartupLocation = WindowStartupLocation.Manual;
            window.Left = screen.WorkingArea.Left;
            window.Top = screen.WorkingArea.Top;
            window.Width = screen.WorkingArea.Width;
            window.Height = screen.WorkingArea.Height;
        }

        internal static Brush GetBrush(BrushName name, BrushSet set = BrushSet.Standard)
        {
            return Application.Current.FindResource(set switch
            {
                BrushSet.Standard => $"Accent-{Enum.GetName(typeof(BrushName), name)}",
                _ => $"Accent-{Enum.GetName(typeof(BrushSet), set)}-{Enum.GetName(typeof(BrushName), name)}"
            }) as Brush;
        }

        internal static SolidColorBrush GetSolidColorBrush(string name)
        {
            return Application.Current.FindResource(name) as SolidColorBrush;
        }

        internal static void AnimateSize(this FrameworkElement element, double newWidth, double newHeight, int durationMilliseconds = 200)
        {
            // Animate Width
            var widthAnimation = new DoubleAnimation
            {
                From = element.ActualWidth, // Start from the current width
                To = newWidth, // Animate to the new width
                Duration = TimeSpan.FromMilliseconds(durationMilliseconds)
            };
            Storyboard.SetTarget(widthAnimation, element);
            Storyboard.SetTargetProperty(widthAnimation, new PropertyPath(FrameworkElement.WidthProperty));

            // Animate Height
            var heightAnimation = new DoubleAnimation
            {
                From = element.ActualHeight, // Start from the current height
                To = newHeight, // Animate to the new height
                Duration = TimeSpan.FromMilliseconds(durationMilliseconds)
            };
            Storyboard.SetTarget(heightAnimation, element);
            Storyboard.SetTargetProperty(heightAnimation, new PropertyPath(FrameworkElement.HeightProperty));

            // Combine animations into a storyboard
            var storyboard = new Storyboard();
            storyboard.Children.Add(widthAnimation);
            storyboard.Children.Add(heightAnimation);

            // Begin the animation
            storyboard.Begin();
        }

        internal static void Delay(Action action, int delay = 150)
        {
            DispatcherTimer timer = new()
            {
                Interval = TimeSpan.FromMilliseconds(delay)
            };

            timer.Tick += (_, _) =>
            {
                timer.Stop(); // Stop the timer after the action is invoked
                action();
            };

            timer.Start();
        }

        public static BitmapSource ToBitmapSource(this byte[] bytes, int width)
        {
            PixelFormat format = PixelFormats.Rgb24;
            //Density dpi = new Density(96, DensityUnit.Undefined);
            return BitmapSource.Create(width, width, 96, 96, format, null, bytes, width * (format.BitsPerPixel / 8));
        }

        internal static string Sanitize(this object obj)
        {
            try
            {
                if (obj is float f)
                {
                    return f.ToString("#0.0#");
                }
            }
            catch (Exception)
            {
                // ignored
            }

            return obj?.ToString();
        }
    }
}