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
    /// Interaction logic for InformationOfBD.xaml
    /// </summary>
    public partial class InformationOfBD : Page
    {
        public InformationOfBD()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using(AppContext db = new AppContext())
            {
                var l = db.Products.ToList();
                foreach (var item in l)
                {
                    T1.Text += item.ToString();
                }
            }
        }
    }
}
