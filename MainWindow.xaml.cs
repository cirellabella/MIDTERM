//Cirella Smith
//May 14, 2023
//CSI 124 Midterm
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

namespace MIDTERM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //populate combobox with members from data class
            cbx_MemberSelect.ItemsSource = Data.Member;

            //populate listbox with products from the data class
            lb_Products.ItemsSource = Data.Product;
        }

        private void btn_MemInfo_Click(object sender, RoutedEventArgs e)
        {
            //open a new window to view and change member info
            //create a new instance of the member page
            AddMembers memberPage = new AddMembers();
            //open the page by using the .show method
            memberPage.Show();
        }

        private void btn_AddNewProduct_Click(object sender, RoutedEventArgs e)
        {
            //open a new window to add products
            //create a new instance of the products page
            AddNewProduct productPage = new AddNewProduct();
            //open the page by using the .show method
            productPage.Show();
        }

        private void cbx_MemberSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //
            //Member selectedMember = (Member)cbx_MemberSelect.SelectedItem;
            //Product prod = (Product)lb_Products.SelectedItem;
            //selectedMember.AddProduct(prod);

        }

        private void btn_BuyProduct_Click(object sender, RoutedEventArgs e)
        {

            //loop through the items in listbox of products and copy the selected item to the transactions listbox
            foreach (var item in lb_Products.SelectedItems)
            {
                lb_transactions.Items.Add(item);
                
            }
            lb_transactions.Items.Refresh();

            //change points on combobox
            Member selectMember = (Member)cbx_MemberSelect.SelectedItem;
            Product prod = (Product)lb_Products.SelectedItem;
            selectMember.AddPoints(prod);
            cbx_MemberSelect.Items.Refresh();

            //Adjust label to reflect member's current points
            lblPoints.Content = $"Member points: {selectMember.pointAmount}";

        }

        private void rtb_UpsellNotes_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_UsePoints_Click(object sender, RoutedEventArgs e)
        {
            //loop through the items in listbox of products and copy the selected item to the transactions listbox
            foreach (var item in lb_Products.SelectedItems)
            {
                lb_transactions.Items.Add(item);

            }
            lb_transactions.Items.Refresh();

            //change points on combobox with if/else to ensure enough points to use for order
            Member selectMember = (Member)cbx_MemberSelect.SelectedItem;
            Product prod = (Product)lb_Products.SelectedItem;
            if (selectMember.pointAmount >= prod._points)
            {
                selectMember.DeductPoints(prod);
            }
            else
            {
                MessageBox.Show("Not enough points!");
            }
            cbx_MemberSelect.Items.Refresh();

            //Adjust label to reflect member's current points
            lblPoints.Content = $"Member points: {selectMember.pointAmount}";
        }
    }
}
