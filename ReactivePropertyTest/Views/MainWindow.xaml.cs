namespace ReactivePropertyTest.Views
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        public MainWindow(MainWindowViewModel viewModel) : this()
        {
            this.DataContext = viewModel;
        }
    }
}