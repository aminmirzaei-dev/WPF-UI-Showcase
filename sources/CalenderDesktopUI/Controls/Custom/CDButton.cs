using System.Windows;
using System.Windows.Media;
using FontAwesome.WPF;


namespace CalendarDesktopUI.Controls
{
    internal class CDButton : System.Windows.Controls.Button
    {
        private static readonly DependencyPropertyKey HoverBackgroundPropertyKey =
    DependencyProperty.RegisterReadOnly(
        nameof(HoverBackground),
        typeof(Brush),
        typeof(CDButton),
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
        typeof(CDButton),
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
                typeof(FontAwesomeIcon),
                typeof(CDButton),
                new FrameworkPropertyMetadata(FontAwesomeIcon.None));

        public FontAwesomeIcon Icon
        {
            get => (FontAwesomeIcon)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }


        #endregion



        private static void OnBackgroundChanged(
    DependencyObject d,
    DependencyPropertyChangedEventArgs e)
        {
            if (d is not CDButton button)
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

        static CDButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
         typeof(CDButton),
         new FrameworkPropertyMetadata(typeof(CDButton)));

            BackgroundProperty.OverrideMetadata(
                typeof(CDButton),
                new FrameworkPropertyMetadata(
                    null,
                    FrameworkPropertyMetadataOptions.AffectsRender,
                    OnBackgroundChanged));
        }

        public CDButton()
        {
            Loaded += CDButton_Loaded;
        }

        private void CDButton_Loaded(object sender, RoutedEventArgs e)
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
