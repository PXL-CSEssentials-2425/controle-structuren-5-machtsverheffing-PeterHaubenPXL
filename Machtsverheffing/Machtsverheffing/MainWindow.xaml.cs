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

namespace Machtsverheffing
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

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cleanButton_Click(object sender, RoutedEventArgs e)
        {
            numberTextBox.Text = "";
            numberTextBox.Focus();

            resultTextBox.Text = "";
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            bool isNumber = double.TryParse(numberTextBox.Text, out double number);
            string result = "";
            if (isNumber && number >= -84 && number <= 84)
            {
                for(int i = 1; i < 11; i++)
                {
                    result = result + $"Macht {i} from {number} is " + Math.Pow(number, i).ToString() + "\n";
                }
                resultTextBox.Text = result;
            }
            else
            { 
                MessageBox.Show("Geef een getal in tussen 0 en 84", "Foutieve ingave");

                numberTextBox.Focus();
                numberTextBox.SelectAll();

                resultTextBox.Text = "";
            }
        }
    }
}