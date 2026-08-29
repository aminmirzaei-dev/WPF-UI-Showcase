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
    /// Interaction logic for ContactInfoRow.xaml
    /// </summary>
    public partial class ContactInfoRow : UserControl
    {
        public ContactInfoRow()
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
                typeof(ContactInfoRow),
                new PropertyMetadata(string.Empty));


        public string Value
        {
            get => (string)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register(
                nameof(Value),
                typeof(string),
                typeof(ContactInfoRow),
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
                typeof(ContactInfoRow),
                new PropertyMetadata(IconChar.InfoCircle));


        public IconChar ActionIcon
        {
            get => (IconChar)GetValue(ActionIconProperty);
            set => SetValue(ActionIconProperty, value);
        }

        public static readonly DependencyProperty ActionIconProperty =
            DependencyProperty.Register(
                nameof(ActionIcon),
                typeof(IconChar),
                typeof(ContactInfoRow),
                new PropertyMetadata(IconChar.ExternalLinkAlt));
    }
}
