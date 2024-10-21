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

namespace faculteit
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
            this.Close(); 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            numberTextBox.Clear();
            resultTextBox.Clear();
            numberTextBox.Focus();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //input
            double number = double.Parse(numberTextBox.Text);
            double result = 1;
            //berekening
            do
            {
                result *= number;  // vermenigvuldig het getal met nummer
                number--;          // doe nummer -1
            }
            while (number > 0);
            //output
            resultTextBox.Text = result.ToString();
        }
    }
}