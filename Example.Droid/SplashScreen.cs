using Android.App;
using Android.Content.PM;
using MvvmCross.Core;
using MvvmCross.Platforms.Android.Views;

namespace Example.Droid
{
    [Activity(
        Label = "MvvmCross Example"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
            MvxSetup.RegisterSetupType<Setup>(this.GetType().Assembly);
        }
    }
}