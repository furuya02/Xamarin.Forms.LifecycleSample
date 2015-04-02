using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace App1.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            App.Log();

            return base.FinishedLaunching(app, options);
        }


        public override bool WillFinishLaunching(UIApplication uiApplication, NSDictionary launchOptions) {
            App.Log();
            return base.WillFinishLaunching(uiApplication, launchOptions);
        }

        public override void OnActivated(UIApplication application) {
            App.Log();
            base.OnActivated(application);
        }

        public override void OnResignActivation(UIApplication uiApplication) {
            App.Log();
            base.OnResignActivation(uiApplication);
        }

        public override void DidEnterBackground(UIApplication uiApplication) {
            App.Log();
            base.DidEnterBackground(uiApplication);
        }

        public override void WillEnterForeground(UIApplication uiApplication) {
            App.Log();
            base.WillEnterForeground(uiApplication);
        }

        public override void WillEncodeRestorableState(UIApplication application, NSCoder coder) {
            App.Log();
            base.WillEncodeRestorableState(application, coder);
        }

        public override void WillTerminate(UIApplication uiApplication) {
            App.Log();
            base.WillTerminate(uiApplication);
        }
    }
}
