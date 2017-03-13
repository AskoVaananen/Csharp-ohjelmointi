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

namespace T3
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

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            // Textbox for rows, used inside scrollviewer and new lotto instance.
            Lotto lotto = new Lotto();
            TextBox LottoBox = new TextBox();

            // LottoBox must accept line-end character to start new line in ti.
            LottoBox.AcceptsReturn = true;
            //number of rows
            for (int i = 1; i <= int.Parse(drawsTextBox.Text); i++)
            {   
                int[] numerot = lotto.Generate(); // generate new row (from lotto class).
                foreach (int s in numerot) // array to string
                {
                    LottoBox.Text += s.ToString() + " "; // adding row to lottobox

                }
                LottoBox.Text += Environment.NewLine; // adds newline

                // Lottobox inside scrollviewer.
                scrollViewer.Content = (LottoBox);
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e) // clear text from lottobox and drawsbox
        {
            drawsTextBox.Text = " ";
            scrollViewer.Content = " ";
            
        }
    }
}
