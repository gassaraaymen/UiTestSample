using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UiTestSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Elements : ContentPage
	{
		public Elements ()
		{
			InitializeComponent ();           
            String[] names = { "Aymen", "Emna", "Fawzi", "Mounir" };
            myListView.ItemsSource = names;

            myListView.ItemSelected += (s, e) =>
            {
               DisplayAlert("Selected Item", "You have selected: " + e.SelectedItem.ToString(), "ok");                
            };
        }

        private void Return_To_Home_Page(object sender, ClickedEventArgs e)
        {
            Navigation.PushModalAsync(new Menu());
        }
    }
}