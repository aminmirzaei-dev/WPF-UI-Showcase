using CalendarDesktopUI.Services;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace CalendarDesktopUI.Views.Dialogs
{
    /// <summary>
    /// Interaction logic for Appearance.xaml
    /// </summary>
    public partial class Appearance : Window
    {
        public Appearance()
        {
            InitializeComponent();
            this.Loaded += ExitApp_Loaded;

        }

        private ThemeService Theme => (ThemeService)Application.Current.Resources["ThemeService"];
        private PaletteService Palette => (PaletteService)Application.Current.Resources["PaletteService"];



        private bool _isClosing = false;

        private void ExitApp_Loaded(object sender, RoutedEventArgs e)
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

        private void LightThemeRadio_Checked(object sender, RoutedEventArgs e)
        {
            this.Theme.ApplyTheme(ThemeOptions.Light);
        }

        private void DarkThemeRadio_Checked(object sender, RoutedEventArgs e)
        {
            this.Theme.ApplyTheme(ThemeOptions.Dark);
        }

        private void RedColorRadio_Checked(object sender, RoutedEventArgs e)
        {
            this.Palette.ApplyPalette(PaletteOptions.Red);
        }

        private void BlueColorRadio_Checked(object sender, RoutedEventArgs e)
        {
            this.Palette.ApplyPalette(PaletteOptions.Blue);
        }

        private void GreenColorRadio_Checked(object sender, RoutedEventArgs e)
        {
            this.Palette.ApplyPalette(PaletteOptions.Green);
        }

        private void OrangeColorRadio_Checked(object sender, RoutedEventArgs e)
        {
            this.Palette.ApplyPalette(PaletteOptions.Orange);
        }

        private void PurpleColorRadio_Checked(object sender, RoutedEventArgs e)
        {
            this.Palette.ApplyPalette(PaletteOptions.Purple);
        }

    }
}
