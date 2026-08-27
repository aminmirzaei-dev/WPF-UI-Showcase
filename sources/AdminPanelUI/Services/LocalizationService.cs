using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
namespace AdminPanelUI.Services
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


    internal class LocalizationService
    {

    }
}
