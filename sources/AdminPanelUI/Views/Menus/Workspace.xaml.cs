using AdminPanelUI.Views.Dialogs;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace AdminPanelUI.Views.Menus
{
    public enum AppPages
    {
        Dashboard, Messages, About
    }


    /// <summary>
    /// Interaction logic for Workspace.xaml
    /// </summary>
    public partial class Workspace : UserControl
    {

        private Views.Pages.Dashboard dashboardPage = new Views.Pages.Dashboard();
        private Views.Pages.Messages messagesPage = new Views.Pages.Messages();
        private Views.Pages.About aboutPage = new Views.Pages.About();

        


        public Workspace()
        {
            InitializeComponent();

            this.CurrentPage = AppPages.Dashboard;


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
                case AppPages.Dashboard:
                    this.ContentPage.Content = dashboardPage;
                    break;
                case AppPages.Messages:
                    this.ContentPage.Content = messagesPage;
                    break;
                case AppPages.About:
                    this.ContentPage.Content = aboutPage;
                    break;
            }
        }


        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            ExitApp exitDialog = new ExitApp();
            exitDialog.Owner = Window.GetWindow(this);

            exitDialog.ShowDialog();
        }

        private void DashboardMenuItem_Checked(object sender, RoutedEventArgs e)
        {
            this.ExecutePage(AppPages.Dashboard);
        }
        private void MessagesMenuItem_Checked(object sender, RoutedEventArgs e)
        {
            this.ExecutePage(AppPages.Messages);
        }

        private void AboutUsMenuItem_Checked(object sender, RoutedEventArgs e)
        {
            this.ExecutePage(AppPages.About);
        }
    }
}
