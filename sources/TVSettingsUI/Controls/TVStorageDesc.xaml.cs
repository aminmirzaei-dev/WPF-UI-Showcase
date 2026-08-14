using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TVSettingsUI.Controls
{
    /// <summary>
    /// Interaction logic for TVStorageDesc.xaml
    /// </summary>
    public partial class TVStorageDesc : UserControl
    {
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(TVStorageDesc));
        public static readonly DependencyProperty ColorProperty = DependencyProperty.Register("Color", typeof(Brush), typeof(TVStorageDesc));


        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public Brush Color
        {
            get { return (Brush)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }


        public TVStorageDesc()
        {
            InitializeComponent();
        }
    }
}
