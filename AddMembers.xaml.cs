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
    /// Interaction logic for AddMembers.xaml
    /// </summary>
    public partial class AddMembers : Window
    {
        public AddMembers()
        {
            InitializeComponent();

            //refresh listbox to reflect changes
            lbMembers.Items.Refresh();
            //lbTransactions.Items.Refresh();
            //populate members listbox with members from data class
            lbMembers.ItemsSource = Data.Member;
            //lbTransactions.ItemsSource = Data.Currentproduct;
        }

        private void btnAddMembers_Click(object sender, RoutedEventArgs e)
        {
            // if/else to check which radio button is selected, then add info from text boxes and add to the
            // designated member class (gold or regular member) depending on which button selected
            // add the member to the collection in the data class
            if (rbOne.IsChecked.Value)
            {
                string fName = tbFirstName.Text;
                string lName = tbLastName.Text;
                RegularMember newRMember = new RegularMember(fName, lName);
                Data.AddMemberToCollection(newRMember);
                tbFirstName.Clear();
                tbLastName.Clear();
                rbOne.IsChecked= false;
            }
            else
            {
                string fName = tbFirstName.Text;
                string lName = tbLastName.Text;
                GoldMember newGMember = new GoldMember(fName, lName);
                Data.AddMemberToCollection(newGMember);
                tbFirstName.Clear();
                tbLastName.Clear();
                rbTwo.IsChecked = false;
            }
        }
    }
}
