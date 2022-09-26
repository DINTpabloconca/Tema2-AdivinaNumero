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

namespace Tema2_AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int random;
        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();
            random = rnd.Next(100 + 1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int numeroIntroducido = Int32.Parse(numeroTextBox.Text);
            if (numeroIntroducido == random)
            {
                resultadoTextBlock.Text = "Has acertado!";
            }
            else if (numeroIntroducido > random)
            {
                resultadoTextBlock.Text = "Te has pasado!";
            }
            else
            {
                resultadoTextBlock.Text = "Te has quedado corto!";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            random = rnd.Next(100 + 1);
            resultadoTextBlock.Text = "";
        }


    }
}
