using System;
using Android.Content.Res;
using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using System.Collections;

namespace MTGCounters
{
    public class App : Application
    {
        public App()
        {
            
            BindingContext = new MainPageViewModel();
            MainPage = new NavigationPage(new MainPageView())
            {
                BarBackgroundColor = Color.Black,
                BarTextColor = Color.White,
            };
            
        }
        
    }
}
