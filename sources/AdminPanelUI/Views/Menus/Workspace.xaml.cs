using AdminPanelUI.Views.Dialogs;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdminPanelUI.Views.Menus
{
    /// <summary>
    /// Interaction logic for Workspace.xaml
    /// </summary>
    public partial class Workspace : UserControl
    {

        public Workspace()
        {
            InitializeComponent();
            

        }


        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            ExitApp exitDialog = new ExitApp();
            exitDialog.Owner = Window.GetWindow(this);

            exitDialog.ShowDialog();
        }
    }
}
