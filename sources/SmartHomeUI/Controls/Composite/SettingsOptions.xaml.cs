using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
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

            RootBorder.BorderBrush = IsSelected
                ? new SolidColorBrush(Color.FromRgb(40, 100, 255))
                : new SolidColorBrush(Color.FromRgb(229, 236, 246));

            RootBorder.Background = IsSelected
                ? new SolidColorBrush(Color.FromRgb(237, 243, 255))
                : Brushes.White;

            SelectedIndicator.Visibility = IsSelected
                ? Visibility.Visible
                : Visibility.Collapsed;
        }
    }
}
