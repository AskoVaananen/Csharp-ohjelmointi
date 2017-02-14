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

namespace h6t3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private double conversion = 5.946; // for conversions
        public MainPage()
        {
            this.InitializeComponent();
        }
        //markka to euro
        private void EuroButton_Click(object sender, RoutedEventArgs e)
        {
            double result;
            bool check = double.TryParse(MarkkaTextBox.Text, out result);
            if (check)
            {
                euroTextBox.Text = (result / conversion).ToString("0.00");
            }
            else
                euroTextBox.Text = "Error";
        }
        //euro to markka
        private void MarkkaButton_Click(object sender, RoutedEventArgs e)
        {
            double result;
            bool check = double.TryParse(euroTextBox.Text, out result);
            if (check)
            {
                MarkkaTextBox.Text = (result / conversion).ToString("0.00");
            }
            else
                MarkkaTextBox.Text = "Error not number";
        }
    }
}
