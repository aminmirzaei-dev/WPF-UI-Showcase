using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;

namespace CalenderDesktopUI.Services
{
    public enum PaletteOptions
    {
        Red, Blue, Green, Yellow, Purple, Orange, Pink
    }


    public class PaletteService : INotifyPropertyChanged
    {
        private PaletteOptions _currentPalette = PaletteOptions.Red;

        private ResourceDictionary? _currentPaletteDictionary;

        public PaletteOptions CurrentPalette
        {
            get => _currentPalette;

            private set
            {
                if (_currentPalette == value)
                    return;

                _currentPalette = value;

                PropertyChanged?.Invoke(
                    this,
                    new PropertyChangedEventArgs(nameof(CurrentPalette)));
            }
        }

        public PaletteService()
        {
            _currentPaletteDictionary =
                Application.Current.Resources.MergedDictionaries
                    .FirstOrDefault(d =>
                        d.Source?.OriginalString.Contains("/Palettes/") == true);
        }

        public void ApplyPalette(PaletteOptions paletteName)
        {
            if (CurrentPalette == paletteName)
                return;

            var newPalette = new ResourceDictionary
            {
                Source = new Uri(
                    $"/CalendarDesktopUI;component/Resources/Palettes/{paletteName}.xaml",
                    UriKind.Relative)
            };

            var dictionaries =
                Application.Current.Resources.MergedDictionaries;

            if (_currentPaletteDictionary != null)
            {
                dictionaries.Remove(_currentPaletteDictionary);
            }

            dictionaries.Add(newPalette);

            _currentPaletteDictionary = newPalette;

            CurrentPalette = paletteName;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
