using DeviceHistoryRecord.UI.ViewModel;
using System;
using System.Windows;
using System.Windows.Input;

namespace DeviceHistoryRecord.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string barCode;
        private MainViewModel _viewModel;

        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = _viewModel;
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _viewModel.Load();
        }

        private void Window_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
               // txtScanCode.Text = barCode;

                barCode = "";
            }

        }

        private void Window_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            barCode += e.Text;
        }
    }
}
