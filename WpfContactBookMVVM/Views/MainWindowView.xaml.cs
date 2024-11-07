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
using WpfContactBookMVVM.ViewModels;

namespace WpfContactBookMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            this.DataContext = mainWindowViewModel;
        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}