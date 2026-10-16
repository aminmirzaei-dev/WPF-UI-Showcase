using MahApps.Metro.IconPacks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace SmartHomeUI.Controls
{
    internal class SHMenuItem : System.Windows.Controls.RadioButton
    {
        public static readonly DependencyProperty IconProperty =
     DependencyProperty.Register(
         nameof(Icon),
         typeof(PackIconMaterialKind),
         typeof(SHMenuItem),
         new FrameworkPropertyMetadata(PackIconMaterialKind.None));

        public PackIconMaterialKind Icon
        {
            get => (PackIconMaterialKind)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }
    }

}
