using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
	public partial class MainPage : CarouselPage
	{
		public MainPage()
		{
			InitializeComponent();


        }

        private void MainBtn_OnClicked(object sender, EventArgs e)
        {
            try
            {
                Debug.WriteLine("Get Rekt button clicked!");
                var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                player.Load("getRekt.mp3");
                //player.Load(Path.Combine("Assets","censorbeep4.mp3"));

                // Read the contents of our asset
                //var assembly = typeof(App).GetTypeInfo().Assembly;
                //Stream audioStream = assembly.GetManifestResourceStream("Audio/censor_beep_4.mp3");

           
                //var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                //player.Load(audioStream);

                player.Play();
				Analytics.TrackEvent("getRekt_Played");
            }
            catch (Exception exception)
            {
                Crashes.TrackError(exception);
                Debug.WriteLine("Error playing sound");
                Debug.WriteLine(exception.ToString());
                //throw (exception);
            }

        }
		private void MainBtn2_OnClicked(object sender, EventArgs e)
        {
            try
            {
                Debug.WriteLine("Get Rekt button clicked!");
                var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                player.Load("rektrainbow.mp3");
                //player.Load(Path.Combine("Assets","censorbeep4.mp3"));

                // Read the contents of our asset
                //var assembly = typeof(App).GetTypeInfo().Assembly;
                //Stream audioStream = assembly.GetManifestResourceStream("Audio/censor_beep_4.mp3");


                //var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                //player.Load(audioStream);

                player.Play();
				Analytics.TrackEvent("rektRainbow_Played");
            }
            catch (Exception exception)
            {
                Crashes.TrackError(exception);
                Debug.WriteLine("Error playing sound");
                Debug.WriteLine(exception.ToString());
                //throw (exception);
            }

        }
	}
}
