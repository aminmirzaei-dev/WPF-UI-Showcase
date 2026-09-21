using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;

namespace CalendarDesktopUI.Services
{
    public enum ThemeOptions
    {
        Light, Dark
    }

    public class ThemeService : INotifyPropertyChanged
    {
        private ThemeOptions _currentTheme = ThemeOptions.Light;

        private ResourceDictionary? _currentThemeDictionary;

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

        public ThemeService()
        {
            _currentThemeDictionary =
                Application.Current.Resources.MergedDictionaries
                    .FirstOrDefault(d =>
                        d.Source?.OriginalString.Contains("/Themes/") == true);
        }

        public void ApplyTheme(ThemeOptions themeName)
        {
            if (CurrentTheme == themeName)
                return;

            var newTheme = new ResourceDictionary
            {
                Source = new Uri(
                    $"/CalendarDesktopUI;component/Resources/Themes/{themeName}.xaml",
                    UriKind.Relative)
            };

            var dictionaries =
                Application.Current.Resources.MergedDictionaries;

            if (_currentThemeDictionary != null)
            {
                dictionaries.Remove(_currentThemeDictionary);
            }

            dictionaries.Add(newTheme);

            _currentThemeDictionary = newTheme;

            CurrentTheme = themeName;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
