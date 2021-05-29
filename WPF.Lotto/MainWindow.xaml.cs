namespace WPF.Lotto
{
    public partial class MainWindow
    {
        public MainWindow(MainWindowViewModel _mainWindowViewModel)
        {
            InitializeComponent();
            DataContext = _mainWindowViewModel;
        }
    }
}