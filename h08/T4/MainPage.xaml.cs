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
            
        
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double check = double.Parse(screenBox.Text);
            if (check == 0)
            {
                screenBox.Text = "";
            }
            string buttonString = (((Button)sender).Content).ToString();
            screenBox.Text += buttonString;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
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
            heater kiuas = new heater();
            if ((bool)radioTempButton.IsChecked)
            {
                try
                {
                    kiuas.Temperature = double.Parse(screenBox.Text);
                    tempscreenBlock.Text = kiuas.Temperature.ToString();
                    if (kiuas.Temperature == 0)
                    {
                        infoscreenBlock.Text = "Syöttämäsi arvo ei ole 0 ja 100 välillä!";

                    }
                }
                catch
                {
                    infoscreenBlock.Text = "Ei ole numero!";

                }
                finally
                {

                }


            }

            if ((bool)radioHumButton.IsChecked)
            {
                try
                {
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
                finally
                {

                }


            }
        }
          private void buttondot_Click(object sender, RoutedEventArgs e)
        {
            screenBox.Text += ".";
           
        }
    }
}
