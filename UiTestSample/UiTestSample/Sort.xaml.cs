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
    public partial class Sort : ContentPage
    {
        bool radio1, radio2, radio3, radio4, radio5, radio6;
        public Sort()
        {
            InitializeComponent();
        }
        public void OnClickSortByNameNoSort(object sender, EventArgs e)
        {
            radio1 = true;
            button1.Source = "radiobuttonchecked.png";
            if (radio1.Equals(true))
            {
                button2.Source = "radiobuttonunchecked.png";
                button3.Source = "radiobuttonunchecked.png";

                radio1 = false;

            }
        }
        public void OnClickSortByNameAtoZ(object sender, EventArgs e)
        {
            radio2 = true;
            button2.Source = "radiobuttonchecked.png";
            if (radio2.Equals(true))
            {
                button3.Source = "radiobuttonunchecked.png";
                button1.Source = "radiobuttonunchecked.png";
                radio2 = false;
            }
        }


        public void OnClickSortByNameZtoA(object sender, EventArgs e)
        {
            radio3 = true;
            button3.Source = "radiobuttonchecked.png";
            if (radio3.Equals(true))
            {
                //button4.Source = "radiobuttonunchecked.png";
                button2.Source = "radiobuttonunchecked.png";
                button1.Source = "radiobuttonunchecked.png";
                radio3 = false;
            }
        }

        public void OnClickSortByCodeNoSort(object sender, EventArgs e)
        {
            radio4 = true;
            buttonCode1.Source = "radiobuttonchecked.png";
            if (radio4.Equals(true))
            {
                buttonCode2.Source = "radiobuttonunchecked.png";
                buttonCode3.Source = "radiobuttonunchecked.png";
                radio4 = false;
            }
        }

        public void OnClickSortByCodeAsc(object sender, EventArgs e)
        {
            radio5 = true;
            buttonCode2.Source = "radiobuttonchecked.png";
            if (radio5.Equals(true))
            {
                buttonCode1.Source = "radiobuttonunchecked.png";
                buttonCode3.Source = "radiobuttonunchecked.png";
                radio5 = false;
            }
        }

        public void OnClickSortByCodeDesc(object sender, EventArgs e)
        {
            radio6 = true;
            buttonCode3.Source = "radiobuttonchecked.png";
            if (radio6.Equals(true))
            {
                buttonCode1.Source = "radiobuttonunchecked.png";
                buttonCode2.Source = "radiobuttonunchecked.png";
                radio6 = false;
            }

        }
        public void GoBack(object sender, EventArgs args)
        {
            Navigation.PopModalAsync();
        }


    }
}