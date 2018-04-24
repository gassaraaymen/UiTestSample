using Microsoft.AppCenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace UiTestSample
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage = new UiTestSample.Menu();
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
            AppCenter.Start("android=d39e4a42-76aa-4ffd-9262-c25dc9dbad7c;" +
                  "uwp={Your UWP App secret here};" +
                  "ios={Your iOS App secret here}",
                  typeof(Analytics), typeof(Crashes));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
