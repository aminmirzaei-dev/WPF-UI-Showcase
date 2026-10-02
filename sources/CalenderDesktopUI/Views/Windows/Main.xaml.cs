using CalendarDesktopUI.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CalendarDesktopUI.Views.Windows
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

    

        private void CloseButton_Click(
    object sender,
    RoutedEventArgs e)
        {
            DialogOverlay.Visibility = Visibility.Visible;

            try
            {
                CalendarDesktopUI.Views.Dialogs.Exit exitDialog =
                    new CalendarDesktopUI.Views.Dialogs.Exit();

                exitDialog.Owner = Window.GetWindow(this);

                exitDialog.ShowDialog();
            }
            finally
            {
                DialogOverlay.Visibility = Visibility.Collapsed;
            }

        }


        private void AppearanceButton_Click(
    object sender,
    RoutedEventArgs e)
        {
            DialogOverlay.Visibility = Visibility.Visible;

            try
            {
                CalendarDesktopUI.Views.Dialogs.Appearance appearanceDialog =
                    new CalendarDesktopUI.Views.Dialogs.Appearance();

                appearanceDialog.Owner = Window.GetWindow(this);

                appearanceDialog.ShowDialog();
            }
            finally
            {
                DialogOverlay.Visibility = Visibility.Collapsed;
            }
        }

        private void AboutButton_Click(
    object sender,
    RoutedEventArgs e)
        {
            DialogOverlay.Visibility = Visibility.Visible;

            try
            {
                CalendarDesktopUI.Views.Dialogs.About aboutDialog =
                    new CalendarDesktopUI.Views.Dialogs.About();

                aboutDialog.Owner = Window.GetWindow(this);

                aboutDialog.ShowDialog();
            }
            finally
            {
                DialogOverlay.Visibility = Visibility.Collapsed;
            }
        }



    }
}
