using SmartHomeUI.Views.Dialogs;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SmartHomeUI.Views.Layouts
{

    public enum AppPages
    {
        Home,Room,Settings
    }


    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        private Views.Pages.Home homePage = new Views.Pages.Home();
        private Views.Pages.Room roomPage = new Views.Pages.Room();




        public Menu()
        {
            InitializeComponent();

            this.CurrentPage = AppPages.Home;
            }

        public ContentPresenter ContentPage { get; set; } = new ContentPresenter();

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

            this.CurrentPage = page;

            switch (page)
            {
                case AppPages.Home:
                    this.ContentPage.Content = homePage;
                    break;
                case AppPages.Room:
                    this.ContentPage.Content = roomPage;
                    break;
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void HomeItem_Checked(object sender, RoutedEventArgs e)
        {
            this.ExecutePage(AppPages.Home);
        }

        private void RoomItem_Checked(object sender, RoutedEventArgs e)
        {
            this.ExecutePage(AppPages.Room);
        }
    }
}
