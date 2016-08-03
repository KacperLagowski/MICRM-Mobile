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
        public int contactid;
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
            ListView lv = (ListView)FindViewById(Resource.Id.MainList);
            var adapter = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.user_array, Android.Resource.Layout.SimpleSpinnerItem);

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            lv.Adapter = adapter;

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
            foreach (DataRow row in dt.Rows)
            {
                int ID = row.CRMToInt("ID");
                string FirstName = row["FirstName"].ToString();
                string LastName = row["LastName"].ToString();
                string JobTitle = row["JobTitle"].ToString();
                string FirmName = row["FirmName"].ToString();
                string Email = row["Email"].ToString();
                string TelephoneMobile = row["TelephoneMobile"].ToString();
                string AddressHome = row["AddressHome"].ToString();
                string AddressLine1 = row["AddressLine1"].ToString();
                string AddressLine2 = row["AddressLine2"].ToString();
                string AddressLine3 = row["AddressLine3"].ToString();
                string City = row["City"].ToString();
                string Country = row["Country"].ToString();
                string Postcode = row["Postcode"].ToString();
            }
            
            contactid = 566;
            Intent results = new Intent(this, typeof(SearchResults));
            results.PutExtra("contactid", contactid);
            StartActivity(results);
            //StartActivity(typeof(SearchResults));
        }
    }
    }
