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

namespace MIDTERM
{
    /// <summary>
    /// Interaction logic for AddNewProduct.xaml
    /// </summary>
    public partial class AddNewProduct : Window
    {
        public AddNewProduct()
        {
            InitializeComponent();

            //call the method for the combobox for size of drinks
            PopulateSizeComboBox();

            //populate the listbox of Products with the Products from the data class
            lbProducts.ItemsSource = Data.Product;
        }

        //method to populate the combobox for size of drinks
        void PopulateSizeComboBox()
        {
            cbSize.Items.Add("Short");
            cbSize.Items.Add("Tall");
            cbSize.Items.Add("Grande");
            cbSize.Items.Add("Venti");
            cbSize.Items.Add("Trenta");
            cbSize.SelectedIndex = 0;
        }

        //gather all the info from the textboxes and create variables, add those fields to
        //the new gift card that instantiated, then add to data class,
        //finally clear out all the textboxes for the next entry
        private void btnGiftCard_Click(object sender, RoutedEventArgs e)
        {
            string prodName = tbName.Text;
            decimal prodPrice = Convert.ToDecimal(tbPrice.Text);
            int prodPoints = Convert.ToInt32(tbPoints.Text);
            int gcAmount = Convert.ToInt32(tbGcAmount.Text);
            GiftCard gc = new GiftCard(prodName, prodPrice, prodPoints, gcAmount);
            Data.AddProductToCollection(gc);
            tbName.Clear();
            tbPrice.Clear();
            tbPoints.Clear();
            tbGcAmount.Clear();
        }

        //gather all the info from the textboxes and create variables, add those fields to
        //the new tumblers that instantiated, then add to data class,
        //finally clear out all the textboxes for the next entry
        private void btnTumbler_Click(object sender, RoutedEventArgs e)
        {
            string prodName = tbName.Text;
            decimal prodPrice = Convert.ToDecimal(tbPrice.Text);
            int prodPoints = Convert.ToInt32(tbPoints.Text);
            string prodColor = tbColorStyle.Text;
            Tumblers tum = new Tumblers(prodName, prodPrice, prodPoints, prodColor);
            Data.AddProductToCollection(tum);
            tbName.Clear();
            tbPrice.Clear();
            tbPoints.Clear();
            tbColorStyle.Clear();
        }

        //gather all the info from the textboxes and create variables, add those fields to
        //the new mugs that instantiated, then add to data class,
        //finally clear out all the textboxes for the next entry
        private void btnMug_Click(object sender, RoutedEventArgs e)
        {
            string prodName = tbName.Text;
            decimal prodPrice = Convert.ToDecimal(tbPrice.Text);
            int prodPoints = Convert.ToInt32(tbPoints.Text);
            string prodDesign = tbColorStyle.Text;
            Mugs mug = new Mugs(prodName, prodPrice, prodPoints, prodDesign);
            Data.AddProductToCollection(mug);
            tbName.Clear();
            tbPrice.Clear();
            tbPoints.Clear();
            tbColorStyle.Clear();
        }

        //gather all the info from the textboxes and create variables, add those fields
        //and the size from the combobox to the new coffee that instantiated, then add to data class,
        //finally clear out all the textboxes for the next entry
        private void btnCoffee_Click(object sender, RoutedEventArgs e)
        {
            Coffee.Size size = (Coffee.Size)cbSize.SelectedIndex;

            string prodName = tbName.Text;
            decimal prodPrice = Convert.ToDecimal(tbPrice.Text);
            int prodPoints = Convert.ToInt32(tbPoints.Text);
            string roast = tbRoastOrTea.Text;
            Coffee coffee = new Coffee(prodName, prodPrice, prodPoints, size, roast);
            Data.AddProductToCollection(coffee);
            cbSize.Items.Refresh();
            tbName.Clear();
            tbPrice.Clear();
            tbPoints.Clear();
            tbRoastOrTea.Clear();
        }

        //gather all the info from the textboxes and create variables, add those fields 
        //and the size from the combobox to the new tea that instantiated, then add to data class,
        //finally clear out all the textboxes for the next entry
        private void btnTea_Click(object sender, RoutedEventArgs e)
        {
            Tea.Size size = (Tea.Size)cbSize.SelectedIndex;


            string prodName = tbName.Text;
            decimal prodPrice = Convert.ToDecimal(tbPrice.Text);
            int prodPoints = Convert.ToInt32(tbPoints.Text);
            string teaType = tbRoastOrTea.Text;
            Tea tea = new Tea(prodName, prodPrice, prodPoints, size, teaType);
            Data.AddProductToCollection(tea);
            cbSize.Items.Refresh();
            tbName.Clear();
            tbPrice.Clear();
            tbPoints.Clear();
            tbRoastOrTea.Clear();
        }

        //gather all the info from the textboxes and create variables, add those fields  (& 2 new bool results) to
        //the new breakfast that instantiated, then add to data class,
        //finally clear out all the textboxes for the next entry
        private void btnBreakfast_Click(object sender, RoutedEventArgs e)
        {
            string prodName = tbName.Text;
            decimal prodPrice = Convert.ToDecimal(tbPrice.Text);
            int prodPoints = Convert.ToInt32(tbPoints.Text);
            bool heated = cbHeated.IsChecked.Value;
            bool dOrC = cbDairyOrCombo.IsChecked.Value;
            Breakfast bf = new Breakfast(prodName, prodPrice, prodPoints, heated, dOrC);
            Data.AddProductToCollection(bf);
            tbName.Clear();
            tbPrice.Clear();
            tbPoints.Clear();
        }

        //gather all the info from the textboxes and create variables, add those fields (and 2 new bool results) to
        //the new mugs that instantiated, then add to data class,
        //finally clear out all the textboxes for the next entry
        private void btnLunch_Click(object sender, RoutedEventArgs e)
        {
            string prodName = tbName.Text;
            decimal prodPrice = Convert.ToDecimal(tbPrice.Text);
            int prodPoints = Convert.ToInt32(tbPoints.Text);
            bool heated = cbHeated.IsChecked.Value;
            bool dOrC = cbDairyOrCombo.IsChecked.Value;
            Lunch lunch = new Lunch(prodName, prodPrice, prodPoints, heated, dOrC);
            Data.AddProductToCollection(lunch);
            tbName.Clear();
            tbPrice.Clear();
            tbPoints.Clear();
        }
    }
}
