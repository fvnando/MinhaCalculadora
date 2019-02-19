using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace WpfApp1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        /*int Corrente = 1;
        String mOperador;
        double op1, op2;*/

        public MainWindow()
        {
            InitializeComponent();
            Button_Click(new object(), new RoutedEventArgs());
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Fernando");

           /* Button button = (Button)sender;
            string pressed = button.Content;

            if(this.resultText.Content == "0" || Corrente < 0)
            {
                this.resultText.Content = "";
                if (Corrente < 0)
                    Corrente *= -1;
            }
            this.resultText.Content += pressed ;

            double number;
            if(double.TryParse(this.resultText.Content, out number))
            {
                this.resultText.Content = number.ToString("N0");
            }*/
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           /* op1 = 0;
            op2 = 0;
            Corrente = 1;
            this.resultText.Content = "0";*/
        }
    }
}
