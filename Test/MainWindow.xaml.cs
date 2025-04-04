using System.Windows;
using System.Windows.Controls;
using QuadSpinner.Adjunct;

namespace Test
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetupUI();
        }

        private Button fadeInBtn, fadeOutBtn, collapseBtn, enableBtn, disableBtn;
        private TextBlock animatedText;

        private void SetupUI()
        {
            Title = "QuadSpinner.Adjunct.WPF Demo";
            Width = 400;
            Height = 450;

            var stack = new StackPanel
            {
                Margin = new Thickness(20),
                VerticalAlignment = VerticalAlignment.Center
            };

            animatedText = new TextBlock
            {
                Text = $"Hello! {8772.Half()} {770f.Quarter()}\nC:\\Windows\nis a directory? -> {"C:\\Windows".IsDirectory()}",
                FontSize = 18,
                HorizontalAlignment = HorizontalAlignment.Center,
                Opacity = 1,
                Visibility = Visibility.Visible,
                Margin = new Thickness(0, 0, 0, 20)
            };

            fadeInBtn = new Button { Content = "Fade In", Margin = new Thickness(5) };
            fadeOutBtn = new Button { Content = "Fade Out", Margin = new Thickness(5) };
            collapseBtn = new Button { Content = "Fade Out and Collapse", Margin = new Thickness(5) };
            enableBtn = new Button { Content = "Enable All", Margin = new Thickness(5) };
            disableBtn = new Button { Content = "Disable All", Margin = new Thickness(5) };

            fadeInBtn.Click += (_, _) => animatedText.FadeIn();
            fadeOutBtn.Click += (_, _) => animatedText.FadeOut();
            collapseBtn.Click += (_, _) => animatedText.FadeOutAndCollapse();
            enableBtn.Click += (_, _) => EnableAll();
            disableBtn.Click += (_, _) => DisableAll();

            stack.Children.Add(animatedText);
            stack.Children.Add(fadeInBtn);
            stack.Children.Add(fadeOutBtn);
            stack.Children.Add(collapseBtn);
            stack.Children.Add(enableBtn);
            stack.Children.Add(disableBtn);

            Content = stack;
        }

        private void EnableAll()
        {
            fadeInBtn.Enable();
            fadeOutBtn.Enable();
            collapseBtn.Enable();
        }

        private void DisableAll()
        {
            fadeInBtn.Disable();
            fadeOutBtn.Disable();
            collapseBtn.Disable();
        }
    }
}