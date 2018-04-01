using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

using Xamarin.Forms;

namespace App2
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new App2.MainPage();
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
            AppCenter.Start("ios=d0af9a4b-6edc-4e45-bfa6-477ddd0cc08f;" +
                  //"uwp={Your UWP App secret here};" +
                  "android=e56b418b-8094-4959-a134-c8b9a9835637",
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
