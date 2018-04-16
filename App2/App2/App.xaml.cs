using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Distribute;

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
            AppCenter.Start("ios=f2de57a8-2878-438c-bfe5-3341f1ffd455;" +
                  //"uwp={Your UWP App secret here};" +
                  "android=b390cdc5-15f2-4ed4-bb70-eae2ce579d09",
                  typeof(Analytics), typeof(Crashes), typeof(Distribute));


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
