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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SmartHomeUI.Controls
{
    /// <summary>
    /// Interaction logic for SettingsOptions.xaml
    /// </summary>
    public partial class SettingsOptions : UserControl
    {
        public SettingsOptions()
        {
            InitializeComponent();

            MouseLeftButtonUp += (_, _) =>
            {
                if (!IsSelected)
                    IsSelected = true;

                OptionClicked?.Invoke(this, new RoutedEventArgs());
            };

            Loaded += (_, _) => UpdateVisualState();
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(
                nameof(Title), typeof(string),
                typeof(SettingsOptions),
                new PropertyMetadata(string.Empty));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.Register(
                nameof(IsSelected), typeof(bool),
                typeof(SettingsOptions),
                new PropertyMetadata(false, OnSelectionChanged));

        public bool IsSelected
        {
            get => (bool)GetValue(IsSelectedProperty);
            set => SetValue(IsSelectedProperty, value);
        }

        public static readonly DependencyProperty IconContentProperty =
            DependencyProperty.Register(
                nameof(IconContent), typeof(object),
                typeof(SettingsOptions),
                new PropertyMetadata(null));

        public object IconContent
        {
            get => GetValue(IconContentProperty);
            set => SetValue(IconContentProperty, value);
        }

        public event RoutedEventHandler OptionClicked;

        private static void OnSelectionChanged(
            DependencyObject d,
            DependencyPropertyChangedEventArgs e)
        {
            ((SettingsOptions)d).UpdateVisualState();
        }

        private void UpdateVisualState()
        {
            if (RootBorder == null)
                return;

            var duration = TimeSpan.FromMilliseconds(220);

            var background = IsSelected
                ? Color.FromRgb(237, 243, 255)
                : Colors.White;

            var border = IsSelected
                ? Color.FromRgb(40, 100, 255)
                : Color.FromRgb(229, 236, 246);

            AnimateColor(RootBorder, Border.BackgroundProperty,
                background, duration);

            AnimateColor(RootBorder, Border.BorderBrushProperty,
                border, duration);

            SelectedIndicator.BeginAnimation(
                UIElement.OpacityProperty,
                new DoubleAnimation
                {
                    To = IsSelected ? 1 : 0,
                    Duration = duration,
                    EasingFunction = new CubicEase
                    {
                        EasingMode = EasingMode.EaseOut
                    }
                });

            CheckScale.BeginAnimation(
                ScaleTransform.ScaleXProperty,
                new DoubleAnimation
                {
                    To = IsSelected ? 1 : 0.5,
                    Duration = duration,
                    EasingFunction = new BackEase
                    {
                        EasingMode = EasingMode.EaseOut,
                        Amplitude = 0.25
                    }
                });

            CheckScale.BeginAnimation(
                ScaleTransform.ScaleYProperty,
                new DoubleAnimation
                {
                    To = IsSelected ? 1 : 0.5,
                    Duration = duration,
                    EasingFunction = new BackEase
                    {
                        EasingMode = EasingMode.EaseOut,
                        Amplitude = 0.25
                    }
                });
        }

        private static void AnimateColor(
            Border target,
            DependencyProperty property,
            Color color,
            TimeSpan duration)
        {
            var currentBrush = target.GetValue(property) as SolidColorBrush;

            var startColor = currentBrush?.Color ?? color;

            var brush = new SolidColorBrush(startColor);

            target.SetValue(property, brush);

            brush.BeginAnimation(
                SolidColorBrush.ColorProperty,
                new ColorAnimation
                {
                    To = color,
                    Duration = duration,
                    EasingFunction = new CubicEase
                    {
                        EasingMode = EasingMode.EaseOut
                    }
                });
        }
    }
}
