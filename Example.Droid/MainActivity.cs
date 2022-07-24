using Android.App;
using Android.OS;
using Example.Core.ViewModels;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;

namespace Example.Droid
{
    [Activity(Label = "@string/app_name")]
    [MvxActivityPresentation(ViewModelType = typeof(StartViewModel))]
    public class FirstView : MvxActivity<StartViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.StartView);
        }
    }

}
