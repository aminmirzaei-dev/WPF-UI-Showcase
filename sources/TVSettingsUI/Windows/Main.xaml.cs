using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        About, Options, Storage, Time, Network , Common
    }


    public partial class Main : Window, INotifyPropertyChanged
    {
        /// <summary>
        /// init all pages just one time 
        /// </summary>
        private Pages.Options optionsPage = new Pages.Options();
        private Pages.About aboutPage = new Pages.About();
        private Pages.Storage storagePage = new Pages.Storage();
        private Pages.Time timePage = new Pages.Time();
        private Pages.Network networkPage = new Pages.Network();
        private Pages.Common commonPage = new Pages.Common();
        private bool IsMaximize = false;

        public Main()
        {
            InitializeComponent();
            this.CurrentPage = AppPages.Options;
        }

        private AppPages _currentPage;

        public AppPages CurrentPage
        {
            get => _currentPage;
            set
            {
                if (_currentPage == value)
                    return;

                _currentPage = value;
                OnPropertyChanged(nameof(CurrentPage));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(propertyName));
        }

        public void ExecutePage(AppPages page)
        {
            backButton.Visibility = Visibility.Visible;
            this.closeButton.Visibility = Visibility.Hidden;

            this.CurrentPage = page;

            switch (page)
            {
                case AppPages.About:
                    container.Content = aboutPage;
                    break;
                case AppPages.Options:
                    container.Content = optionsPage;
                    break;
                case AppPages.Storage:
                    container.Content = storagePage;                   
                    break;
                case AppPages.Time:
                    container.Content = timePage;
                    break;
                case AppPages.Network:
                    container.Content = networkPage;
                    break;

                case AppPages.Common:
                    container.Content = commonPage;
                    break;
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            container.Content = optionsPage;
            backButton.Visibility = Visibility.Collapsed;
            this.closeButton.Visibility = Visibility.Visible;

            this.CurrentPage = AppPages.Options;
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
