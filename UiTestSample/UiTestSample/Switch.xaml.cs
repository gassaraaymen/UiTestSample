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
    public partial class Switch : ContentView
    {
        public Switch()
        {
            InitializeComponent();
            mySwitch.Toggled += (sender, e) =>
            {
                if (e.Value == true)
                {
                    BackgroundColor = Color.Black;
                    MyImg.Source = ImageSource.FromFile("on");
                }
                else
                {
                    BackgroundColor = Color.White;
                    MyImg.Source = ImageSource.FromFile("off");
                }
            };
        }

        private void MainSlider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            MainLabel.Text = MainSlider.Value.ToString();
        }
    }
}