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
using WpfApp.Models;
using WpfApp.ViewModel;
using WpfApp.Views;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainViewModel mainViewModel = new MainViewModel();
            this.DataContext = mainViewModel;
        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MainListView.Items.Filter = FilterMethod;
        }

        private bool FilterMethod(object obj)
        {
            var job = obj as Job;
            return job.Title.Contains(FilterTextBoxx.Text, StringComparison.OrdinalIgnoreCase);
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            ApplyToJob applyToJob = new ApplyToJob();
            applyToJob.Show();
        }
    }
}