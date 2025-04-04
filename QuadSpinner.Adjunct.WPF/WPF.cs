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
    public enum BrushName
    {
        Accent, Primary, Secondary, Blue, Purple, Green, Yellow, Teal, Orange, Red, Magenta, Gray, Bright
    }

    public enum BrushSet
    {
        Standard, Muted, Strong, Transparent
    }

    public static partial class WPF
    {
        public static void OpenLink(string url)
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

        public static BitmapImage LoadBitmap(string filename)
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

        public static ListBox GetParentListBox(this ListBoxItem listBoxItem)
        {
            return ItemsControl.ItemsControlFromItemContainer(listBoxItem) as ListBox;
        }

        public static Brush GetBrush(BrushName name, BrushSet set = BrushSet.Standard)
        {
            return Application.Current.FindResource(set switch
            {
                BrushSet.Standard => $"Accent-{Enum.GetName(typeof(BrushName), name)}",
                _ => $"Accent-{Enum.GetName(typeof(BrushSet), set)}-{Enum.GetName(typeof(BrushName), name)}"
            }) as Brush;
        }

        public static SolidColorBrush GetSolidColorBrush(string name)
        {
            return Application.Current.FindResource(name) as SolidColorBrush;
        }

        public static void AnimateSize(this FrameworkElement element, double newWidth, double newHeight, int durationMilliseconds = 200)
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

        public static void Delay(Action action, int milliseconds = 150)
        {
            Task.Run(() =>
            {
                Task.Delay(TimeSpan.FromMilliseconds(milliseconds));
                action.Invoke();
            });
        }

        public static void Dispatcher(Action action, int milliseconds = 150)
        {
            Task.Run(() =>
            {
                Task.Delay(TimeSpan.FromMilliseconds(milliseconds));
                Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Render, action);
            });
        }

        public static BitmapSource ToBitmapSource(this byte[] bytes, int width)
        {
            PixelFormat format = PixelFormats.Rgb24;
            return BitmapSource.Create(width, width, 96, 96, format, null, bytes, width * (format.BitsPerPixel / 8));
        }
    }
}