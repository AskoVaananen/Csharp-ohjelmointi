using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace T6
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Butterfly : UserControl
    {
        private int currentFrame = 0;
        private int direction = 1;
        private int frameHeigth = 132; // 5*132 = 660 = koko kuvan korkeus
			

        public double LocationX { get; set; }
        public double LocationY { get; set; }

        private readonly double MaxSpeed = 10.0;
        private readonly double Accelerate = 0.5;
        private double speed;
        private double Angle = 0;
        private double AngleStep = 5;
        private DispatcherTimer timer;


        public Butterfly()
        {
            this.InitializeComponent();
            Width = 150;
            Height = 132;

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 125);
            timer.Tick += Timer_Tick;
            timer.Start();
       
					
        }
        private void Timer_Tick(object sender, object e)
        {
            // frame
            if (direction == 1) currentFrame++;
            else currentFrame--;
            if (currentFrame == 0 || currentFrame == 4) direction = -1 * direction;
            // set offset
            SpriteSheetOffset.Y = currentFrame * -frameHeigth;
        }

       
        public void Move()
        {
						
            // update location values (with angle and speed)
            LocationX -= (Math.Cos(Math.PI / 180 * (Angle + 90))) * speed;
            LocationY -= (Math.Sin(Math.PI / 180 * (Angle + 90))) * speed;
        }

        public void Rotate(int angle)
        {
            Angle += angle * AngleStep;
            ButterflyRotateAngle.Angle = Angle;
        }

        public Rect GetRect()
        {
            return new Rect(LocationX, LocationY, Width, Height);
        }
        public void UpdateLocation()
        {
            SetValue(Canvas.LeftProperty, LocationX);
            SetValue(Canvas.TopProperty, LocationY);
        }
    }
    }

