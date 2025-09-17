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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ObDlugosc_Click(object sender, RoutedEventArgs e)
        {
            double dlugosc = double.Parse(TxtDlugosc.Text);
            if(mila.IsChecked == true)
            {
               txtmile.Text = (dlugosc* 0,000621371192).ToString();
            }
        }
    }
}