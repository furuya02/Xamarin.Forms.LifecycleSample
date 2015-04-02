using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    class TopPage : ContentPage
    {
        public TopPage()
        {
            BackgroundColor = Color.Lime;//背景色(ライム)

            //次ぼページ(SecondPage)を開くボタン
            var button1 = new Button
            {
                Text = "Next",
                Command = new Command(async () =>
                {
                    await Navigation.PushAsync(new SecondPage());
                })

            };
            //ブラウザを開くボタン
            var button2 = new Button
            {
                Text = "Browser",
                Command = new Command(() =>
                {
                    Device.OpenUri(new Uri("http://xamarin.com/"));
                })

            };
            //２つのボタンを上下に配置する
            Content = new StackLayout
            {
                Children = { button1, button2 }
            };
        }

        protected override void OnAppearing()
        {
            App.Log();//ログ出力
            base.OnAppearing();
        }
    }
}
