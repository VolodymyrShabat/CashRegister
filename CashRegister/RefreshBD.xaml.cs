using System;
using System.Collections.Generic;
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
    /// Interaction logic for RefreshBD.xaml
    /// </summary>
    public partial class RefreshBD : Page
    {
        public RefreshBD()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using(AppContext db = new AppContext())
            {
                db.Products.Add(new Product { ProductName = TextBox1.Text.ToString(),
                    Price = float.Parse(TextBox2.Text),
                    Quantity = int.Parse(TextBox3.Text), 
                    ProductType = TextBox4.Text.ToString(),
                    ProductSubType = TextBox5.Text.ToString() });
                db.SaveChanges();
                MessageBox.Show("fdsfsd");
            }
        }
    }
}
