using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kalkulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TextBox TextBoxA; 
        public TextBox TextBoxB;
        public ComboBox ComboBoxA;

        public MainWindow()
        {
            InitializeComponent();
            TextBoxA = (TextBox)this.FindName("liczbaA");
            TextBoxB = (TextBox)this.FindName("liczbaB");
            ComboBoxA = (ComboBox)this.FindName("Znak");
        }

        private void NumberValidationTextbox (object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxA.Text == "" || TextBoxB.Text == "")
            {
                MessageBox.Show("Wpisz Liczbe");
            }
            else
            {
                switch (ComboBoxA.SelectedIndex)
                {
                    case 0:
                        dodawanie obiekt1 = new dodawanie(Convert.ToDouble(TextBoxA.Text), Convert.ToDouble(TextBoxB.Text));
                        MessageBox.Show(obiekt1.DzialanieMatematyczne());
                        break;
                    case 1:
                        odejmowanie obiekt2 = new odejmowanie(Convert.ToDouble(TextBoxA.Text), Convert.ToDouble(TextBoxB.Text));
                        MessageBox.Show(obiekt2.DzialanieMatematyczne());
                        break;
                    case 2:
                        mnozenie obiekt3 = new mnozenie(Convert.ToDouble(TextBoxA.Text), Convert.ToDouble(TextBoxB.Text));
                        MessageBox.Show(obiekt3.DzialanieMatematyczne());
                        break;
                    case 3:
                        dzielenie obiekt4 = new dzielenie(Convert.ToDouble(TextBoxA.Text), Convert.ToDouble(TextBoxB.Text));
                        MessageBox.Show(obiekt4.DzialanieMatematyczne());
                        break;

                    default:
                        MessageBox.Show("Wybierz dzialanie");
                        break;
                }
            }
            
        }
    }
}
