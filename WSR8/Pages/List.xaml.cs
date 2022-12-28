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
using System.Windows.Shapes;
using WSR8.Entities;
using WSR8.Pages;

namespace WSR8.Pages
{
    /// <summary>
    /// Логика взаимодействия для List.xaml
    /// </summary>
    public partial class List : Window
    {
        public List()
        {
            InitializeComponent();
            var product = WSR8Entities.GetContext().Product.ToList();
            LView_Search.ItemsSource = product;
            CBoxCost.SelectedIndex = 0 ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void UpdateProduct()
        {
            var product = WSR8Entities.GetContext().Product.ToList();
            if(CBoxCost.SelectedIndex == 0)
            {
                product = product.OrderByDescending(p => p.ProductCost).ToList();
            }
            else
            {
                product = product.OrderBy(p => p.ProductCost).ToList();
            }

            

            LView_Search.ItemsSource= product;
        }
    }
}
