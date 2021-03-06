﻿using Microsoft.Graphics.Canvas.UI.Xaml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace XAMLApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        void CanvasControl_Draw(CanvasControl sender, CanvasDrawEventArgs args)
        {
            args.DrawingSession.DrawEllipse(155, 115, 80, 30, Colors.Black, 3);
            args.DrawingSession.DrawText("Hello, world!", 100, 100, Colors.Yellow);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Game), "Hi from Main Page!");
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Game), "Hi from Main Page other button!");
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Game), "Hi from Main Page button 3!");
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Game), "Hi from Main Page button 4!");
        }
    }
}
