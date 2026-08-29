using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace AdminPanelUI.Controls
{
    public class APButton : System.Windows.Controls.Button
    {

        private static readonly DependencyPropertyKey HoverBackgroundPropertyKey =
    DependencyProperty.RegisterReadOnly(
        nameof(HoverBackground),
        typeof(Brush),
        typeof(APButton),
        new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty HoverBackgroundProperty =
            HoverBackgroundPropertyKey.DependencyProperty;


        public Brush HoverBackground
        {
            get => (Brush)GetValue(HoverBackgroundProperty);
            private set => SetValue(HoverBackgroundPropertyKey, value);
        }

        private static readonly DependencyPropertyKey PressedBackgroundPropertyKey =
    DependencyProperty.RegisterReadOnly(
        nameof(PressedBackground),
        typeof(Brush),
        typeof(APButton),
        new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty PressedBackgroundProperty =
            PressedBackgroundPropertyKey.DependencyProperty;


        public Brush PressedBackground
        {
            get => (Brush)GetValue(PressedBackgroundProperty);
            private set => SetValue(PressedBackgroundPropertyKey, value);
        }


        #region Icon

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(
                nameof(Icon),
                typeof(IconChar),
                typeof(APButton),
                new FrameworkPropertyMetadata(IconChar.None));

        public IconChar Icon
        {
            get => (IconChar)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        #endregion

        #region IconTextSpacing

        public static readonly DependencyProperty IconTextSpacingProperty =
            DependencyProperty.Register(
                nameof(IconTextSpacing),
                typeof(double),
                typeof(APButton),
                new FrameworkPropertyMetadata(10.0));

        public double IconTextSpacing
        {
            get => (double)GetValue(IconTextSpacingProperty);
            set => SetValue(IconTextSpacingProperty, value);
        }

        #endregion

        private static void OnBackgroundChanged(
    DependencyObject d,
    DependencyPropertyChangedEventArgs e)
        {
            if (d is not APButton button)
                return;

            button.UpdateButtonColors();
        }

        private void UpdateButtonColors()
        {
            if (Background is not SolidColorBrush brush)
                return;

            Color baseColor = brush.Color;

            Color hoverColor = LightenColor(baseColor, 0.12);

            Color pressedColor = DarkenColor(baseColor, 0.15);

            HoverBackground =
                new SolidColorBrush(hoverColor);

            PressedBackground =
                new SolidColorBrush(pressedColor);
        }

        static APButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
         typeof(APButton),
         new FrameworkPropertyMetadata(typeof(APButton)));

            BackgroundProperty.OverrideMetadata(
                typeof(APButton),
                new FrameworkPropertyMetadata(
                    null,
                    FrameworkPropertyMetadataOptions.AffectsRender,
                    OnBackgroundChanged));
        }

        public APButton()
        {
            Loaded += APButton_Loaded;
        }

        private void APButton_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateButtonColors();
        }

        #region Color Helpers

        public static Color LightenColor(Color color, double amount)
        {
            amount = Math.Max(0, Math.Min(1, amount));

            byte r = (byte)(color.R + (255 - color.R) * amount);
            byte g = (byte)(color.G + (255 - color.G) * amount);
            byte b = (byte)(color.B + (255 - color.B) * amount);

            return Color.FromArgb(color.A, r, g, b);
        }

        public static Color DarkenColor(Color color, double amount)
        {
            amount = Math.Max(0, Math.Min(1, amount));

            byte r = (byte)(color.R * (1 - amount));
            byte g = (byte)(color.G * (1 - amount));
            byte b = (byte)(color.B * (1 - amount));

            return Color.FromArgb(color.A, r, g, b);
        }


        #endregion
    }
}
