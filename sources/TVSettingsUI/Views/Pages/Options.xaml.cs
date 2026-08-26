using System.Windows;
using System.Windows.Controls;
using TVSettingsUI.Views.Windows;

namespace TVSettingsUI.Views.Pages
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : UserControl
    {


        public Options()
        {
            InitializeComponent();
        }

        private TVSettingsUI.Views.Windows.Main window;

        private void LoadWindow()
        {
            if (window == null)
            {
                window = Window.GetWindow(App.Current.MainWindow) as Main;
            }
        }
        private void NetworkSetting_ElementClick(object sender, RoutedEventArgs e)
        {
            LoadWindow();
            window.ExecutePage(AppPages.Network);
        }

        private void Time_ElementClick(object sender, RoutedEventArgs e)
        {
            LoadWindow();
            window.ExecutePage(AppPages.Time);
        }

        private void Storage_ElementClick(object sender, RoutedEventArgs e)
        {
            LoadWindow();
            window.ExecutePage(AppPages.Storage);
        }

        private void About_ElementClick(object sender, RoutedEventArgs e)
        {
            LoadWindow();
            window.ExecutePage(AppPages.About);
        }

        private void Common_ElementClick(object sender, RoutedEventArgs e)
        {
            LoadWindow();
            window.ExecutePage(AppPages.Common);
        }
    }
}
