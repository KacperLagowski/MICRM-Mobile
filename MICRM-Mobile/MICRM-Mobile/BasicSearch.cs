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
using SIML.CRMData;
using System.Data;

namespace MICRM_Mobile
{
    [Activity(Label = "BasicSearch")]
    public class BasicSearch : Activity
    {
        Button search;
        EditText searchControl;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SimpleSearch);
            
            search = FindViewById<Button>(Resource.Id.searchButton);
            search.Click += Search_Click;
            searchControl = FindViewById<EditText>(Resource.Id.searchControl);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            List<String> searchterms = searchControl.Text.Split(' ').ToList();
            while(searchterms.Count < 3)
            {
                searchterms.Add(String.Empty);
            }
            CRMDataCommand dc = new CRMDataCommand("spMobileSearch");
            dc.ParameterAdd("SearchTerm1", searchterms[0]);
            dc.ParameterAdd("SearchTerm2", searchterms[1]);
            dc.ParameterAdd("SearchTerm3", searchterms[2]);
            DataTable dt = dc.FillDataTable();
            if (dt != null)
            {
                Android.Widget.Toast.MakeText(this, "hello", ToastLength.Short).Show();
            }

        }
    }
    }
