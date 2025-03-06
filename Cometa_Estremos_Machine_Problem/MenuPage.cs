using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using AndroidX.AppCompat.App;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cometa_Estremos_Machine_Problem
{
    [Activity(Label = "Menu Page")]
    public class MenuPage : AppCompatActivity
    {
        ImageView logo;
        TextView displayName;
        String userMobileNum;
        String[] userData;
        Button add_button, send_button, transaction_button, edit_button, logout_button;

        DatabaseClass command = new DatabaseClass();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.MenuPage);

            userMobileNum = Intent.GetStringExtra("UserMobileNum");

            displayName = FindViewById<TextView>(Resource.Id.textView4);

            add_button = FindViewById<Button>(Resource.Id.button1);
            send_button = FindViewById<Button>(Resource.Id.button2);
            transaction_button = FindViewById<Button>(Resource.Id.button3);
            edit_button = FindViewById<Button>(Resource.Id.button4);
            logout_button = FindViewById<Button>(Resource.Id.button5);
            logo = FindViewById<ImageView>(Resource.Id.imageView1);

            logo.SetImageResource(Resource.Drawable.logo_Moneyco);

            GetUsername(userMobileNum);

            add_button.Click += this.RedirectAddMoney;
            send_button.Click += this.RedirectSendMoney;
            transaction_button.Click += this.RedirectViewTrans;
            edit_button.Click += this.RedirectEditProf;
            logout_button.Click += this.LogOut;
        }
        protected void RedirectAddMoney(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(AddMoney));
            i.PutExtra("UserMobileNum", userMobileNum);  //passing log-in information from one activity to the other
            StartActivity(i);
        }
        protected void RedirectSendMoney(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(SendMoneyPage));
            i.PutExtra("UserMobileNum", userMobileNum);  //passing log-in information from one activity to the other
            StartActivity(i);
        }
        protected void RedirectViewTrans(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(ViewTransHistory));
            i.PutExtra("UserMobileNum", userMobileNum);  //passing log-in information from one activity to the other
            StartActivity(i);
        }
        protected void RedirectEditProf(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(EditProfile));
            i.PutExtra("UserMobileNum", userMobileNum);  //passing log-in information from one activity to the other
            StartActivityForResult(i, 0);
        }
        protected void LogOut(object sender, EventArgs e)
        {
            Finish();
        }
        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (resultCode == Result.Ok)
            {
                string stringRetFromResult = data.GetStringExtra("UserMobileNum");
                GetUsername(stringRetFromResult);
            }
        }
        protected void GetUsername(string mobileNum)
        {
            userData = command.GetUserData(mobileNum);
            displayName.Text = userData[0];
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}