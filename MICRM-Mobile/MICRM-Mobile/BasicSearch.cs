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
using Android.Graphics;

namespace MICRM_Mobile
{
    [Activity(Label = "BasicSearch")]
    public class BasicSearch : Activity
    {
        string[] items = { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
        ListView MainList;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SimpleSearch);
            MainList = FindViewById<ListView>(Resource.Id.MainList);
            MainList.item .ItemsSource
            

        }


    }
    }
