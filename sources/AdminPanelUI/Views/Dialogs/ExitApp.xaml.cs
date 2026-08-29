using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace AdminPanelUI.Views.Dialogs
{
    public partial class ExitApp : Window
    {
        private bool _isClosing = false;

        public ExitApp()
        {
            InitializeComponent();

            Loaded += ExitApp_Loaded;
        }


        // Open Animation

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
                DialogResult = result;
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


        private void CloseButton_Click(
            object sender,
            RoutedEventArgs e)
        {
            CloseWithAnimation(false);
        }


        private void NoButton_Click(
            object sender,
            RoutedEventArgs e)
        {
            CloseWithAnimation(false);
        }


        private void YesButton_Click(object sender,RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        private void Window_MouseLeftButtonDown(
            object sender,
            MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed &&
                !_isClosing)
            {
                DragMove();
            }
        }
    }
}