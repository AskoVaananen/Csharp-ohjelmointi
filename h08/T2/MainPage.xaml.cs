﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;
using System.Diagnostics;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            // change the default startup mode
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            // specify the size width:800, height:600 window size
            ApplicationView.PreferredLaunchViewSize = new Size(800, 600);
            // disable debugging frame rate counter
            App.Current.DebugSettings.EnableFrameRateCounter = false;
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Name: " + nameTextBox.Text);
            Debug.WriteLine("Email: " + emailTextBox.Text);
            if ((bool)normalUsercheckbox.IsChecked)
            {
                Debug.WriteLine("Normal User");
            }
            if ((bool)admincheckbox.IsChecked)
            {
                Debug.WriteLine("Admin User");
            }

        }
    }
}
