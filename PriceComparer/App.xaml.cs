using System.Windows;
using PriceComparer.View;
using PriceComparer.ViewModel;

namespace PriceComparer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ShowMainWindow();
        }

        internal static Window ShowMainWindow()
        {
            var mainWindow = new MainWindow(new MainWindowViewModel());
            mainWindow.Show();

            return mainWindow;
        }
    }
}