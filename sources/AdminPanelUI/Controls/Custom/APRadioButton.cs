using FontAwesome.Sharp;
using System.Windows;

namespace AdminPanelUI.Controls
{
    internal class APRadioButton : System.Windows.Controls.RadioButton
    {
        static APRadioButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(APRadioButton),
                new FrameworkPropertyMetadata(typeof(APRadioButton)));
        }

        #region Icon

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(
                nameof(Icon),
                typeof(IconChar),
                typeof(APRadioButton),
                new PropertyMetadata(IconChar.None));

        public IconChar Icon
        {
            get => (IconChar)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        #endregion

       
    }
}
