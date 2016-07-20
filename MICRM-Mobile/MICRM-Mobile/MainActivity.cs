using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Uri = Android.Net.Uri;
using static Android.Views.View;

namespace MICRM_Mobile
{
    [Activity(Label = "MICRM-M", MainLauncher = true, Icon = "@drawable/crm")]
    public class MainActivity : Activity
    {
        EditText usernameText;
        EditText passwordText;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button myButton = FindViewById<Button>(Resource.Id.loginButton);
            myButton.Click += MyButton_Click;
            usernameText = FindViewById<EditText>(Resource.Id.usernameTextBox);
            usernameText.Click += usernameText_Click;
            passwordText = FindViewById<EditText>(Resource.Id.passwordTextBox);
            passwordText.Click += passwordText_Click;
            ImageButton micrmButton = FindViewById<ImageButton>(Resource.Id.micrmButton);
            micrmButton.Click += micrmButton_Click;


        }

        private void micrmButton_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Intent.ActionCall, Uri.Parse("tel:01519062482")));
            
        }
  

        private void passwordText_Click(object sender, EventArgs e)
        {
            passwordText.Text = "";
        }
        private void usernameText_Click(object sender, EventArgs e)
        {
            usernameText.Text = "";
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}

