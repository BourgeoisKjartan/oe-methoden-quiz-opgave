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

namespace prb_03_oef_01_start.wpf
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
    
        private void disableAllButtons()
        {
            btnAntw1a.IsEnabled = false;
            btnAntw1b.IsEnabled = false;
            btnAntw1c.IsEnabled = false;
            btnAntw2a.IsEnabled = false;
            btnAntw2b.IsEnabled = false;
            btnAntw2c.IsEnabled = false;
            btnAntw3a.IsEnabled = false;
            btnAntw3b.IsEnabled = false;
            btnAntw3c.IsEnabled = false;

        }

        private void disableButtonQuestionA()
        {
            btnAntw1a.IsEnabled = false;
            btnAntw1b.IsEnabled = false;
            btnAntw1c.IsEnabled = false;
        }

        private void disableButtonQuestionB()
        {
            btnAntw2a.IsEnabled = false;
            btnAntw2b.IsEnabled = false;
            btnAntw2c.IsEnabled = false;
        }

        private void disableButtonQuestionC()
        {
            btnAntw3a.IsEnabled = false;
            btnAntw3b.IsEnabled = false;
            btnAntw3c.IsEnabled = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            wrpVraag2.Visibility = Visibility.Hidden;
            wrpVraag3.Visibility = Visibility.Hidden;

        }

        private void btnAntw1c_Click(object sender, RoutedEventArgs e)
        {
            lblFeedBack1.Content = "Xamarin is juist";
            wrpVraag2.Visibility = Visibility.Visible;
            lblScore.Content = +1;
            disableButtonQuestionA();



        }

        private void btnFoutAntwoordVraag1_Click(object sender, RoutedEventArgs e)
        {
            disableAllButtons();
        }


    }
}
