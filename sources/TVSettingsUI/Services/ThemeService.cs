using System;
using System.Windows;

namespace TVSettingsUI.Services
{
    public enum ThemeOptions
    {
        Blue, Red, Green, Magenta, Orange, Pink
    }

    public class ThemeService
    {
        
        public static void ApplyTheme(TVSettingsUI.Services.ThemeOptions themeName)
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
