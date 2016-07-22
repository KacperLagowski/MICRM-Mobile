using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MICRM_Mobile
{
    [Activity(Label = "Menu")]
    public class Menu : Activity
    {
        Button sen;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            
            SetContentView(Resource.Layout.Menu);

            sen = FindViewById<Button>(Resource.Id.contactsButton);
            sen.Click += Sen_Click1;
        }

        private void Sen_Click1(object sender, EventArgs e)
        {
            StartActivity(typeof(Seneca));
        }

        private void Sen_Click(object sender, EventArgs e)
        {
        }
    }
}