using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace TVSettingsUI.Controls
{
    public class TVRadioButton : System.Windows.Controls.RadioButton
    {
        static TVRadioButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(TVRadioButton),
                new FrameworkPropertyMetadata(typeof(TVRadioButton)));
        }

        public Brush HoverBrush
        {
            get => (Brush)GetValue(HoverBrushProperty);
            set => SetValue(HoverBrushProperty, value);
        }

        public static readonly DependencyProperty HoverBrushProperty =
            DependencyProperty.Register(
                nameof(HoverBrush),
                typeof(Brush),
                typeof(TVRadioButton),
                new PropertyMetadata(
                    new SolidColorBrush(Color.FromArgb(60, 255, 255, 255))));

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register(
                nameof(ImageSource),
                typeof(ImageSource),
                typeof(TVRadioButton),
                new FrameworkPropertyMetadata(null));

        public ImageSource ImageSource
        {
            get => (ImageSource)GetValue(ImageSourceProperty);
            set => SetValue(ImageSourceProperty, value);
        }

        public static readonly DependencyProperty CircleBackgroundProperty =
            DependencyProperty.Register(
                nameof(CircleBackground),
                typeof(Brush),
                typeof(TVRadioButton),
                new FrameworkPropertyMetadata(Brushes.Transparent));

        public Brush CircleBackground
        {
            get => (Brush)GetValue(CircleBackgroundProperty);
            set => SetValue(CircleBackgroundProperty, value);
        }

        public static readonly DependencyProperty SelectionMaskProperty =
            DependencyProperty.Register(
                nameof(SelectionMask),
                typeof(Brush),
                typeof(TVRadioButton),
                new FrameworkPropertyMetadata(
                    new SolidColorBrush(
                        Color.FromArgb(100, 0, 0, 0))));

        public Brush SelectionMask
        {
            get => (Brush)GetValue(SelectionMaskProperty);
            set => SetValue(SelectionMaskProperty, value);
        }

        public static readonly DependencyProperty SelectionBorderBrushProperty =
            DependencyProperty.Register(
                nameof(SelectionBorderBrush),
                typeof(Brush),
                typeof(TVRadioButton),
                new FrameworkPropertyMetadata(Brushes.White));

        public Brush SelectionBorderBrush
        {
            get => (Brush)GetValue(SelectionBorderBrushProperty);
            set => SetValue(SelectionBorderBrushProperty, value);
        }

        public static readonly DependencyProperty CheckBrushProperty =
            DependencyProperty.Register(
                nameof(CheckBrush),
                typeof(Brush),
                typeof(TVRadioButton),
                new FrameworkPropertyMetadata(Brushes.White));

        public Brush CheckBrush
        {
            get => (Brush)GetValue(CheckBrushProperty);
            set => SetValue(CheckBrushProperty, value);
        }
    }
}
