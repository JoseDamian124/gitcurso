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

namespace DemoXAML
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int conteo;
        public MainWindow()
        {
            InitializeComponent();
            conteo = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            conteo++;
            conteolabel.Content = Convert.ToString(conteo);
        }
    }
}
