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

namespace AdminPanelUI.Controls
{
    /// <summary>
    /// Interaction logic for FeatureCard.xaml
    /// </summary>
    public partial class FeatureCard : UserControl
    {
        public FeatureCard()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(
                nameof(Title),
                typeof(string),
                typeof(FeatureCard),
                new PropertyMetadata(string.Empty));


        public string Description
        {
            get => (string)GetValue(DescriptionProperty);
            set => SetValue(DescriptionProperty, value);
        }

        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register(
                nameof(Description),
                typeof(string),
                typeof(FeatureCard),
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
                typeof(FeatureCard),
                new PropertyMetadata(IconChar.Star));
    }
}
