using MahApps.Metro.IconPacks;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace TVSettingsUI.Controls
{
    /// <summary>
    /// Interaction logic for TVOptionsElement.xaml
    /// </summary>
    public partial class TVOptionsElement : UserControl
    {
        public TVOptionsElement()
        {
            InitializeComponent();
        }


        // =========================================================
        // Title
        // =========================================================

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(
                nameof(Title),
                typeof(string),
                typeof(TVOptionsElement),
                new PropertyMetadata(string.Empty));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }


        // =========================================================
        // Icon
        // =========================================================

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(
                nameof(Icon),
                typeof(PackIconMaterialKind),
                typeof(TVOptionsElement),
                new PropertyMetadata(PackIconMaterialKind.Github));

        public PackIconMaterialKind Icon
        {
            get => (PackIconMaterialKind)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }


        // =========================================================
        // Options
        // =========================================================

        public ObservableCollection<TVRadioButton> Options { get; } =
            new ObservableCollection<TVRadioButton>();
    }
}
