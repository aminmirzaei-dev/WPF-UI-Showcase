using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace AdminPanelUI.Controls
{
    public class APComboBox : ComboBox
    {
        static APComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(APComboBox),
                new FrameworkPropertyMetadata(typeof(APComboBox)));
        }
    }
}
