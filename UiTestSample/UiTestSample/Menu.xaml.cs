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
	public partial class Menu : TabbedPage
	{
		public Menu ()
		{
			InitializeComponent ();
            Calc.Content = new Calc();
            Home.Content = new Home();
            Switch.Content = new Switch();
            Navigate.Content = new Navigate();
        }       
    }
}