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

namespace TVSettingsUI.Pages
{
    /// <summary>
    /// Interaction logic for Common.xaml
    /// </summary>
    public partial class Common : UserControl
    {
        public Common()
        {
            InitializeComponent();
        }

        private ThemeService Theme => (ThemeService)Application.Current.Resources["ThemeService"];
        private LocalizationService Language => (LocalizationService)Application.Current.Resources["LocalizationService"];

        #region Themes Checked Event Handlers
        private void BlueTheme_Checked(object sender, RoutedEventArgs e) => this.Theme.ApplyTheme(ThemeOptions.Blue);
        private void GreenTheme_Checked(object sender, RoutedEventArgs e) => this.Theme.ApplyTheme(ThemeOptions.Green);
        private void MagentaTheme_Checked(object sender, RoutedEventArgs e) => this.Theme.ApplyTheme(ThemeOptions.Magenta);
        private void RedTheme_Checked(object sender, RoutedEventArgs e) => this.Theme.ApplyTheme(ThemeOptions.Red);
        private void OrangeTheme_Checked(object sender, RoutedEventArgs e) => this.Theme.ApplyTheme(ThemeOptions.Orange);
        private void PinkTheme_Checked(object sender, RoutedEventArgs e) => this.Theme.ApplyTheme(ThemeOptions.Pink);
        #endregion

        #region Languages Checked Event Handlers
        private void EnglishLanguage_Checked(object sender, RoutedEventArgs e) => this.Language.ChangeLanguage(Services.LanguageOptions.English);
        private void GermanLanguage_Checked(object sender, RoutedEventArgs e) => this.Language.ChangeLanguage(Services.LanguageOptions.German);
        private void SpanishLanguage_Checked(object sender, RoutedEventArgs e) => this.Language.ChangeLanguage(Services.LanguageOptions.Spanish);
        private void ChineseLanguage_Checked(object sender, RoutedEventArgs e) => this.Language.ChangeLanguage(Services.LanguageOptions.Chinese);
        private void PersianLanguage_Checked(object sender, RoutedEventArgs e) => this.Language.ChangeLanguage(Services.LanguageOptions.Persian);
        #endregion



    }
}
