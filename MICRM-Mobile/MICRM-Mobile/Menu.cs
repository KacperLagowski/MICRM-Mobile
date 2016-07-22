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
        Button basic;
        Button rating;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            
            SetContentView(Resource.Layout.Menu);

            sen = FindViewById<Button>(Resource.Id.contactsButton);
            sen.Click += Sen_Click1;

            basic = FindViewById<Button>(Resource.Id.searchButton);
            basic.Click += Basic_Click;

            rating = FindViewById<Button>(Resource.Id.ratingButton);
            rating.Click += Rating_Click;
        }

        private void Rating_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(RatingSearch));
        }

        private void Basic_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(BasicSearch));
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