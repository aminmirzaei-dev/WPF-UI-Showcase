using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;

namespace SmartHomeUI.Services
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());

            if (field == null)
                return value.ToString();

            return field.GetCustomAttribute<DescriptionAttribute>()?.Description
                   ?? value.ToString();
        }
    }

    public enum LanguageOptions
    {
        [Description("en-US")]
        English,
        [Description("fa-IR")]
        Persian,
        [Description("de-DE")]
        German,
        [Description("es-ES")]
        Spanish,
        [Description("zh-CN")]
        Chinese
    }

    public class LanguageService : INotifyPropertyChanged
    {
        private readonly ResourceManager _resourceManager;



        public LanguageService()
        {
            _resourceManager = SmartHomeUI.Resources.Languages.Localization.ResourceManager;
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

        public void ChangeLanguage(SmartHomeUI.Services.LanguageOptions languageName)
        {
            var culture = new CultureInfo(languageName.GetDescription());

            CultureInfo.CurrentCulture = culture;
            CultureInfo.CurrentUICulture = culture;

            OnPropertyChanged(string.Empty);
        }

        public FlowDirection FlowDirection =>
    CultureInfo.CurrentUICulture.TextInfo.IsRightToLeft
        ? FlowDirection.RightToLeft
        : FlowDirection.LeftToRight;

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
