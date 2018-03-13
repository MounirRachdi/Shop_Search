using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shop_Search.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShopPage : ContentPage
	{
        List<Product> list;
        public ShopPage ()
		{
            Products products = new Products();
                InitializeComponent ();

           
            list = products.GetProducts();
            listview1.ItemsSource = list;
			
		}
        public void Search_Product (object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MainSearchBar.Text))
            {
                listview1.ItemsSource = list;
            }

            else
            {
                listview1.ItemsSource = list.Where(x => x.name.ToLower().Contains(MainSearchBar.Text.ToLower()));
            }
        }

    }
}