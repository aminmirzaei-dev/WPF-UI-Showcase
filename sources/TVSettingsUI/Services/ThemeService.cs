using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace TVSettingsUI.Services
{
    public enum ThemeOptions
    {
        Blue, Red, Green, Magenta, Orange, Pink
    }

    public class ThemeService : INotifyPropertyChanged
    {
        private ThemeOptions _currentTheme = ThemeOptions.Blue;

        public ThemeOptions CurrentTheme
        {
            get => _currentTheme;
            private set
            {
                if (_currentTheme == value)
                    return;

                _currentTheme = value;

                PropertyChanged?.Invoke(
                    this,
                    new PropertyChangedEventArgs(nameof(CurrentTheme)));
            }
        }

        public void ApplyTheme(ThemeOptions themeName)
        {
            var theme = new ResourceDictionary
            {
                Source = new Uri(
                    $"/TVSettingsUI;component/Themes/{themeName}.xaml",
                    UriKind.Relative)
            };

            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(theme);

            CurrentTheme = themeName;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
