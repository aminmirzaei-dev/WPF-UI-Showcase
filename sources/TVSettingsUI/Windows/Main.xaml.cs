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
using TVSettingsUI.Services;

namespace TVSettingsUI.Windows
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    /// 
    public enum AppPages
    {
        About, Options, Storage, Time, Network
    }


    public partial class Main : Window
    {
        /// <summary>
        /// init all pages just one time 
        /// </summary>
        private Pages.Options optionsPage = new Pages.Options();
        private Pages.About aboutPage = new Pages.About();
        private Pages.Storage storagePage = new Pages.Storage();
        private Pages.Time timePage = new Pages.Time();
        private Pages.Network networkPage = new Pages.Network();
        private bool IsMaximize = false;

        public Main()
        {
            InitializeComponent();
        }

        public void ExecutePage(AppPages page)
        {
            backButton.Visibility = Visibility.Visible;
            this.closeButton.Visibility = Visibility.Hidden;

            switch (page)
            {
                case AppPages.About:
                    container.Content = aboutPage;
                    titleText.Text = "About Us";
                    break;
                case AppPages.Options:
                    container.Content = optionsPage;
                    titleText.Text = "Options";
                    break;
                case AppPages.Storage:
                    container.Content = storagePage;
                    titleText.Text = "Storage";
                   
                    break;
                case AppPages.Time:
                    container.Content = timePage;
                    titleText.Text = "Time Settings";
                    break;
                case AppPages.Network:
                    container.Content = networkPage;
                    titleText.Text = "Network Settings";
                    break;
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            container.Content = optionsPage;
            backButton.Visibility = Visibility.Collapsed;
            this.closeButton.Visibility = Visibility.Visible;

            titleText.Text = "Options";
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximize)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1280;
                    this.Height = 780;

                    IsMaximize = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;

                    IsMaximize = true;
                }
            }
        }

    }
}
