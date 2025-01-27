using System.Windows;
using ReactiveUiTest.Views;

namespace ReactiveUiTest;

public partial class App
{
    // ReSharper disable once AsyncVoidMethod
    protected override void OnStartup(StartupEventArgs e)
    {
        var mainWindow = new MainWindow(new MainWindowViewModel()); 
        mainWindow.Show();
    }
}