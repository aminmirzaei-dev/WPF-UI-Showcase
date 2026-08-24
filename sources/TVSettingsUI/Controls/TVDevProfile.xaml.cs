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
using TVSettingsUI.Services;

namespace TVSettingsUI.Controls
{
    /// <summary>
    /// Interaction logic for TVDevProfile.xaml
    /// </summary>
    public partial class TVDevProfile : UserControl
    {
        public static readonly DependencyProperty ThemeProperty = DependencyProperty.Register("Theme", typeof(TVSettingsUI.Services.ThemeOptions), typeof(TVDevProfile));
        public ThemeOptions Theme
        {
            get => (ThemeOptions)GetValue(ThemeProperty);
            set => SetValue(ThemeProperty, value);
        }

        public TVDevProfile()
        {
            InitializeComponent();
        }
    }
}
