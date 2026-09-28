using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CalendarDesktopUI.Controls
{
    /// <summary>
    /// Interaction logic for CDWindow.xaml
    /// </summary>
    public partial class CDWindow : Window
    {
        public CDWindow()
        {
            InitializeComponent();
            this.Loaded += CDWindow_Loaded;
            this.Closed += (s, e) =>
            {
                if (!_isClosing)
                {
                    CloseWithAnimation(false);
                }
            };
        }

        private bool _isClosing = false;

        private void CDWindow_Loaded(object sender, RoutedEventArgs e)
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


    }
}
