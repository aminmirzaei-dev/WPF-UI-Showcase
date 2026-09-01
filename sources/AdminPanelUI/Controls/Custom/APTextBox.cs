using FontAwesome.Sharp;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;


namespace AdminPanelUI.Controls
{

    public class APTextBox : System.Windows.Controls.TextBox
    {
        static APTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(APTextBox),
                new FrameworkPropertyMetadata(typeof(APTextBox)));
        }

        #region Icon

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(
                nameof(Icon),
                typeof(IconChar),
                typeof(APTextBox),
                new FrameworkPropertyMetadata(IconChar.None));

        public IconChar Icon
        {
            get => (IconChar)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        #endregion

        #region Placeholder

        public static readonly DependencyProperty PlaceholderProperty =
            DependencyProperty.Register(
                nameof(Placeholder),
                typeof(string),
                typeof(APTextBox),
                new PropertyMetadata(string.Empty));

        public string Placeholder
        {
            get => (string)GetValue(PlaceholderProperty);
            set => SetValue(PlaceholderProperty, value);
        }

        #endregion

        #region IconBrush

        public static readonly DependencyProperty IconBrushProperty =
            DependencyProperty.Register(
                nameof(IconBrush),
                typeof(Brush),
                typeof(APTextBox),
                new PropertyMetadata(
                    new SolidColorBrush(Color.FromRgb(110, 127, 180))));

        public Brush IconBrush
        {
            get => (Brush)GetValue(IconBrushProperty);
            set => SetValue(IconBrushProperty, value);
        }

        #endregion

        #region PlaceholderBrush

        public static readonly DependencyProperty PlaceholderBrushProperty =
            DependencyProperty.Register(
                nameof(PlaceholderBrush),
                typeof(Brush),
                typeof(APTextBox),
                new PropertyMetadata(
                    new SolidColorBrush(Color.FromRgb(125, 140, 185))));

        public Brush PlaceholderBrush
        {
            get => (Brush)GetValue(PlaceholderBrushProperty);
            set => SetValue(PlaceholderBrushProperty, value);
        }

        #endregion

        #region BoxBackground

        public static readonly DependencyProperty BoxBackgroundProperty =
            DependencyProperty.Register(
                nameof(BoxBackground),
                typeof(Brush),
                typeof(APTextBox),
                new PropertyMetadata(
                    new SolidColorBrush(Color.FromRgb(38, 57, 108))));

        public Brush BoxBackground
        {
            get => (Brush)GetValue(BoxBackgroundProperty);
            set => SetValue(BoxBackgroundProperty, value);
        }

        #endregion

        #region BoxBorderBrush

        public static readonly DependencyProperty BoxBorderBrushProperty =
            DependencyProperty.Register(
                nameof(BoxBorderBrush),
                typeof(Brush),
                typeof(APTextBox),
                new PropertyMetadata(Brushes.Transparent));

        public Brush BoxBorderBrush
        {
            get => (Brush)GetValue(BoxBorderBrushProperty);
            set => SetValue(BoxBorderBrushProperty, value);
        }

        #endregion

        #region CornerRadius

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(
                nameof(CornerRadius),
                typeof(CornerRadius),
                typeof(APTextBox),
                new PropertyMetadata(new CornerRadius(8)));

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        #endregion
    }
}
