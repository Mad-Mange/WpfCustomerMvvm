using System.Windows;
using WpfApp1TaBortMig.ViewModels;

namespace WpfApp1TaBortMig
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new CustomerViewModel();
        }
    }
}
