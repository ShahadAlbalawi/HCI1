﻿using System;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ArabicAlphabet
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class letter1 : Page
    {
        public letter1()
        {
            this.InitializeComponent();
          
        }
        private void playaudio(string sound) // defining the function
        {
            ctlMediaElement.Stop();
            ctlMediaElement.AutoPlay = true;
            var mySourceUri = new Uri(BaseUri, sound);
            ctlMediaElement.Source = mySourceUri;
            ctlMediaElement.Play();
        }
        private void letter1soundbutten_Click(object sender, RoutedEventArgs e)
        {
            playaudio("Assets/sound/alif.wav");
        }

        private void example1_Click(object sender, RoutedEventArgs e)
        {
            playaudio("Assets/sound/arnab.wav");
        }
        private void example2_Click(object sender, RoutedEventArgs e)
        {
            playaudio("Assets/sound/far.wav");
        }
        private void example3_Click(object sender, RoutedEventArgs e)
        {
            playaudio("Assets/sound/egra.wav");
        }

        private void homebutton_Click(object sender, RoutedEventArgs e)
        {
            playaudio("Assets/sound/click_sound.wav");
            Frame.Navigate(typeof(AllLetters));
            ctlMediaElement.Stop();
        }
        
        private void Nextbutton_Click(object sender, RoutedEventArgs e)
        {
           
         
           Frame.Navigate(typeof(letter2));
            playaudio("Assets/sound/click_sound.wav");
            ctlMediaElement.Stop();
        }
    }
}