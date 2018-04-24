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
    public partial class Navigate : ContentView
    {
        private CarsGallery MainPage;

        public Navigate()
        {
            InitializeComponent();
        }

        private void Navigate_Command(object sender, ClickedEventArgs e)
        {            
            Navigation.PushModalAsync(new CarsGallery());
        }
        private void Navigate_Element_Command(object sender, ClickedEventArgs e)
        {           
            Navigation.PushModalAsync(new Elements());
        }
        
    }
}