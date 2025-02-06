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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private int clickCount;
        public string name { get; set; } = "...";
        public MainWindow()
        {
            InitializeComponent();
            //clickCount = 0;
            this.DataContext = this;
        }

        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            //clickCount++;
            //MainLabel.Content = "button clicked: " + clickCount + " times";
            name = MainTextBox.Text;
            MainLabel.Content = $"hello, {name.ToString()}!";
        }
    }
}