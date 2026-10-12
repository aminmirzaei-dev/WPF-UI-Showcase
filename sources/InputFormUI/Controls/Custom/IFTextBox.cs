using MahApps.Metro.IconPacks;
using System.Windows;

namespace InputFormUI.Controls
{
    internal class IFTextBox :System.Windows.Controls.TextBox
    {
        static IFTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(IFTextBox),
                new FrameworkPropertyMetadata(typeof(IFTextBox)));
        }

        #region Icon

        public static readonly DependencyProperty IconProperty =
     DependencyProperty.Register(
         nameof(Icon),
         typeof(PackIconMaterialKind),
         typeof(IFTextBox),
         new FrameworkPropertyMetadata(PackIconMaterialKind.None));

        public PackIconMaterialKind Icon
        {
            get => (PackIconMaterialKind)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }
        #endregion

        #region Placeholder

        public static readonly DependencyProperty PlaceholderProperty =
            DependencyProperty.Register(
                nameof(Placeholder),
                typeof(string),
                typeof(IFTextBox),
                new PropertyMetadata(string.Empty));

        public string Placeholder
        {
            get => (string)GetValue(PlaceholderProperty);
            set => SetValue(PlaceholderProperty, value);
        }

        #endregion
    }
}
