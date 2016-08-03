using System;
using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using Uri = Android.Net.Uri;
using SIML.CRMData;


namespace MICRM_Mobile
{
    [Activity(Label = "MICRM-M", MainLauncher = true, Icon = "@drawable/crm")]
    public class MainActivity : Activity
    {
        EditText usernameText;
        EditText passwordText;
        Button login;
        TextView help;
        string teststring = "j";

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            CRMDataCommand dm = new CRMDataCommand();
            dm.ConnectionStringDescoveryEngine = new ConnectionStringProvider();

            // The main layout
            SetContentView(Resource.Layout.Main);


            //controls declared in the region below:
            #region 
            Button myButton = FindViewById<Button>(Resource.Id.loginButton);
            myButton.Click += MyButton_Click;
            usernameText = FindViewById<EditText>(Resource.Id.usernameTextBox);
            usernameText.Click += usernameText_Click;
            passwordText = FindViewById<EditText>(Resource.Id.passwordTextBox);
            passwordText.Click += passwordText_Click;
            ImageButton micrmButton = FindViewById<ImageButton>(Resource.Id.micrmButton);
            micrmButton.Click += micrmButton_Click;
            login = FindViewById<Button>(Resource.Id.loginButton);
            login.Click += Login_Click;
            help = FindViewById<TextView>(Resource.Id.helpinfoLabel);
            help.Click += Help_Click;

            #endregion


        }

        private void Help_Click(object sender, EventArgs e)
        {
            usernameText.Text = teststring;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            
                
                StartActivity(typeof(Menu));
            Android.Widget.Toast.MakeText(this, new CRMDataCommand("sp_SayHello").FillDataRow().CRMToString("Message"), ToastLength.Short).Show();

            //else
            //{
            //    Android.Widget.Toast.MakeText(this, "Check your VPN Connection!", ToastLength.Long).Show();
            //}
        }

        private void micrmButton_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(Intent.ActionCall, Uri.Parse("tel:01519062482")));

        }


        private void passwordText_Click(object sender, EventArgs e)
        {
            passwordText.Text = String.Empty;
        }
        private void usernameText_Click(object sender, EventArgs e)
        {
            usernameText.Text = String.Empty;
        }
        private void MyButton_Click(object sender, EventArgs e)
        {

        }
    }
}


