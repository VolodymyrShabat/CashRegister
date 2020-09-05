using System;
using System.Collections.Generic;
using System.Linq;
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

namespace CashRegister
{
    /// <summary>
    /// Interaction logic for MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }
        private void BtClickP1(object sender, RoutedEventArgs e)
        {

            MainWindow window1 = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (window1 != null)       
            {
                window1.Main.Content = new Page1();
            }
        }

        private void BtClickP2(object sender, RoutedEventArgs e)
        {

            MainWindow window1 = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (window1 != null)
            {
                window1.Main.Content = new Page2();
            }
        }

        private void BtClickP3(object sender, RoutedEventArgs e)
        {

            MainWindow window1 = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (window1 != null)
            {
                window1.Main.Content = new Page3();
            }

        }
    }
}
