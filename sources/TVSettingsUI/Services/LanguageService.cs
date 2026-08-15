using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;

namespace TVSettingsUI.Services
{
    public class LanguageService : INotifyPropertyChanged
    {
        private readonly ResourceManager _resourceManager;

        public LanguageService()
        {
            _resourceManager = Languages.Strings.ResourceManager;
        }

        public string this[string key]
        {
            get
            {
                return _resourceManager.GetString(
                    key,
                    CultureInfo.CurrentUICulture) ?? key;
            }
        }

        public void ChangeLanguage(string cultureName)
        {
            var culture = new CultureInfo(cultureName);

            CultureInfo.CurrentCulture = culture;
            CultureInfo.CurrentUICulture = culture;

            OnPropertyChanged(string.Empty);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(
            [CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
