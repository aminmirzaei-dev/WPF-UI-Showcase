using System.Diagnostics;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace CalendarDesktopUI.Views.Dialogs
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Window
    {
        public About() 
        { 
            InitializeComponent(); 
            this.Loaded += About_Loaded;
        }


        private bool _isClosing = false;

        private void About_Loaded(object sender, RoutedEventArgs e)
        {
            var duration = new Duration(
                TimeSpan.FromMilliseconds(250));

            // Fade In
            var fade = new DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = duration,
                EasingFunction = new QuadraticEase
                {
                    EasingMode = EasingMode.EaseOut
                }
            };

            // Slide Up
            var slide = new DoubleAnimation
            {
                From = 15,
                To = 0,
                Duration = duration,
                EasingFunction = new QuadraticEase
                {
                    EasingMode = EasingMode.EaseOut
                }
            };

            MainBorder.BeginAnimation(
                UIElement.OpacityProperty,
                fade);

            if (MainBorder.RenderTransform is TranslateTransform transform)
            {
                transform.BeginAnimation(
                    TranslateTransform.YProperty,
                    slide);
            }
        }


        // Close Animation

        private void CloseWithAnimation(bool result)
        {
            if (_isClosing)
                return;

            _isClosing = true;

            var duration = new Duration(
                TimeSpan.FromMilliseconds(180));

            // Fade Out
            var fade = new DoubleAnimation
            {
                From = MainBorder.Opacity,
                To = 0,
                Duration = duration,
                EasingFunction = new QuadraticEase
                {
                    EasingMode = EasingMode.EaseIn
                }
            };

            // Slide Down
            var slide = new DoubleAnimation
            {
                From = 0,
                To = 15,
                Duration = duration,
                EasingFunction = new QuadraticEase
                {
                    EasingMode = EasingMode.EaseIn
                }
            };

            fade.Completed += (s, e) =>
            {
                this.Close();
            };

            MainBorder.BeginAnimation(
                UIElement.OpacityProperty,
                fade);

            if (MainBorder.RenderTransform is TranslateTransform transform)
            {
                transform.BeginAnimation(
                    TranslateTransform.YProperty,
                    slide);
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e) { CloseWithAnimation(false); }
        private void GithubButton_Click(object sender, RoutedEventArgs e) { OpenUrl("https://github.com/aminmirzaei-dev"); }
        private void InstagramButton_Click(object sender, RoutedEventArgs e) { OpenUrl("https://instagram.com/aminmirzaei.dev"); }
        private void EmailButton_Click(object sender, RoutedEventArgs e) { OpenUrl("mailto:aminmirzaeidev@gmail.com"); }
        private static void OpenUrl(string url) { Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true }); }
    }
}
