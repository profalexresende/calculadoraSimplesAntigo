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

namespace calculadoraSimples
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

        private void btnSomar_Click(object sender, RoutedEventArgs e)
        {
            //Declarando as variáveis
            double n1, n2, res;

            //Efetuando a entrada de dados
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            //Efetuando o cálculo
            res = n1 + n2;
            //Exibindo o resultado convertido em string
            lblResultado.Content = res.ToString();
        }
    }
}
