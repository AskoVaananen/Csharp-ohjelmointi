using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace H09T2
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

        private void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
        {
            Person person = new Person { FirstName = FirstnameBox.Text, LastName = LastnameBox.Text };
            this.Frame.Navigate(typeof(Page2), person);
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            GreetingTextBlock.Text = ("Number is " + (App.Current as App).Number);
        }

      
    }
}
