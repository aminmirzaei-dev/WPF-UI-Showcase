using FontAwesome.Sharp;
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

namespace AdminPanelUI.Controls.Composite
{
    /// <summary>
    /// Interaction logic for TechnologyBadge.xaml
    /// </summary>
    public partial class TechnologyBadge : UserControl
    {
        public TechnologyBadge()
        {
            InitializeComponent();
        }


        public string TechnologyName
        {
            get => (string)GetValue(TechnologyNameProperty);
            set => SetValue(TechnologyNameProperty, value);
        }

        public static readonly DependencyProperty TechnologyNameProperty =
            DependencyProperty.Register(
                nameof(TechnologyName),
                typeof(string),
                typeof(TechnologyBadge),
                new PropertyMetadata(string.Empty));


        public IconChar Icon
        {
            get => (IconChar)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(
                nameof(Icon),
                typeof(IconChar),
                typeof(TechnologyBadge),
                new PropertyMetadata(IconChar.Star));


        public Brush IconColor
        {
            get => (Brush)GetValue(IconColorProperty);
            set => SetValue(IconColorProperty, value);
        }

        public static readonly DependencyProperty IconColorProperty =
            DependencyProperty.Register(
                nameof(IconColor),
                typeof(Brush),
                typeof(TechnologyBadge),
                new PropertyMetadata(Brushes.White));
    }
}
