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

namespace UrvishkumarPatel_Final_Exam_StoreApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       
        public MainWindow()
        {
            InitializeComponent();
            SaleDataGrid.ItemsSource = Store.forSale;
            shoppingCartDataGrid.ItemsSource = Store.shoppingCart;
        }
        private void placeInCart_Click(object sender, RoutedEventArgs e)
        {
            foreach(Merchandise m in SaleDataGrid.SelectedItems)
            {
                Store.shoppingCart.Add(m);
                Store.forSale.Remove(m);
                totalPrice.Text = (int.Parse(totalPrice.Text) + m.Price).ToString();
            }
            refreshDataGrids();
        }

        private void returnToShelf_Click(object sender, RoutedEventArgs e)
        {
            foreach (Merchandise m in shoppingCartDataGrid.SelectedItems)
            {
                Store.shoppingCart.Remove(m);
                Store.forSale.Add(m);
                totalPrice.Text = (int.Parse(totalPrice.Text) - m.Price).ToString();
            }
            refreshDataGrids();
        }

        private void purchaseButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Merchandise m in Store.shoppingCart)
            {
                Store.forSale.Add(m);
                totalPrice.Text = "0";
            }
            Store.shoppingCart.Clear();
            refreshDataGrids();
        }

        private void viewItemInfo_Click(object sender, RoutedEventArgs e)
        {
            if(SaleDataGrid.SelectedItem !=null)
            {
                if(SaleDataGrid.SelectedItem is Food)
                {
                    MessageBox.Show(((Food)SaleDataGrid.SelectedItem).ReturnItemInfo());
                }
                else if(SaleDataGrid.SelectedItem is Electronics)
                {
                    MessageBox.Show(((Electronics)SaleDataGrid.SelectedItem).ReturnItemInfo());
                }
                else
                {
                    MessageBox.Show(((Clothing)SaleDataGrid.SelectedItem).ReturnItemInfo());

                }
            }
        }
        private void refreshDataGrids()
        {
            SaleDataGrid.ItemsSource = null;
            shoppingCartDataGrid.ItemsSource = null;
            SaleDataGrid.ItemsSource = Store.forSale;
            shoppingCartDataGrid.ItemsSource = Store.shoppingCart;
        }
    }
}
