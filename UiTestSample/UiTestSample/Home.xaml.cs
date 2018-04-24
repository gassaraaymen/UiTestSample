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
	public partial class Home : ContentView
	{
		public Home ()
		{
			InitializeComponent ();
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += (sender, e) =>
            {
                this.BackgroundColor = Color.Coral;
                MyLabel.TextColor = Color.Black;
            };
            MyImg.GestureRecognizers.Add(tap);
        }
	}
}