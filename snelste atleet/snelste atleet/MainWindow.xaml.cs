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

namespace snelste_atleet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //lijst voor alle athelten
        private List<name> atleet = new List<atleet>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            // declareer mijn variable
            string name = nameTextBox.Text;
            int time = int.Parse(timeTextBox.Text);
            int fastest;
            // testen of atheleet een naam heeft
            if (int.TryParse(timeTextBox.Text, out time) && !string.IsNullOrWhiteSpace(name))
            {
                
            }


            int hour = time / 60;
            int minute = (time % 3600) / 60;
            int second = time % 60;


            
            resultTextBox.Text = $"De tijd van de atleet is {hour} uren en {minute}minuten en {second}seconden";
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            timeTextBox.Clear();
            resultTextBox.Clear();
            nameTextBox.Clear();
        }
    }
}