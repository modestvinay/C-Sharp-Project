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

namespace wpftutorial
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window8 objWindow8 = new Window8();
           this.Visibility = Visibility.Hidden;
            objWindow8.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window1 objWindow1 = new Window1();
            this.Visibility = Visibility.Hidden;
            objWindow1.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window3 objWindow3 = new Window3();
            this.Visibility = Visibility.Hidden;
            objWindow3.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window5 objWindow5 = new Window5();
            this.Visibility = Visibility.Hidden;
            objWindow5.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Window7 objWindow7 = new Window7();
            this.Visibility = Visibility.Hidden;
            objWindow7.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Window2 objWindow2 = new Window2();
            this.Visibility = Visibility.Hidden;
            objWindow2.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Window4 objSEcondWindow = new Window4();
            this.Visibility = Visibility.Hidden;
            objSEcondWindow.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Window6 objWindow6 = new Window6();
            this.Visibility = Visibility.Hidden;
            objWindow6.Show();
        }
    }
}
