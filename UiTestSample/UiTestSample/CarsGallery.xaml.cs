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
	public partial class CarsGallery : CarouselPage
    {
		public CarsGallery ()
		{
			InitializeComponent ();
            Car1.Source = ImageSource.FromFile("car1.png");
            Car2.Source = ImageSource.FromUri(new Uri("http://www.pngmart.com/files/5/Race-Car-PNG-Pic.png"));
            Car3.Source = ImageSource.FromUri(new Uri("http://www.pngmart.com/files/5/Race-Car-Transparent-PNG.png"));
        }
	}
}