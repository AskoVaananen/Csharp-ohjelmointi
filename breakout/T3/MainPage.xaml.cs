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

namespace T3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private DispatcherTimer dispatcherTimer;
        private int timesTicked = 1;
        private int timesToTick = 10;
        Stopwatch watch;
        Stopwatch totaltime;
        public MainPage()
        
        {

            this.InitializeComponent();

            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

            TimerLog.Text += "dispatcherTimer.IsEnabled " + "=" + dispatcherTimer.IsEnabled.ToString() + Environment.NewLine;
            TimerLog.Text += "Calling dispatcherTimer.Start()\n";
            dispatcherTimer.Start();
            watch = Stopwatch.StartNew();
            totaltime = Stopwatch.StartNew();
            TimerLog.Text += "dispatcherTimer.IsEnabled " + "=" + dispatcherTimer.IsEnabled.ToString() + Environment.NewLine;


        }
        void dispatcherTimer_Tick(object sender, object e)
        {
            if (timesTicked <= timesToTick)
            {
                var elapsed = watch.ElapsedMilliseconds;
              
                TimerLog.Text += timesTicked + "  " + DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss.ffffff")  + " " +  " time elapsed since last tick" + " " + elapsed + " ms" + Environment.NewLine;
                watch.Stop();
                watch = Stopwatch.StartNew();
                
            }
            else
            { 
                TimerLog.Text += "Calling dispatcherTimer.Stop()\n";
                dispatcherTimer.Stop();
                
                TimerLog.Text += "dispatcherTimer.IsEnabled " + "=" + dispatcherTimer.IsEnabled.ToString() + Environment.NewLine;
                var elapsedtotal = totaltime.ElapsedMilliseconds;
                TimerLog.Text += "Totaltime start - stop: " + elapsedtotal + " " + "ms";
            }
            
            timesTicked++;
            
            
            


        }
        
    }
}
