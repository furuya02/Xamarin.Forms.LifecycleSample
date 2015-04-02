using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace App1.Droid
{
    [Activity(Label = "App1", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, LaunchMode = LaunchMode.Multiple)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            App.Log();//ログ出力
        }

        protected override void OnStart() {
            App.Log();//ログ出力
            base.OnStart();
        }

        protected override void OnResume()
        {
            App.Log();//ログ出力
            base.OnResume();
        }

        protected override void OnPause()
        {
            App.Log();//ログ出力
            base.OnPause();
        }

        protected override void OnStop()
        {
            App.Log();//ログ出力
            base.OnStop();
        }

        protected override void OnDestroy()
        {
            App.Log();//ログ出力
            base.OnDestroy();
        }

        protected override void OnRestart()
        {
            App.Log();//ログ出力
            base.OnRestart();
        }

        //LaunchMode.Multiple
        protected override void OnPostCreate(Bundle savedInstanceState)
        {
            App.Log();//ログ出力
            base.OnPostCreate(savedInstanceState);
        }


        protected override void OnPostResume()
        {
            App.Log();//ログ出力
            base.OnPostResume();
        }

        protected override void OnUserLeaveHint()
        {
            App.Log();//ログ出力
            base.OnUserLeaveHint();
        }

        public override bool OnCreateThumbnail(Bitmap outBitmap, Canvas canvas)
        {
            App.Log();//ログ出力
            return base.OnCreateThumbnail(outBitmap, canvas);
        }


        
        protected override void OnRestoreInstanceState(Bundle savedInstanceState)
        {
            App.Log();//ログ出力
            base.OnRestoreInstanceState(savedInstanceState);
        }


        protected override void OnSaveInstanceState(Bundle outState) {
            App.Log();//ログ出力
            base.OnSaveInstanceState(outState);
        }



        protected override void OnNewIntent(Intent intent) {
            App.Log();//ログ出力
            base.OnNewIntent(intent);
        }



    }
}

