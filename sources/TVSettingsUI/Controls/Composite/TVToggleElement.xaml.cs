using MahApps.Metro.IconPacks;
using System.Windows;
using System.Windows.Controls;

namespace TVSettingsUI.Controls
{
    /// <summary>
    /// Interaction logic for TVToggleElement.xaml
    /// </summary>
    public partial class TVToggleElement : UserControl
    {
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(TVToggleElement));
        public static readonly DependencyProperty HasToggleProperty = DependencyProperty.Register("HasToggle", typeof(bool), typeof(TVToggleElement));
        public static readonly DependencyProperty IsCheckedProperty = DependencyProperty.Register("IsChecked", typeof(bool), typeof(TVToggleElement));
        public static readonly DependencyProperty HasTextProperty = DependencyProperty.Register("HasText", typeof(bool), typeof(TVToggleElement));
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(TVToggleElement));
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(PackIconMaterialKind), typeof(TVToggleElement));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public bool HasToggle
        {
            get { return (bool)GetValue(HasToggleProperty); }
            set { SetValue(HasToggleProperty, value); }
        }

        public PackIconMaterialKind Icon
        {
            get { return (PackIconMaterialKind)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }

        public bool HasText
        {
            get { return (bool)GetValue(HasTextProperty); }
            set { SetValue(HasTextProperty, value); }
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }


        public TVToggleElement()
        {
            InitializeComponent();
        }
    }
}
