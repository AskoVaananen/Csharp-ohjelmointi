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
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace h6t4
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






        private async void LaskeButton_Click(object sender, RoutedEventArgs e)
        {
            double WindowWidth;
            double WindowHeight;
            double FrameWidth;

            


                if (!double.TryParse(LTextBox.Text, out WindowWidth))
                {
                    var dialog = new MessageDialog("Check WidthValue!");
                    await dialog.ShowAsync();
                }



                if (!double.TryParse(HTextBox.Text, out WindowHeight))
                {
                    var dialog = new MessageDialog("Check HeightValue!");
                    await dialog.ShowAsync();
                }



                if (!double.TryParse(WTextBox.Text, out FrameWidth))
                {
                    var dialog = new MessageDialog("Check Frame Width Value!");
                    await dialog.ShowAsync();
                }
                WindowAreaTextBox.Text = CalculateArea(WindowWidth, WindowHeight).ToString() + "cm^2";
                ClassAreaTextBox.Text = CalculateClassArea(WindowWidth, WindowHeight, FrameWidth).ToString() + "cm^2";
                CircleTextBox.Text = CalculateCircle(WindowWidth, WindowHeight).ToString() + "cm";
            }
        
        

        public double CalculateArea(double WindowWidth, double WindowHeight)
        {
            return WindowWidth * WindowHeight;
        }
        public double CalculateClassArea(double WindowWidth, double WindowHeight, double FrameWidth)
        {
            return (WindowWidth - 2 * FrameWidth) * (WindowHeight - 2 * FrameWidth) ;
        }

        public double CalculateCircle(double WindowWidth, double WindowHeight)
        {
            return (2 * WindowHeight + (2 * WindowWidth));
        }





    }
    }

