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
	public partial class Calc : ContentView
	{
		public Calc ()
		{
			InitializeComponent ();
		}

        private void Add_Clicked(object sender, EventArgs e)
        {
            ResultLabel.Text = (Convert.ToInt32(ValueAEntry.Text) + Convert.ToInt32(ValueBEntry.Text)).ToString();
        }

        private void Multiply_Clicked(object sender, EventArgs e)
        {
            ResultLabel.Text = (Convert.ToInt32(ValueAEntry.Text) * Convert.ToInt32(ValueBEntry.Text)).ToString();
        }
    }
}