ShakeDetection
==============

Windows Phone Shake Detection Class

I think it is cool to have a Windows Phone application that the content can be updated by shaking the phone, so I wrote this Class in order to achieve that!!

```CSharp

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
 
 ```
