using FontAwesome.Sharp;
using System.Windows;

namespace AdminPanelUI.Controls
{
    public class APMenuItem : System.Windows.Controls.RadioButton
    {
        #region Icon

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(
                nameof(Icon),
                typeof(IconChar),
                typeof(APMenuItem),
                new FrameworkPropertyMetadata(IconChar.None));

        public IconChar Icon
        {
            get => (IconChar)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        #endregion


    }
}
