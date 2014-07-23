using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Devices.Sensors;

namespace shakeDetection
{
    public partial class MainPage : PhoneApplicationPage
    {

        //We instanciate the AccelerometerSensorWithShakeDetection class as a prperty in order to be available in all methods for the MainPage class
        AccelerometerSensorWithShakeDetection _shakeSensor = new AccelerometerSensorWithShakeDetection();

        public MainPage()
        {
            InitializeComponent();

            //in the costructor of the MainPage class, we call the SetUpEvent method, and we pass the MainPage Class as context scope, and the event we want to call
            //when the device is Shacked
            _shakeSensor.SetUpEvent(this, ShakeDetected);
        }

        //created a custom event to call the method that contain the code to execute when the device is shaked
        private void ShakeDetected(object sender, EventArgs e)
        {
            //use this method to call MethodToExecWhenTheDeviceIsShaked method in another thread, different from the accelerometer thread
            _shakeSensor.DispatcherInvoke(MethodToExecWhenTheDeviceIsShaked);
        }

        private void MethodToExecWhenTheDeviceIsShaked() 
        {
            myStoryboard.Begin();
            //plase here the code you want to exec when the device is shaked
        }


        private void Rectangle_Tapped(object sender, MouseButtonEventArgs e)
        {
            myStoryboard.Begin();
        }


    }
}