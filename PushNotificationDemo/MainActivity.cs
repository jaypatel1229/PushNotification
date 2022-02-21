using Android.App;
using Android.Gms.Extensions;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Firebase.Messaging;
using System;
using System.Threading.Tasks;

namespace PushNotificationDemo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            _ = GetFirebaseToken();
        }

        private async Task GetFirebaseToken()
        {
            var token = await FirebaseMessaging.Instance.GetToken();
        }
    }
}