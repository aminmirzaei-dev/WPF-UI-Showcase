using System;
using System.Windows;

namespace TVSettingsUI.Services
{
    public class ThemeService
    {
        public void ApplyTheme(string themeName)
        {
            var theme = new ResourceDictionary
            {
                Source = new Uri($"/TVSettingsUI;component/Themes/{themeName}.xaml", UriKind.Relative)
            };

            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(theme);
        }
    }
}
