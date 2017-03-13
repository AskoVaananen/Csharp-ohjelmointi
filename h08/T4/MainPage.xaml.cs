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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            // click events for every button, dont need to do it in xaml.
            oneButton.Click += button_Click;
            twoButton.Click += button_Click;
            threeButton.Click += button_Click;
            fourButton.Click += button_Click;
            fiveButton.Click += button_Click;
            sixButton.Click += button_Click;
            sevenButton.Click += button_Click;
            eightButton.Click += button_Click;
            nineButton.Click += button_Click;
            zeroButton.Click += button_Click;
            dotButton.Click += buttondot_Click;


        }

        private void button_Click(object sender, RoutedEventArgs e)  // Click event handling, add chars to screenBox
        {
            double check = double.Parse(screenBox.Text); // for checking content of screenbox
            if (check == 0) // checking if theres 0 and remove it
            {
                screenBox.Text = "";
            }
            string buttonString = (((Button)sender).Content).ToString(); // get buttoncontent
            screenBox.Text += buttonString; // add button Content string to screenBox
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        { // removing last character and put 0 if theres no characters left
            string value = screenBox.Text;
            value = value.Remove(value.Length - 1);
            if (value.Length == 0)
            {
                screenBox.Text = "0";
            }
            else
            {
                screenBox.Text = value;
            }
        }


        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            heater kiuas = new heater(); // new kiuas from heater.cs
            if ((bool)radioTempButton.IsChecked) // when temperature radiobutton is active
            {
                try
                {   //values are limited in heater.cs
                    kiuas.Temperature = double.Parse(screenBox.Text);
                    tempscreenBlock.Text = kiuas.Temperature.ToString();
                    if (kiuas.Temperature == 0)
                    {
                        infoscreenBlock.Text = "Syöttämäsi luku ei ole 0 ja 120 välillä!";

                    }
                }
                catch
                {
                    infoscreenBlock.Text = "Ei ole numero!"; // print to infobox

                }
                /*
               finally
               {

               }
               */


            }

            if ((bool)radioHumButton.IsChecked) // when humidityradio is active
            {
                try
                {   //values are limited in heater.cs
                    kiuas.Humidity = double.Parse(screenBox.Text);
                    humscreenBlock.Text = kiuas.Humidity.ToString();
                    if (kiuas.Humidity == 0)
                    {
                        infoscreenBlock.Text = "Syöttämäsi arvo ei ole 0 ja 100 välillä!";

                    }
                }
                catch
                {
                    infoscreenBlock.Text = "Ei ole numero!";

                }
                /*
                finally
                {

                }
                */


            }
        }
          private void buttondot_Click(object sender, RoutedEventArgs e)
        {
            screenBox.Text += ".";
           
        }
    }
}
