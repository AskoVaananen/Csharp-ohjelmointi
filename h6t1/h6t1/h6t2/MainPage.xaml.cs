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

namespace h6t1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
       private Car car;
       private Car truck;


        public MainPage()
        {
            this.InitializeComponent();

            this.car = new Car("Audi");
            Audi.Content = car.Name;

            this.truck = new Car("Sisu");
            Sisu.Content = truck.Name;
 
        }

        private void TruckButton_Click(object sender, RoutedEventArgs e)
        {

            
            truck.AddCar();
            TruckTextBlock.Text = truck.Count.ToString();


        }

        private void CarButton_Click(object sender, RoutedEventArgs e)
        {

            
            car.AddCar();
            CarTextBlock.Text = car.Count.ToString();


        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            CarTextBlock.Text = "0";
            TruckTextBlock.Text = "0";
        }
    }
}

