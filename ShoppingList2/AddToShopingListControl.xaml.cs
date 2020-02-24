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

namespace ShoppingList2
{
    /// <summary>
    /// Interaction logic for AddToShopingListControl.xaml
    /// </summary>
    public partial class AddToShopingListControl : UserControl
    {
        public AddToShopingListControl()
        {
            InitializeComponent();
            AddButton.Click += OnAddButtonClicked;
        }

        public void OnAddButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is ShopingListData data)
            {
                data.Add(ItemToAdd.Text);
                ItemToAdd.Text = "";
            }
        }
    }
}
