using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ArabicAlphabet
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AllLetters : Page
    {
        int x = 0;
        public AllLetters()
        {
            this.InitializeComponent();

            playaudio("Assets/sound/selectaletter.wav");
        }


        private void playaudio(string sound) // defining the function
        {
            ctlMediaElement.Stop();
            ctlMediaElement.AutoPlay = true;
            var mySourceUri = new Uri(BaseUri, sound);
            ctlMediaElement.Source = mySourceUri;
            ctlMediaElement.Play();
            ctlMediaElement.MediaEnded += ctlMediaElement_MediaEnded;

        }


        private void ctlMediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            image.Source = new BitmapImage(new Uri("ms-appx:///Assets/play.png", UriKind.Absolute));
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (x == 0)
            {
                playaudio("Assets/sound/A-Alphabet-song.m4a");
                x = 1;

                image.Source = new BitmapImage(new Uri("ms-appx:///Assets/pause.png", UriKind.Absolute));


            }
            else
            {
                ctlMediaElement.Stop();
                x = 0;

                image.Source = new BitmapImage(new Uri("ms-appx:///Assets/play.png", UriKind.Absolute));

            }



        }
        private void letter1_Click(object sender, RoutedEventArgs e)
        {
            playaudio("Assets/sound/click_sound.wav");
            ctlMediaElement.Stop();
            Frame.Navigate(typeof(letter1));
          
        }
        private void letter2_Click(object sender, RoutedEventArgs e)
        {
            playaudio("Assets/sound/click_sound.wav");
            Frame.Navigate(typeof(letter2));
            ctlMediaElement.Stop();
        }
        private void letter3_Click(object sender, RoutedEventArgs e)
        {
            playaudio("Assets/sound/click_sound.wav");
            Frame.Navigate(typeof(letter3));
            ctlMediaElement.Stop();
        }
        private void letter4_Click(object sender, RoutedEventArgs e)
        {
            playaudio("Assets/sound/click_sound.wav");
            Frame.Navigate(typeof(letter4));
            ctlMediaElement.Stop();
        }
        private void letter5_Click(object sender, RoutedEventArgs e)
        {
            playaudio("Assets/sound/click_sound.wav");
            Frame.Navigate(typeof(letter5));
            ctlMediaElement.Stop();
        }
        private void letter6_Click(object sender, RoutedEventArgs e)
        {
            playaudio("Assets/sound/click_sound.wav");
            Frame.Navigate(typeof(letter6));
            ctlMediaElement.Stop();
        }
        private void letter7_Click(object sender, RoutedEventArgs e)
        {
            playaudio("Assets/sound/click_sound.wav");
            Frame.Navigate(typeof(letter7));
            ctlMediaElement.Stop();
        }
        private void letter8_Click(object sender, RoutedEventArgs e)
        {
            playaudio("Assets/sound/click_sound.wav");
            Frame.Navigate(typeof(letter8));
            ctlMediaElement.Stop();
        }
        private void letter9_Click(object sender, RoutedEventArgs e)
        {
            playaudio("Assets/sound/click_sound.wav");
            Frame.Navigate(typeof(letter9));
            ctlMediaElement.Stop();
        }
        private void letter10_Click(object sender, RoutedEventArgs e)
        {
            playaudio("Assets/sound/click_sound.wav");
            Frame.Navigate(typeof(letter10));
            ctlMediaElement.Stop();
        }
        private void letter11_Click(object sender, RoutedEventArgs e)
        {
            playaudio("Assets/sound/click_sound.wav");
            Frame.Navigate(typeof(letter11));
            ctlMediaElement.Stop();
        }

    }
}


