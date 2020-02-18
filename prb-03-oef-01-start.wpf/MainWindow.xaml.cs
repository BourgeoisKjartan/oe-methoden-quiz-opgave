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

        int score = +1;

        #region Methoden
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

        private void enableButtonQuestionA()
        {
            btnAntw1a.IsEnabled = true;
            btnAntw1b.IsEnabled = true;
            btnAntw1c.IsEnabled = true;
        }

        private void enableButtonQuestionB()
        {
            btnAntw2a.IsEnabled = true;
            btnAntw2b.IsEnabled = true;
            btnAntw2c.IsEnabled = true;
        }

        private void enablaButtonQuestionC()
        {
            btnAntw3a.IsEnabled = true;
            btnAntw3b.IsEnabled = true;
            btnAntw3c.IsEnabled = true;
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

        void foutAntwoord1()
        {
            lblFeedBack1.Content = "Het antwoord is fout";
            disableAllButtons();
        }

        void foutAntwoord2()
        {
            lblFeedBack2.Content = "Het antwoord is fout";
            disableAllButtons();
        }

        void foutAntwoord3()
        {
            lblFeedBack3.Content = "Het antwoord is fout";
            disableAllButtons();
        }

        void beginSituatie()
        {
            wrpVraag2.Visibility = Visibility.Hidden;
            wrpVraag3.Visibility = Visibility.Hidden;
            btnOpnieuw.Visibility = Visibility.Hidden;
            lblScore.Content = 0;

        }
        #endregion

        #region Events
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            beginSituatie();
            enableButtonQuestionA();

        }

        private void btnAntw1c_Click(object sender, RoutedEventArgs e)
        {
            score = +1;
            lblFeedBack1.Content = "Xamarin is juist";
            wrpVraag2.Visibility = Visibility.Visible;
            lblScore.Content = score;
            disableButtonQuestionA();
            enableButtonQuestionB();

        }

        private void btnFoutAntwoordVraag1_Click(object sender, RoutedEventArgs e)
        {
            foutAntwoord1();
            btnOpnieuw.Visibility = Visibility.Visible;
        }

        private void btnAntw2b_Click(object sender, RoutedEventArgs e)
        {
            lblFeedBack2.Content = ".Net Core is juist";
            wrpVraag3.Visibility = Visibility.Visible;
            lblScore.Content = score + 1;
            disableButtonQuestionB();
            enablaButtonQuestionC();
        }

        private void btnFoutAntwoordVraag2_Click(object sender, RoutedEventArgs e)
        {
            foutAntwoord2();
            btnOpnieuw.Visibility = Visibility.Visible;
        }

        private void btnAntw3c_Click(object sender, RoutedEventArgs e)
        {
            lblFeedBack3.Content = "Xamarin is juist";
            lblScore.Content = score + 2;
            disableButtonQuestionC();
            btnOpnieuw.Visibility = Visibility.Visible;

        }

        private void btnFoutAntwoordVraag3_Click(object sender, RoutedEventArgs e)
        {
            foutAntwoord3();
            btnOpnieuw.Visibility = Visibility.Visible;

        }

        private void btnOpnieuw_Click(object sender, RoutedEventArgs e)
        {
            beginSituatie();
            enableButtonQuestionA();
            enableButtonQuestionB();
            enablaButtonQuestionC();
        } 
        #endregion
    }
}
