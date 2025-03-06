using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using Android.Content;

namespace Cometa_Estremos_Machine_Problem
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button signUp, logIn;
        ImageView logo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            signUp = FindViewById<Button>(Resource.Id.button1);
            logIn = FindViewById<Button>(Resource.Id.button2);
            logo = FindViewById<ImageView>(Resource.Id.imageView1);

            logo.SetImageResource(Resource.Drawable.logo_Moneyco);

            signUp.Click += this.UserSignUp;
            logIn.Click += this.UserLogIn;
        }
        protected void UserSignUp (object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(SignUpPage));
            StartActivity(i);
        }
        protected void UserLogIn(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(LogIn));
            StartActivity(i);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}