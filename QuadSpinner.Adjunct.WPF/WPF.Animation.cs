using System.Windows;
using System.Windows.Media.Animation;

namespace QuadSpinner.Adjunct.WPF;

internal static partial class WPF
{
    internal static void FadeOutAndCollapse(this FrameworkElement element, double durationInSeconds = 0.5)
    {
        if (Features.DisableAnimations)
        {
            element.Collapse();
            element.Opacity = 0;
            return;
        }

        var fadeOutAnimation = new DoubleAnimation
        {
            From = 1.0,
            To = 0.0,
            Duration = TimeSpan.FromSeconds(durationInSeconds)
        };

        EventHandler handler = null;
        handler = (_, _) =>
        {
            element.Collapse();
            fadeOutAnimation.Completed -= handler; // Unsubscribe after the event is triggered
        };

        fadeOutAnimation.Completed += handler;
        element.BeginAnimation(UIElement.OpacityProperty, fadeOutAnimation);
    }

    internal static void FadeOut(this FrameworkElement element, double durationInSeconds = 0.5, double to = 0.0)
    {
        if (Features.DisableAnimations)
        {
            element.Opacity = to;
            return;
        }

        var fadeOutAnimation = new DoubleAnimation
        {
            From = 1.0,
            To = to,
            Duration = TimeSpan.FromSeconds(durationInSeconds)
        };

        EventHandler handler = null;
        handler = (_, _) =>
        {
            fadeOutAnimation.Completed -= handler; // Unsubscribe after the event is triggered
        };

        fadeOutAnimation.Completed += handler;
        element.BeginAnimation(UIElement.OpacityProperty, fadeOutAnimation);
    }

    internal static void FadeIn(this FrameworkElement element, double durationInSeconds = 0.2, double to = 1.0)
    {
        if (Features.DisableAnimations)
        {
            element.Opacity = to;
            return;
        }

        var fadeInAnimation = new DoubleAnimation
        {
            From = 0.0,
            To = to,
            Duration = TimeSpan.FromSeconds(durationInSeconds)
        };

        EventHandler handler = null;
        handler = (_, _) =>
        {
            fadeInAnimation.Completed -= handler; // Unsubscribe after the event is triggered
        };

        fadeInAnimation.Completed += handler;
        element.BeginAnimation(UIElement.OpacityProperty, fadeInAnimation);
    }

    internal static void FadeInAndShow(this FrameworkElement element, double durationInSeconds = 0.15, double delay = 0)
    {
        if (Features.DisableAnimations)
        {
            element.Visible();
            element.Opacity = 1;
            return;
        }

        element.Visible();

        var fadeInAnimation = new DoubleAnimation
        {
            BeginTime = TimeSpan.FromSeconds(delay),
            From = 0.0,
            To = 1.0,
            Duration = TimeSpan.FromSeconds(durationInSeconds)
        };

        EventHandler handler = null;
        handler = (_, _) =>
        {
            fadeInAnimation.Completed -= handler; // Unsubscribe after the event is triggered
        };

        fadeInAnimation.Completed += handler;
        element.BeginAnimation(UIElement.OpacityProperty, fadeInAnimation);
    }
}