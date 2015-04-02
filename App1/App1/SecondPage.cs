using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    //２つ目のページ
    class SecondPage : ContentPage
    {
        public SecondPage()
        {
            BackgroundColor = Color.Pink;//背景色(ピンク)
        }
        protected override void OnAppearing()
        {
            App.Log();//ログ出力
            base.OnAppearing();
        }
    }

}
