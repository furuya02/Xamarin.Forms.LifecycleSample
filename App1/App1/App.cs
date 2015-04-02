using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.IO;

using Xamarin.Forms;

namespace App1
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new TopPage());
        }
        public static void Log([CallerFilePath] string file = "", [CallerMemberName] string member = ""){
            Debug.WriteLine(string.Format("■{0}.{1}()", Path.GetFileNameWithoutExtension(file).Split('\\').LastOrDefault(), member));
        }


        protected override void OnStart(){
            Log();
        }

        protected override void OnSleep(){
            Log();
        }

        protected override void OnResume(){
            Log();
        }
    }

}
